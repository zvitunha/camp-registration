namespace BYSD_Camp_Registration_System
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sexcombo = new System.Windows.Forms.ComboBox();
            this.surnametext = new System.Windows.Forms.TextBox();
            this.nametext = new System.Windows.Forms.TextBox();
            this.churchtext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.celltext = new System.Windows.Forms.TextBox();
            this.categorycombo = new System.Windows.Forms.ComboBox();
            this.roomcombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.citytext = new System.Windows.Forms.ComboBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, -10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 178);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // sexcombo
            // 
            this.sexcombo.FormattingEnabled = true;
            this.sexcombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sexcombo.Location = new System.Drawing.Point(264, 273);
            this.sexcombo.Margin = new System.Windows.Forms.Padding(4);
            this.sexcombo.Name = "sexcombo";
            this.sexcombo.Size = new System.Drawing.Size(160, 24);
            this.sexcombo.TabIndex = 3;
            this.sexcombo.Text = "Choose sex";
            // 
            // surnametext
            // 
            this.surnametext.Location = new System.Drawing.Point(264, 241);
            this.surnametext.Margin = new System.Windows.Forms.Padding(4);
            this.surnametext.Name = "surnametext";
            this.surnametext.Size = new System.Drawing.Size(160, 22);
            this.surnametext.TabIndex = 4;
            // 
            // nametext
            // 
            this.nametext.Location = new System.Drawing.Point(264, 209);
            this.nametext.Margin = new System.Windows.Forms.Padding(4);
            this.nametext.Name = "nametext";
            this.nametext.Size = new System.Drawing.Size(160, 22);
            this.nametext.TabIndex = 5;
            // 
            // churchtext
            // 
            this.churchtext.Location = new System.Drawing.Point(264, 308);
            this.churchtext.Margin = new System.Windows.Forms.Padding(4);
            this.churchtext.Name = "churchtext";
            this.churchtext.Size = new System.Drawing.Size(75, 22);
            this.churchtext.TabIndex = 6;
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(264, 439);
            this.emailtext.Margin = new System.Windows.Forms.Padding(4);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(160, 22);
            this.emailtext.TabIndex = 8;
            // 
            // celltext
            // 
            this.celltext.Location = new System.Drawing.Point(264, 407);
            this.celltext.Margin = new System.Windows.Forms.Padding(4);
            this.celltext.Name = "celltext";
            this.celltext.Size = new System.Drawing.Size(160, 22);
            this.celltext.TabIndex = 9;
            // 
            // categorycombo
            // 
            this.categorycombo.FormattingEnabled = true;
            this.categorycombo.Items.AddRange(new object[] {
            "BYSD member",
            "EC member",
            "Advisor",
            "Speaker",
            "Visitor(ex BYSD member)",
            "Visitor(from other organisations)"});
            this.categorycombo.Location = new System.Drawing.Point(264, 374);
            this.categorycombo.Margin = new System.Windows.Forms.Padding(4);
            this.categorycombo.Name = "categorycombo";
            this.categorycombo.Size = new System.Drawing.Size(160, 24);
            this.categorycombo.TabIndex = 10;
            this.categorycombo.Text = "Choose Category";
            // 
            // roomcombo
            // 
            this.roomcombo.FormattingEnabled = true;
            this.roomcombo.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B",
            "3A",
            "3B",
            "4A",
            "4B",
            "5A",
            "5B",
            "6A",
            "6B",
            "7A",
            "7B",
            "8A",
            "8B",
            "9A",
            "9B",
            "10A",
            "10B",
            "101A",
            "101B",
            "202A",
            "202B",
            "303A",
            "303B",
            "404A",
            "404C",
            "505A",
            "505B",
            "Dotson Nyati Hall",
            "Guest House"});
            this.roomcombo.Location = new System.Drawing.Point(264, 473);
            this.roomcombo.Margin = new System.Windows.Forms.Padding(4);
            this.roomcombo.Name = "roomcombo";
            this.roomcombo.Size = new System.Drawing.Size(160, 24);
            this.roomcombo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 212);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 310);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Church";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(126, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Association";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(130, 378);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 410);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cell";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(126, 443);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(126, 476);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Room";
            // 
            // citytext
            // 
            this.citytext.FormattingEnabled = true;
            this.citytext.Items.AddRange(new object[] {
            "Beitbridge",
            "Bulawayo-Plumtree",
            "Chinhoyi",
            "Chiredzi",
            "Gokwe",
            "Gweru",
            "Harare",
            "Hwange",
            "Kadoma-Chegutu",
            "Kariba",
            "Karoi",
            "Kwekwe-Redcliff",
            "Masvingo",
            "Mutare",
            "Sanyati",
            "Victoria Falls",
            "Zvishavane"});
            this.citytext.Location = new System.Drawing.Point(264, 343);
            this.citytext.Name = "citytext";
            this.citytext.Size = new System.Drawing.Size(160, 24);
            this.citytext.TabIndex = 21;
            this.citytext.Text = "Association";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(334, 526);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(90, 23);
            this.btncancel.TabIndex = 22;
            this.btncancel.Text = "Main Menu";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(245, 526);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(346, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Baptist Church";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 561);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.citytext);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roomcombo);
            this.Controls.Add(this.categorycombo);
            this.Controls.Add(this.celltext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.churchtext);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.surnametext);
            this.Controls.Add(this.sexcombo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registration";
            this.Text = "Registration";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox sexcombo;
        private System.Windows.Forms.TextBox surnametext;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.TextBox churchtext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox celltext;
        private System.Windows.Forms.ComboBox categorycombo;
        private System.Windows.Forms.ComboBox roomcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox citytext;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label10;
    }
}