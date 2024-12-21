using System;
using System.IO;
using System.Numerics;
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class RSA : Form
    {
        private BigInteger n, phi, publicExponent, d;

        public RSA()
        {
            InitializeComponent();
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger p = BigInteger.Parse(txtP.Text);
                BigInteger q = BigInteger.Parse(txtQ.Text);
                publicExponent = BigInteger.Parse(txtE.Text);

                if (!IsPrime(p) || !IsPrime(q))
                {
                    MessageBox.Show("p và q phải là số nguyên tố!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                n = p * q;
                phi = (p - 1) * (q - 1);

                if (Gcd(publicExponent, phi) != 1)
                {
                    MessageBox.Show("e phải nguyên tố cùng nhau với phi(n)!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                d = ModInverse(publicExponent, phi);

                txtPublicKey.Text = $"({n}, {publicExponent})";
                txtPrivateKey.Text = $"({n}, {d})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRandomKeys_Click(object sender, EventArgs e)
        {
            try
            {
                Random random = new Random();
                BigInteger p, q;
                do
                {
                    p = GenerateRandomPrime(random);
                    q = GenerateRandomPrime(random);
                } while (p == q);

                phi = (p - 1) * (q - 1);

                do
                {
                    publicExponent = GenerateRandomPrime(random);
                } while (Gcd(publicExponent, phi) != 1);

                txtP.Text = p.ToString();
                txtQ.Text = q.ToString();
                txtE.Text = publicExponent.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;

                StringBuilder outputBuilder = new StringBuilder();
                foreach (char c in input)
                {
                    BigInteger charValue = new BigInteger(c);
                    BigInteger encryptedChar = ModPow(charValue, publicExponent, n);
                    outputBuilder.Append((char)encryptedChar.ToByteArray()[0]);
                }

                txtOutput.Text = outputBuilder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;

                StringBuilder outputBuilder = new StringBuilder();
                foreach (char c in input)
                {
                    BigInteger charValue = new BigInteger(c);
                    BigInteger decryptedChar = ModPow(charValue, d, n);
                    outputBuilder.Append((char)decryptedChar.ToByteArray()[0]);
                }

                txtOutput.Text = outputBuilder.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "All Files (*.*)|*.*", // Cho phép tất cả các loại tệp
                    Title = "Chọn tệp bất kỳ"
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    // Đọc tệp và hiển thị nội dung nếu có thể
                    if (Path.GetExtension(filePath).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    {
                        string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
                        txtInput.Text = fileContent;
                    }
                    else
                    {
                        txtInput.Text = $"Không thể hiển thị nội dung của tệp: {Path.GetFileName(filePath)}";
                        MessageBox.Show("Tệp được chọn không phải là tệp văn bản. Chỉ có thể đọc được các tệp .txt.",
                                        "Thông báo",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                // Sử dụng FolderBrowserDialog để chọn thư mục
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Chọn thư mục để lưu tệp";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedPath = folderBrowserDialog.SelectedPath;

                        // Yêu cầu người dùng nhập tên tệp
                        string fileName = Microsoft.VisualBasic.Interaction.InputBox(
                            "Nhập tên tệp (không cần thêm đuôi .txt):",
                            "Lưu tệp",
                            "output"
                        );

                        if (!string.IsNullOrWhiteSpace(fileName))
                        {
                            string fullPath = Path.Combine(selectedPath, fileName + ".txt");

                            // Lưu nội dung từ txtOutput vào tệp
                            File.WriteAllText(fullPath, txtOutput.Text, Encoding.UTF8);

                            MessageBox.Show($"Đã lưu tệp thành công tại: {fullPath}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Tên tệp không hợp lệ. Hãy thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu tệp: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsPrime(BigInteger number)
        {
            if (number < 2) return false;
            for (BigInteger i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private BigInteger Gcd(BigInteger a, BigInteger b)
        {
            while (b != 0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void BackMenu_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            BigInteger m0 = m, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (m == 1) return 0;

            while (a > 1)
            {
                q = a / m;
                t = m;

                m = a % m;
                a = t;
                t = x0;

                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0) x1 += m0;

            return x1;
        }

        private BigInteger ModPow(BigInteger baseValue, BigInteger exponent, BigInteger modulus)
        {
            BigInteger result = 1;
            baseValue %= modulus;

            while (exponent > 0)
            {
                if ((exponent & 1) == 1)
                    result = (result * baseValue) % modulus;

                exponent >>= 1;
                baseValue = (baseValue * baseValue) % modulus;
            }

            return result;
        }

        private BigInteger GenerateRandomPrime(Random random)
        {
            while (true)
            {
                int num = random.Next(1, 100);
                if (IsPrime(num)) return new BigInteger(num);
            }
        }
    }
}
