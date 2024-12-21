﻿namespace RSA
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
            label3.Location = new System.Drawing.Point(153, 217);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 16);
            label3.TabIndex = 18;
            label3.Text = "Input";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(83, 72);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(100, 22);
            this.txtP.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(389, 236);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(386, 164);
            this.txtOutput.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 236);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(357, 164);
            this.txtInput.TabIndex = 4;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(423, 158);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.Size = new System.Drawing.Size(156, 39);
            this.txtPrivateKey.TabIndex = 5;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(166, 158);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.Size = new System.Drawing.Size(152, 39);
            this.txtPublicKey.TabIndex = 6;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(563, 72);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(100, 22);
            this.txtE.TabIndex = 7;
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(318, 72);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(100, 22);
            this.txtQ.TabIndex = 8;
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(62, 72);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(15, 16);
            this.labelP.TabIndex = 9;
            this.labelP.Text = "p";
            // 
            // labelQ
            // 
            this.labelQ.AutoSize = true;
            this.labelQ.Location = new System.Drawing.Point(297, 72);
            this.labelQ.Name = "labelQ";
            this.labelQ.Size = new System.Drawing.Size(15, 16);
            this.labelQ.TabIndex = 10;
            this.labelQ.Text = "q";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "public key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "private key";
            // 
            // btnGenerateKeys
            // 
            this.btnGenerateKeys.CausesValidation = false;
            this.btnGenerateKeys.Location = new System.Drawing.Point(185, 106);
            this.btnGenerateKeys.Name = "btnGenerateKeys";
            this.btnGenerateKeys.Size = new System.Drawing.Size(109, 23);
            this.btnGenerateKeys.TabIndex = 14;
            this.btnGenerateKeys.Text = "GenerateKeys";
            this.btnGenerateKeys.UseVisualStyleBackColor = true;
            this.btnGenerateKeys.Click += new System.EventHandler(this.btnGenerateKeys_Click);
            // 
            // btnRandomKeys
            // 
            this.btnRandomKeys.Location = new System.Drawing.Point(448, 104);
            this.btnRandomKeys.Name = "btnRandomKeys";
            this.btnRandomKeys.Size = new System.Drawing.Size(109, 26);
            this.btnRandomKeys.TabIndex = 15;
            this.btnRandomKeys.Text = "RandomKeys";
            this.btnRandomKeys.UseVisualStyleBackColor = true;
            this.btnRandomKeys.Click += new System.EventHandler(this.btnRandomKeys_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(256, 435);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(116, 55);
            this.btnEncode.TabIndex = 16;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(389, 435);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(123, 55);
            this.btnDecode.TabIndex = 17;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Output";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Location = new System.Drawing.Point(542, 75);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(15, 16);
            this.labelE.TabIndex = 20;
            this.labelE.Text = "e";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(125, 406);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(125, 38);
            this.btnUpload.TabIndex = 21;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(547, 406);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(116, 38);
            this.btnDownload.TabIndex = 22;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(312, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 46);
            this.label5.TabIndex = 23;
            this.label5.Text = "RSA";
            // 
            // BackMenu
            // 
            this.BackMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackMenu.Location = new System.Drawing.Point(15, 14);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(112, 41);
            this.BackMenu.TabIndex = 24;
            this.BackMenu.Text = "Back";
            this.BackMenu.UseVisualStyleBackColor = true;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 501);
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