namespace RSA
{
    partial class Menu
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
            this.PlayFairForm = new System.Windows.Forms.Button();
            this.RSAForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayFairForm
            // 
            this.PlayFairForm.Location = new System.Drawing.Point(51, 143);
            this.PlayFairForm.Name = "PlayFairForm";
            this.PlayFairForm.Size = new System.Drawing.Size(195, 86);
            this.PlayFairForm.TabIndex = 0;
            this.PlayFairForm.Text = "PlayFair";
            this.PlayFairForm.UseVisualStyleBackColor = true;
            this.PlayFairForm.Click += new System.EventHandler(this.PlayFairForm_Click);
            // 
            // RSAForm
            // 
            this.RSAForm.BackColor = System.Drawing.Color.White;
            this.RSAForm.Location = new System.Drawing.Point(51, 28);
            this.RSAForm.Name = "RSAForm";
            this.RSAForm.Size = new System.Drawing.Size(195, 78);
            this.RSAForm.TabIndex = 1;
            this.RSAForm.Text = "RSA";
            this.RSAForm.UseVisualStyleBackColor = false;
            this.RSAForm.Click += new System.EventHandler(this.RSAForm_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 263);
            this.Controls.Add(this.RSAForm);
            this.Controls.Add(this.PlayFairForm);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayFairForm;
        private System.Windows.Forms.Button RSAForm;
    }
}

