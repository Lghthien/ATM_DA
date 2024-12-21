namespace RSA
{
    partial class PlayFair
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
            this.BackMenubtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackMenubtn
            // 
            this.BackMenubtn.Location = new System.Drawing.Point(0, 0);
            this.BackMenubtn.Name = "BackMenubtn";
            this.BackMenubtn.Size = new System.Drawing.Size(124, 57);
            this.BackMenubtn.TabIndex = 0;
            this.BackMenubtn.Text = "Back";
            this.BackMenubtn.UseVisualStyleBackColor = true;
            this.BackMenubtn.Click += new System.EventHandler(this.BackMenubtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(322, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "PlayFair";
            // 
            // PlayFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackMenubtn);
            this.Name = "PlayFair";
            this.Text = "PlayFair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMenubtn;
        private System.Windows.Forms.Label label1;
    }
}