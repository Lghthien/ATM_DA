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
            this.PlayFairForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PlayFairForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayFairForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayFairForm.Location = new System.Drawing.Point(68, 179);
            this.PlayFairForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayFairForm.Name = "PlayFairForm";
            this.PlayFairForm.Size = new System.Drawing.Size(227, 112);
            this.PlayFairForm.TabIndex = 0;
            this.PlayFairForm.Text = "PlayFair";
            this.PlayFairForm.UseVisualStyleBackColor = false;
            this.PlayFairForm.Click += new System.EventHandler(this.PlayFairForm_Click);
            // 
            // RSAForm
            // 
            this.RSAForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RSAForm.FlatAppearance.BorderSize = 2;
            this.RSAForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RSAForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RSAForm.Location = new System.Drawing.Point(68, 35);
            this.RSAForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RSAForm.Name = "RSAForm";
            this.RSAForm.Size = new System.Drawing.Size(219, 98);
            this.RSAForm.TabIndex = 1;
            this.RSAForm.Text = "RSA";
            this.RSAForm.UseVisualStyleBackColor = false;
            this.RSAForm.Click += new System.EventHandler(this.RSAForm_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(372, 329);
            this.Controls.Add(this.RSAForm);
            this.Controls.Add(this.PlayFairForm);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PlayFairForm;
        private System.Windows.Forms.Button RSAForm;
    }
}

