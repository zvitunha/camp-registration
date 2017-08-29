namespace BYSD_Camp_Registration_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usertext = new System.Windows.Forms.TextBox();
            this.pwdtext = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 202);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usertext
            // 
            this.usertext.Location = new System.Drawing.Point(411, 54);
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(131, 20);
            this.usertext.TabIndex = 1;
            // 
            // pwdtext
            // 
            this.pwdtext.Location = new System.Drawing.Point(411, 95);
            this.pwdtext.Name = "pwdtext";
            this.pwdtext.PasswordChar = '*';
            this.pwdtext.Size = new System.Drawing.Size(131, 20);
            this.pwdtext.TabIndex = 2;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(311, 61);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(71, 16);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.Location = new System.Drawing.Point(311, 102);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(68, 16);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(485, 135);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(57, 23);
            this.btnexit.TabIndex = 5;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(411, 135);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(57, 23);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 286);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pwdtext);
            this.Controls.Add(this.usertext);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.TextBox pwdtext;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnlogin;

    }
}

