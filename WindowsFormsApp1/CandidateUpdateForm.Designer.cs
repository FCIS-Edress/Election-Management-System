namespace WindowsFormsApp1
{
    partial class CandidateUpdateForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.goa = new System.Windows.Forms.TextBox();
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
            this.cpass.Location = new System.Drawing.Point(570, 600);
            this.cpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cpass.MaxLength = 24;
            this.cpass.Name = "cpass";
            this.cpass.Size = new System.Drawing.Size(267, 22);
            this.cpass.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(142, 587);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(361, 48);
            this.label11.TabIndex = 69;
            this.label11.Text = "Confirm Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(871, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 48);
            this.label10.TabIndex = 68;
            this.label10.Text = "Your Goals";
            // 
            // goa
            // 
            this.goa.Location = new System.Drawing.Point(879, 227);
            this.goa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.goa.Multiline = true;
            this.goa.Name = "goa";
            this.goa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.goa.Size = new System.Drawing.Size(496, 86);
            this.goa.TabIndex = 67;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(570, 502);
            this.pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pass.MaxLength = 24;
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(267, 22);
            this.pass.TabIndex = 66;
            this.pass.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(142, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 48);
            this.label9.TabIndex = 65;
            this.label9.Text = "Password";
            // 
            // em
            // 
            this.em.Location = new System.Drawing.Point(570, 410);
            this.em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.em.MaxLength = 24;
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(267, 22);
            this.em.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(142, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 48);
            this.label8.TabIndex = 63;
            this.label8.Text = "Email";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(897, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 62);
            this.button2.TabIndex = 61;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1160, 390);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 62);
            this.button1.TabIndex = 60;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ct
            // 
            this.ct.Location = new System.Drawing.Point(570, 318);
            this.ct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ct.MaxLength = 24;
            this.ct.Name = "ct";
            this.ct.Size = new System.Drawing.Size(267, 22);
            this.ct.TabIndex = 59;
            this.ct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(142, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 48);
            this.label7.TabIndex = 58;
            this.label7.Text = "City";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(570, 227);
            this.lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lname.MaxLength = 25;
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(267, 22);
            this.lname.TabIndex = 55;
            this.lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 48);
            this.label3.TabIndex = 51;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 48);
            this.label2.TabIndex = 50;
            this.label2.Text = "First Name";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(570, 149);
            this.fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fname.MaxLength = 25;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(267, 22);
            this.fname.TabIndex = 49;
            this.fname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 48);
            this.label1.TabIndex = 48;
            this.label1.Text = "Here you can Edit Your Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CandidateUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 980);
            this.Controls.Add(this.cpass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.goa);
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
            this.Name = "CandidateUpdateForm";
            this.Text = "CandidateUpdateForm";
            this.Load += new System.EventHandler(this.CandidateUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cpass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox goa;
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