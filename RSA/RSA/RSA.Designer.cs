namespace RSA
{
    partial class RSA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSA));
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.labelP = new System.Windows.Forms.Label();
            this.labelQ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateKeys = new System.Windows.Forms.Button();
            this.btnRandomKeys = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.BackMenu = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.DarkRed;
            label3.Location = new System.Drawing.Point(23, 301);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 25);
            label3.TabIndex = 18;
            label3.Text = "Input";
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(188, 127);
            this.txtP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(112, 30);
            this.txtP.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(438, 330);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(434, 176);
            this.txtOutput.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(17, 330);
            this.txtInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(401, 176);
            this.txtInput.TabIndex = 4;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivateKey.Location = new System.Drawing.Point(632, 228);
            this.txtPrivateKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(175, 48);
            this.txtPrivateKey.TabIndex = 5;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublicKey.Location = new System.Drawing.Point(632, 109);
            this.txtPublicKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(170, 48);
            this.txtPublicKey.TabIndex = 6;
            // 
            // txtE
            // 
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(188, 234);
            this.txtE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(112, 30);
            this.txtE.TabIndex = 7;
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.Location = new System.Drawing.Point(188, 182);
            this.txtQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(112, 30);
            this.txtQ.TabIndex = 8;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.BackColor = System.Drawing.Color.Transparent;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelP.ForeColor = System.Drawing.Color.Maroon;
            this.labelP.Location = new System.Drawing.Point(137, 132);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(23, 25);
            this.labelP.TabIndex = 9;
            this.labelP.Text = "p";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.BackColor = System.Drawing.Color.Transparent;
            this.labelQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQ.ForeColor = System.Drawing.Color.Maroon;
            this.labelQ.Location = new System.Drawing.Point(137, 185);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(23, 25);
            this.labelQ.TabIndex = 10;
            this.labelQ.Text = "q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(629, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "public key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(630, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "private key";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.BackColor = System.Drawing.Color.Salmon;
            this.btnGenerateKeys.CausesValidation = false;
            this.btnGenerateKeys.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnGenerateKeys.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnGenerateKeys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnGenerateKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateKeys.Location = new System.Drawing.Point(444, 109);
            this.btnGenerateKeys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(149, 48);
            this.btnGenerateKeys.TabIndex = 14;
            this.btnGenerateKeys.Text = "GenerateKeys";
            this.btnGenerateKeys.UseVisualStyleBackColor = false;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnRandomKeys
            // 
            this.btnRandomKeys.BackColor = System.Drawing.Color.LightCoral;
            this.btnRandomKeys.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRandomKeys.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btnRandomKeys.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRandomKeys.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomKeys.Location = new System.Drawing.Point(444, 228);
            this.btnRandomKeys.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRandomKeys.Name = "btnRandomKeys";
            this.btnRandomKeys.Size = new System.Drawing.Size(157, 48);
            this.btnRandomKeys.TabIndex = 15;
            this.btnRandomKeys.Text = "RandomKeys";
            this.btnRandomKeys.UseVisualStyleBackColor = false;
            this.btnRandomKeys.Click += new System.EventHandler(this.btnRandomKeys_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnEncode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEncode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnEncode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnEncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.ForeColor = System.Drawing.Color.White;
            this.btnEncode.Location = new System.Drawing.Point(266, 579);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(152, 75);
            this.btnEncode.TabIndex = 16;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = false;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.BackColor = System.Drawing.Color.Coral;
            this.btnDecode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDecode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btnDecode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.ForeColor = System.Drawing.Color.White;
            this.btnDecode.Location = new System.Drawing.Point(442, 579);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(155, 75);
            this.btnDecode.TabIndex = 17;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(437, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Output";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.BackColor = System.Drawing.Color.Transparent;
            this.labelE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.ForeColor = System.Drawing.Color.Maroon;
            this.labelE.Location = new System.Drawing.Point(137, 240);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(23, 25);
            this.labelE.TabIndex = 20;
            this.labelE.Text = "e";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnUpload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(17, 525);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(141, 48);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.Location = new System.Drawing.Point(742, 525);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(130, 48);
            this.btnDownload.TabIndex = 22;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(351, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 55);
            this.label5.TabIndex = 23;
            this.label5.Text = "RSA";
            // 
            // BackMenu
            // 
            this.BackMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackMenu.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackMenu.ForeColor = System.Drawing.Color.Black;
            this.BackMenu.Location = new System.Drawing.Point(17, 18);
            this.BackMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(140, 71);
            this.BackMenu.TabIndex = 24;
            this.BackMenu.Text = "Back";
            this.BackMenu.UseVisualStyleBackColor = false;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 692);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.btnRandomKeys);
            this.Controls.Add(this.btnGenerateKeys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelQ);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtP);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RSA";
            this.Text = "RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label labelQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateKeys;
        private System.Windows.Forms.Button btnRandomKeys;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BackMenu;
    }
}