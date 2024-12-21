using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RSA
{
    public partial class PlayFair : Form
    {

        int counter, i, z = 0;
        string key;
        string text = "";
        int width = 5, hight = 5;
        char[,] tempList;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer3 = new System.Windows.Forms.Timer();

        public PlayFair()
        {
            tempList = new char[width, hight];
            counter = i = 0;
            key = "";
            InitializeComponent();
        }

        private void BackMenubtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        async void Wait(int n)
        {
            await System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(n));
        }
        static List<char> textList = new List<char>();
        void initPlainText(string text)
        {
            text = text.ToUpper();
            foreach (var t in text)
            {
                if (t == ' ') continue;
                else if (t == 'J') textList.Add('I');
                textList.Add(t);
            }
        }
        List<char> CreatePlainText()
        {
            List<char> tempList = new List<char>();

            for (int i = 0; i < textList.Count - 1; i++) //so sánh hai ký tự và thêm X nếu giống nhau
            {
                if (textList[i] == textList[i + 1])
                {
                    tempList.Add(textList[i]);
                    tempList.Add('X');
                    continue;
                }
                else tempList.Add(textList[i]);

            }
            tempList.Add(textList[textList.Count - 1]);

            if (tempList.Count % 2 == 1) tempList.Add('X');

            return tempList;
        }
        List<char> getAlphbt()
        {
            List<char> tempList = new List<char>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (i == 'J') continue;
                tempList.Add(i);
            }
            return tempList;
        }
        List<char> CreateTable(string key)
        {
            key = key.ToUpper();
            List<char> tempList = new List<char>();
            List<char> alphbtList = getAlphbt();
            tempList = key.Distinct().ToList(); // xóa ký tự trùng lặp khỏi khóa


            for (int i = 0; i < tempList.Count; i++) //so sánh các ký tự khóa và ký tự chữ cái và loại bỏ các ký tự trùng lặp
            {
                for (int j = 0; j < alphbtList.Count; j++)
                {
                    if (tempList[i] == alphbtList[j])
                    {
                        alphbtList.Remove(alphbtList[j]);
                    }
                }
            }
            foreach (var item in alphbtList)
            {
                tempList.Add(item);
            }
            return tempList;
        }

        void ResetData()
        {
            timer = new System.Windows.Forms.Timer();
            timer2 = new System.Windows.Forms.Timer();
            timer3 = new System.Windows.Forms.Timer();
            tempList = new char[width, hight];
            counter = i = 0;
            key = "";
            plainxLable.Text = "PlainX : ";
            tempList = new char[width, hight];
        }

        private void encBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Encryption - Original in same line";
            ResetData();
            string plainText = inputContent.Text;
            key = keyTextbox.Text;
            string plainX = "";
            if (string.IsNullOrEmpty(plainText) || (string.IsNullOrEmpty(key)))
                return;


            initPlainText(plainText);
            foreach (var item in CreatePlainText())
            {
                plainX += item;
            }
            //plainxLable.Text += plainX;

            timer.Interval = (1 * 300);
            timer.Tick += new EventHandler(Timer_Tick1);
            timer.Start();

        }

        private void PlayFair_Load(object sender, EventArgs e)
        {

            Button[] btn = {button1,button2,button3,button4,button5,
button6,button7,button8,button9,button10,
button11,button12,button13,button14,button15,
button16,button17,button18,button19,button20,
button21,button22,button23,button24,button25,};
            for (int i = 0; i < 25; i++)
            {
                btn[i].Text = "";
                btn[i].BackColor = Color.Gainsboro;

            }
        }

        private void matrix5x5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void matrix6x6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void decBtn_Click(object sender, EventArgs e)
        {
            label2.Text = "Decryption - Original in same line";
            ResetData();
            string plainText = inputContent.Text;
            key = keyTextbox.Text;
            string plainX = "";
            if (string.IsNullOrEmpty(plainText) || (string.IsNullOrEmpty(key)))
                return;


            initPlainText(plainText);
            foreach (var item in CreatePlainText())
            {
                plainX += item;
            }
            //plainxLable.Text += plainX;

            timer.Interval = (1 * 300);
            timer.Tick += new EventHandler(Timer_Tick2);
            timer.Start();
        }

        private void Timer_Tick1(object sender, EventArgs e)
        {
            timer.Stop();
            label4.Text = "Create Table Process...";
            outputContent.Text = "";

            Button[] btn = {button1,button2,button3,button4,button5,
            button6,button7,button8,button9,button10,
            button11,button12,button13,button14,button15,
            button16,button17,button18,button19,button20,
            button21,button22,button23,button24,button25,};
            if (counter >= 25)
            {
                timer.Stop();
                timer.Enabled = false;
                for (int i = 0; i < width * hight; i++) 
                {
                    tempList[i / width, i % hight] = CreateTable(key)[z];
                    z++;
                }
                timer2.Interval = (4 * 1000);
                timer2.Tick += new EventHandler(Timer2_Tick);
                timer2.Start();

                return;
            }
            btn[counter].Text = Convert.ToString(CreateTable(key)[counter]);
            counter++;
            timer.Enabled = true;
        }

        void ResetButtonColor()
        {
            Button[] btn = {button1,button2,button3,button4,button5,
            button6,button7,button8,button9,button10,
            button11,button12,button13,button14,button15,
            button16,button17,button18,button19,button20,
            button21,button22,button23,button24,button25,};
            for (int q = 0; q < 25; q++)
            {
                btn[q].BackColor = Color.Gainsboro;

            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label4.Text = "Encryption Text Process...";
            if (i >= CreatePlainText().Count)
            {
                timer2.Stop();
                timer2.Enabled = false;
                ResetButtonColor();
                MessageBox.Show("Encryption Finished!", "Playfair");
                label4.Text = "Encryption Finished!";
                return;
            }


            Button[] btn = {button1,button2,button3,button4,button5,
            button6,button7,button8,button9,button10,
            button11,button12,button13,button14,button15,
            button16,button17,button18,button19,button20,
            button21,button22,button23,button24,button25,};

            ResetButtonColor();
            char Ch1 = CreatePlainText()[i]; //kí tự đầu
            char Ch2 = CreatePlainText()[i + 1];//kí tự thứ 2
            int[] btnIndex = new int[2];
            for (int i = 0; i < btn.Length; i++)
            {
                if (btn[i].Text == Convert.ToString(Ch1))
                {
                    btnIndex[0] = i;
                }
                if (btn[i].Text == Convert.ToString(Ch2))
                {
                    btnIndex[1] = i;
                }
            }

            btn[btnIndex[0]].BackColor = Color.Red;
            btn[btnIndex[1]].BackColor = Color.Red;

            int row1 = 0, row2 = -1, col1 = 0, col2 = -1;

            for (int j = 0; j < width * hight; j++)
            {

                if (tempList[j / width, j % hight] == Ch1) // lấy chỉ số hàng char đầu tiên và chỉ số cột
                {
                    row1 = j / width;
                    col1 = j % hight;
                }
                if (tempList[j / width, j % hight] == Ch2) // lấy chỉ số hàng char thứ hai và chỉ số cột
                {
                    row2 = j / width;
                    col2 = j % hight;
                }
            }



            int n = width;
            //kiểm tra xem ký tự đầu tiên và ký tự thứ hai có cùng hàng không
            /*   if (row1 == row2)
               {
                   if (btn[btnIndex[0]].Text == btn[(row1 * n) + (col1 + 1) % hight].Text ||
                       btn[btnIndex[1]].Text == btn[(row1 * n) + (col1 + 1) % hight].Text
                       )
                   {
                       btn[(row1 * n) + (col1 + 1) % hight].BackColor = Color.Yellow;
                   }
                   else
                       btn[(row1 * n) + (col1 + 1) % hight].BackColor = Color.Blue;

                   if (btn[btnIndex[0]].Text == btn[(row2 * n) + (col2 + 1) % hight].Text ||
       btn[btnIndex[1]].Text == btn[(row2 * n) + (col2 + 1) % hight].Text
       )
                   {
                       btn[(row1 * n) + (col1 + 1) % hight].BackColor = Color.Yellow;
                   }
                   else
                       btn[(row2 * n) + (col2 + 1) % hight].BackColor = Color.Blue;
                   text += (tempList[row1, (col1 + 1) % hight] + "" + tempList[row2, (col2 + 1) % hight]);
               }
               //kiểm tra xem ký tự đầu tiên và ký tự thứ hai có nằm trên cùng một cột không
               else if (col1 == col2)
               {
                   if (btn[btnIndex[0]].Text == btn[(((row2 + 1) % hight) * n) + col2].Text ||
       btn[btnIndex[1]].Text == btn[(((row2 + 1) % hight) * n) + col2].Text
       )
                   {
                       btn[(((row2 + 1) % hight) * n) + col2].BackColor = Color.Yellow;
                   }
                   else
                       btn[(((row2 + 1) % hight) * n) + col2].BackColor = Color.Blue;

                   if (btn[btnIndex[0]].Text == btn[(((row2 + 1) % hight) * n) + col1].Text ||
       btn[btnIndex[1]].Text == btn[(((row2 + 1) % hight) * n) + col1].Text
       )
                   {
                       btn[(((row2 + 1) % hight) * n) + col1].BackColor = Color.Yellow;
                   }
                   else
                       btn[(((row2 + 1) % hight) * n) + col1].BackColor = Color.Blue;



                   text += (tempList[(row1 + 1) % hight, col1] + "" + tempList[(row2 + 1) % hight, col2]);
               }
               else
               {
                   btn[(row1 * n) + col2].BackColor = Color.Blue;
                   btn[(row2 * n) + col1].BackColor = Color.Blue;
                   text += (tempList[row1, col2] + "" + tempList[row2, col1]);
                   //  Console.Write(tempList[row2, col1] + "" + tempList[row1, col2]); //another slove

               }*/
            if (row1 == row2)
            {
                // Xử lý cùng hàng
                btn[(row1 * n) + (col1 + 1) % hight].BackColor = Color.Yellow;
                btn[(row2 * n) + (col2 + 1) % hight].BackColor = Color.Blue;
                text += tempList[row1, (col1 + 1) % hight] + "" + tempList[row2, (col2 + 1) % hight];
            }
            else if (col1 == col2)
            {
                // Xử lý cùng cột
                btn[(((row1 + 1) % hight) * n) + col1].BackColor = Color.Yellow;
                btn[(((row2 + 1) % hight) * n) + col2].BackColor = Color.Blue;
                text += tempList[(row1 + 1) % hight, col1] + "" + tempList[(row2 + 1) % hight, col2];
            }
            else
            {
                // Xử lý trường hợp còn lại
                btn[(row1 * n) + col2].BackColor = Color.Blue;
                btn[(row2 * n) + col1].BackColor = Color.Blue;
                text += tempList[row1, col2] + "" + tempList[row2, col1];
            }

            outputContent.Text = text;
            plainxLable.Text += Ch1 + "" + Ch2;
            i += 2;
            timer2.Enabled = true;

        }

        private void Timer_Tick2(object sender, EventArgs e)
        {
            timer.Stop();
            label4.Text = "Create Table Process...";
            outputContent.Text = "";

            Button[] btn = {button1,button2,button3,button4,button5,
            button6,button7,button8,button9,button10,
            button11,button12,button13,button14,button15,
            button16,button17,button18,button19,button20,
            button21,button22,button23,button24,button25,};
            if (counter >= 25)
            {
                timer.Stop();
                timer.Enabled = false;
                for (int i = 0; i < width * hight; i++)
                {
                    tempList[i / width, i % hight] = CreateTable(key)[z];
                    z++;
                }
                timer3.Interval = (4 * 1000);
                timer3.Tick += new EventHandler(Timer3_Tick);
                timer3.Start();

                return;
            }
            btn[counter].Text = Convert.ToString(CreateTable(key)[counter]);
            counter++;
            timer.Enabled = true;
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            label4.Text = "Decryption Text Process...";
            if (i >= CreatePlainText().Count)
            {
                timer3.Stop();
                timer3.Enabled = false;
                ResetButtonColor();
                MessageBox.Show("Decryption Finished!", "Playfair");
                label4.Text = "Decryption Finished!";
                return;
            }


            Button[] btn = {button1,button2,button3,button4,button5,
            button6,button7,button8,button9,button10,
            button11,button12,button13,button14,button15,
            button16,button17,button18,button19,button20,
            button21,button22,button23,button24,button25,};

            ResetButtonColor();
            char Ch1 = CreatePlainText()[i]; //kí tự đầu
            char Ch2 = CreatePlainText()[i + 1];//kí tự thứ 2
            int[] btnIndex = new int[2];
            for (int j = 0; j < btn.Length; j++)
            {
                if (btn[j].Text == Convert.ToString(Ch1))
                {
                    btnIndex[0] = j;
                }
                if (btn[j].Text == Convert.ToString(Ch2))
                {
                    btnIndex[1] = j;
                }
            }
            btn[btnIndex[0]].BackColor = Color.Red;
            btn[btnIndex[1]].BackColor = Color.Red;

            int row1 = 0, row2 = -1, col1 = 0, col2 = -1;

            for (int j = 0; j < width * hight; j++)
            {

                if (tempList[j / width, j % hight] == Ch1) // lấy chỉ số hàng char đầu tiên và chỉ số cột
                {
                    row1 = j / width;
                    col1 = j % hight;
                }
                if (tempList[j / width, j % hight] == Ch2) // lấy chỉ số hàng char thứ hai và chỉ số cột
                {
                    row2 = j / width;
                    col2 = j % hight;
                }
            }



            int n = width;
            //kiểm tra xem ký tự đầu tiên và ký tự thứ hai có cùng hàng không
            //        if (row1 == row2)
            //        {
            //            if (btn[btnIndex[0]].Text == btn[(row1 * n) + (col1 + 1) % hight].Text ||
            //                btn[btnIndex[1]].Text == btn[(row1 * n) + (col1 + 1) % hight].Text
            //                )
            //            {
            //                btn[(row1 * n) + (col1 + 1) % hight].BackColor = Color.Yellow;
            //            }
            //            else
            //                btn[(row1 * n) + (col1 + 1) % hight].BackColor = Color.Blue;

            //            if (btn[btnIndex[0]].Text == btn[(row2 * n) + (col2 + 1) % hight].Text ||
            //btn[btnIndex[1]].Text == btn[(row2 * n) + (col2 + 1) % hight].Text
            //)
            //            {
            //                btn[(row1 * n) + (col1 + 1) % hight].BackColor = Color.Yellow;
            //            }
            //            else
            //                btn[(row2 * n) + (col2 + 1) % hight].BackColor = Color.Blue;
            //            text += (tempList[row1, (col1 + 1) % hight] + "" + tempList[row2, (col2 + 1) % hight]);
            //        }
            //        //kiểm tra xem ký tự đầu tiên và ký tự thứ hai có nằm trên cùng một cột không
            //        else if (col1 == col2)
            //        {
            //            if (btn[btnIndex[0]].Text == btn[(((row2 + 1) % hight) * n) + col2].Text ||
            //btn[btnIndex[1]].Text == btn[(((row2 + 1) % hight) * n) + col2].Text
            //)
            //            {
            //                btn[(((row2 + 1) % hight) * n) + col2].BackColor = Color.Yellow;
            //            }
            //            else
            //                btn[(((row2 + 1) % hight) * n) + col2].BackColor = Color.Blue;

            //            if (btn[btnIndex[0]].Text == btn[(((row2 + 1) % hight) * n) + col1].Text ||
            //btn[btnIndex[1]].Text == btn[(((row2 + 1) % hight) * n) + col1].Text
            //)
            //            {
            //                btn[(((row2 + 1) % hight) * n) + col1].BackColor = Color.Yellow;
            //            }
            //            else
            //                btn[(((row2 + 1) % hight) * n) + col1].BackColor = Color.Blue;



            //            text += (tempList[(row1 + 1) % hight, col1] + "" + tempList[(row2 + 1) % hight, col2]);
            //        }
            //        else
            //        {
            //            btn[(row1 * n) + col2].BackColor = Color.Blue;
            //            btn[(row2 * n) + col1].BackColor = Color.Blue;
            //            text += (tempList[row1, col2] + "" + tempList[row2, col1]);
            //            //  Console.Write(tempList[row2, col1] + "" + tempList[row1, col2]); //another slove

            //        }

            if (row1 == row2) // Cùng hàng
            {
                text += tempList[row1, (col1 - 1 + hight) % hight].ToString() +
                        tempList[row2, (col2 - 1 + hight) % hight].ToString();

                if (btn[btnIndex[0]].Text == btn[(row1 * hight) + (col1 - 1 + hight) % hight].Text ||
                    btn[btnIndex[1]].Text == btn[(row1 * hight) + (col1 - 1 + hight) % hight].Text)
                {
                    btn[(row1 * hight) + (col1 - 1 + hight) % hight].BackColor = Color.Yellow;
                }
                else
                {
                    btn[(row1 * hight) + (col1 - 1 + hight) % hight].BackColor = Color.Blue;
                }

                if (btn[btnIndex[0]].Text == btn[(row2 * hight) + (col2 - 1 + hight) % hight].Text ||
                    btn[btnIndex[1]].Text == btn[(row2 * hight) + (col2 - 1 + hight) % hight].Text)
                {
                    btn[(row2 * hight) + (col2 - 1 + hight) % hight].BackColor = Color.Yellow;
                }
                else
                {
                    btn[(row2 * hight) + (col2 - 1 + hight) % hight].BackColor = Color.Blue;
                }
            }
            else if (col1 == col2) // Cùng cột
            {
                text += tempList[(row1 - 1 + hight) % hight, col1].ToString() +
                        tempList[(row2 - 1 + hight) % hight, col2].ToString();

                if (btn[btnIndex[0]].Text == btn[((row1 - 1 + hight) % hight * hight) + col1].Text ||
                    btn[btnIndex[1]].Text == btn[((row1 - 1 + hight) % hight * hight) + col1].Text)
                {
                    btn[((row1 - 1 + hight) % hight * hight) + col1].BackColor = Color.Yellow;
                }
                else
                {
                    btn[((row1 - 1 + hight) % hight * hight) + col1].BackColor = Color.Blue;
                }

                if (btn[btnIndex[0]].Text == btn[((row2 - 1 + hight) % hight * hight) + col2].Text ||
                    btn[btnIndex[1]].Text == btn[((row2 - 1 + hight) % hight * hight) + col2].Text)
                {
                    btn[((row2 - 1 + hight) % hight * hight) + col2].BackColor = Color.Yellow;
                }
                else
                {
                    btn[((row2 - 1 + hight) % hight * hight) + col2].BackColor = Color.Blue;
                }
            }
            else // Khác hàng và cột
            {
                text += tempList[row1, col2].ToString() + tempList[row2, col1].ToString();

                btn[(row1 * hight) + col2].BackColor = Color.Blue;
                btn[(row2 * hight) + col1].BackColor = Color.Blue;
            }

            outputContent.Text = text;
            plainxLable.Text += Ch1 + "" + Ch2;
            i += 2;
            timer3.Enabled = true;

        }


    }
}
