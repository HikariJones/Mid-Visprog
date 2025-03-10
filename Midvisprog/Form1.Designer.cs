namespace Midvisprog
{
    partial class Form1
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
            System.Windows.Forms.Label label2;
            this.label1 = new System.Windows.Forms.Label();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(193, 264);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(53, 13);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(298, 184);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(165, 20);
            this.textUsername.TabIndex = 2;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(298, 257);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(165, 20);
            this.textPassword.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(577, 358);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(88, 38);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(188, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Silahkan Login Ke Akun Anda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label3;
    }
}

