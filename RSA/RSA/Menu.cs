using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace RSA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void RSAForm_Click(object sender, EventArgs e)
        {
            RSA RSA = new RSA();
            RSA.Show();
            this.Hide();
        }

        private void PlayFairForm_Click(object sender, EventArgs e)
        {
            PlayFair playFair = new PlayFair();
            playFair.Show();
            this.Hide();
        }
    }
}
