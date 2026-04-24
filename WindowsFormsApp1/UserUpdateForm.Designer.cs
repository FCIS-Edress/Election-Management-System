namespace WindowsFormsApp1
{
    partial class UserUpdateForm
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
            this.cpass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.em = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpass
            // 
            this.cpass.Location = new System.Drawing.Point(795, 560);
            this.cpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpass.MaxLength = 24;
            this.cpass.Name = "cpass";
            this.cpass.Size = new System.Drawing.Size(267, 22);
            this.cpass.TabIndex = 70;
            this.cpass.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(357, 537);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(361, 48);
            this.label11.TabIndex = 69;
            this.label11.Text = "Confirm Password";
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(795, 475);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.MaxLength = 24;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(267, 22);
            this.pass.TabIndex = 68;
            this.pass.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(359, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 48);
            this.label9.TabIndex = 67;
            this.label9.Text = "Password";
            // 
            // em
            // 
            this.em.Location = new System.Drawing.Point(795, 403);
            this.em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.em.MaxLength = 24;
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(267, 22);
            this.em.TabIndex = 66;
            this.em.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(359, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 48);
            this.label8.TabIndex = 65;
            this.label8.Text = "Email";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 623);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 80);
            this.button2.TabIndex = 63;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(772, 623);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 80);
            this.button1.TabIndex = 62;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ct
            // 
            this.ct.Location = new System.Drawing.Point(795, 312);
            this.ct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ct.MaxLength = 24;
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(267, 22);
            this.ct.TabIndex = 61;
            this.ct.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(359, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 48);
            this.label7.TabIndex = 60;
            this.label7.Text = "City";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(795, 234);
            this.lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lname.MaxLength = 25;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(267, 22);
            this.lname.TabIndex = 57;
            this.lname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 48);
            this.label3.TabIndex = 53;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 48);
            this.label2.TabIndex = 52;
            this.label2.Text = "First Name";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(795, 160);
            this.fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fname.MaxLength = 25;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(267, 22);
            this.fname.TabIndex = 51;
            this.fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 48);
            this.label1.TabIndex = 50;
            this.label1.Text = "Here you can Edit Your Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 844);
            this.Controls.Add(this.cpass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.em);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserUpdateForm";
            this.Text = "UserUpdateForm1";
            this.Load += new System.EventHandler(this.UserUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cpass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label1;
    }
}