namespace SMS
{
    partial class Student
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.Close_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Student_id_tbx = new System.Windows.Forms.TextBox();
            this.StudentName_tbx = new System.Windows.Forms.TextBox();
            this.Add_tbx = new System.Windows.Forms.TextBox();
            this.FatherName_tbx = new System.Windows.Forms.TextBox();
            this.Voter_tbx = new System.Windows.Forms.TextBox();
            this.Phone_tbx = new System.Windows.Forms.TextBox();
            this.Roll_tbx = new System.Windows.Forms.TextBox();
            this.Class_tbx = new System.Windows.Forms.TextBox();
            this.Sec_tbx = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Library_tbx = new System.Windows.Forms.TextBox();
            this.Bus_tbx = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Photo_pb = new System.Windows.Forms.PictureBox();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Browse_btn = new System.Windows.Forms.Button();
            this.OFD_controler = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Photo_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_btn
            // 
            this.Close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Close_btn.BackColor = System.Drawing.Color.Transparent;
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.Close_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(192, 57, 43);
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Close_btn.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Close_btn.Location = new System.Drawing.Point(935, 5);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(45, 45);
            this.Close_btn.TabIndex = 0;
            this.Close_btn.Text = "✕";
            this.Close_btn.UseVisualStyleBackColor = false;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            this.Close_btn.MouseEnter += new System.EventHandler(this.Close_btn_MouseEnter);
            this.Close_btn.MouseLeave += new System.EventHandler(this.Close_btn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label1.Location = new System.Drawing.Point(45, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label2.Location = new System.Drawing.Point(45, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label3.Location = new System.Drawing.Point(45, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label4.Location = new System.Drawing.Point(45, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Father's Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label5.Location = new System.Drawing.Point(530, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Roll No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label6.Location = new System.Drawing.Point(530, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label7.Location = new System.Drawing.Point(45, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Voter ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label8.Location = new System.Drawing.Point(45, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Phone No.";
            // 
            // Student_id_tbx
            // 
            this.Student_id_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Student_id_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Student_id_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Student_id_tbx.Location = new System.Drawing.Point(49, 132);
            this.Student_id_tbx.Name = "Student_id_tbx";
            this.Student_id_tbx.Size = new System.Drawing.Size(380, 25);
            this.Student_id_tbx.TabIndex = 1;
            // 
            // StudentName_tbx
            // 
            this.StudentName_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StudentName_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StudentName_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.StudentName_tbx.Location = new System.Drawing.Point(49, 192);
            this.StudentName_tbx.Name = "StudentName_tbx";
            this.StudentName_tbx.Size = new System.Drawing.Size(380, 25);
            this.StudentName_tbx.TabIndex = 2;
            // 
            // Add_tbx
            // 
            this.Add_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Add_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Add_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Add_tbx.Location = new System.Drawing.Point(49, 312);
            this.Add_tbx.Name = "Add_tbx";
            this.Add_tbx.Size = new System.Drawing.Size(380, 25);
            this.Add_tbx.TabIndex = 6;
            // 
            // FatherName_tbx
            // 
            this.FatherName_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FatherName_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FatherName_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.FatherName_tbx.Location = new System.Drawing.Point(49, 252);
            this.FatherName_tbx.Name = "FatherName_tbx";
            this.FatherName_tbx.Size = new System.Drawing.Size(380, 25);
            this.FatherName_tbx.TabIndex = 3;
            // 
            // Voter_tbx
            // 
            this.Voter_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Voter_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Voter_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Voter_tbx.Location = new System.Drawing.Point(49, 432);
            this.Voter_tbx.Name = "Voter_tbx";
            this.Voter_tbx.Size = new System.Drawing.Size(380, 25);
            this.Voter_tbx.TabIndex = 5;
            // 
            // Phone_tbx
            // 
            this.Phone_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Phone_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Phone_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Phone_tbx.Location = new System.Drawing.Point(49, 372);
            this.Phone_tbx.Name = "Phone_tbx";
            this.Phone_tbx.Size = new System.Drawing.Size(380, 25);
            this.Phone_tbx.TabIndex = 4;
            // 
            // Roll_tbx
            // 
            this.Roll_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Roll_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Roll_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Roll_tbx.Location = new System.Drawing.Point(530, 372);
            this.Roll_tbx.Name = "Roll_tbx";
            this.Roll_tbx.Size = new System.Drawing.Size(180, 25);
            this.Roll_tbx.TabIndex = 8;
            // 
            // Class_tbx
            // 
            this.Class_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Class_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Class_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Class_tbx.Location = new System.Drawing.Point(530, 252);
            this.Class_tbx.Name = "Class_tbx";
            this.Class_tbx.Size = new System.Drawing.Size(180, 25);
            this.Class_tbx.TabIndex = 7;
            // 
            // Sec_tbx
            // 
            this.Sec_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sec_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Sec_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Sec_tbx.Location = new System.Drawing.Point(530, 132);
            this.Sec_tbx.Name = "Sec_tbx";
            this.Sec_tbx.Size = new System.Drawing.Size(180, 25);
            this.Sec_tbx.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label9.Location = new System.Drawing.Point(526, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Bus";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label10.Location = new System.Drawing.Point(526, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "Library Card";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label11.Location = new System.Drawing.Point(526, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "Section";
            // 
            // Library_tbx
            // 
            this.Library_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Library_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Library_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Library_tbx.Location = new System.Drawing.Point(530, 192);
            this.Library_tbx.Name = "Library_tbx";
            this.Library_tbx.Size = new System.Drawing.Size(180, 25);
            this.Library_tbx.TabIndex = 10;
            // 
            // Bus_tbx
            // 
            this.Bus_tbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Bus_tbx.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Bus_tbx.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            this.Bus_tbx.Location = new System.Drawing.Point(530, 312);
            this.Bus_tbx.Name = "Bus_tbx";
            this.Bus_tbx.Size = new System.Drawing.Size(180, 25);
            this.Bus_tbx.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.label12.Location = new System.Drawing.Point(200, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(588, 45);
            this.label12.TabIndex = 13;
            this.label12.Text = "ADMIT STUDENT";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(189, 195, 199);
            this.panel1.Location = new System.Drawing.Point(30, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 2);
            this.panel1.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(44, 62, 80);
            this.label13.Location = new System.Drawing.Point(748, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 19);
            this.label13.TabIndex = 15;
            this.label13.Text = "Student Photo";
            // 
            // Photo_pb
            // 
            this.Photo_pb.BackColor = System.Drawing.Color.White;
            this.Photo_pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Photo_pb.Location = new System.Drawing.Point(752, 132);
            this.Photo_pb.Name = "Photo_pb";
            this.Photo_pb.Size = new System.Drawing.Size(200, 240);
            this.Photo_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Photo_pb.TabIndex = 16;
            this.Photo_pb.TabStop = false;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            this.Save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_btn.FlatAppearance.BorderSize = 0;
            this.Save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(30, 130, 76);
            this.Save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.Save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save_btn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(752, 445);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(200, 42);
            this.Save_btn.TabIndex = 13;
            this.Save_btn.Text = "SAVE STUDENT";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Browse_btn
            // 
            this.Browse_btn.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.Browse_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Browse_btn.FlatAppearance.BorderSize = 0;
            this.Browse_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            this.Browse_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(65, 176, 240);
            this.Browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Browse_btn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular);
            this.Browse_btn.ForeColor = System.Drawing.Color.White;
            this.Browse_btn.Location = new System.Drawing.Point(752, 378);
            this.Browse_btn.Name = "Browse_btn";
            this.Browse_btn.Size = new System.Drawing.Size(200, 32);
            this.Browse_btn.TabIndex = 12;
            this.Browse_btn.Text = "Choose Photo";
            this.Browse_btn.UseVisualStyleBackColor = false;
            this.Browse_btn.Click += new System.EventHandler(this.Browse_btn_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(988, 544);
            this.Controls.Add(this.Browse_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.Photo_pb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Bus_tbx);
            this.Controls.Add(this.Library_tbx);
            this.Controls.Add(this.Sec_tbx);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Roll_tbx);
            this.Controls.Add(this.Class_tbx);
            this.Controls.Add(this.Voter_tbx);
            this.Controls.Add(this.Phone_tbx);
            this.Controls.Add(this.Add_tbx);
            this.Controls.Add(this.FatherName_tbx);
            this.Controls.Add(this.StudentName_tbx);
            this.Controls.Add(this.Student_id_tbx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student";
            this.Opacity = 0.98D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Student_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Student_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Photo_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Student_id_tbx;
        private System.Windows.Forms.TextBox StudentName_tbx;
        private System.Windows.Forms.TextBox Add_tbx;
        private System.Windows.Forms.TextBox FatherName_tbx;
        private System.Windows.Forms.TextBox Voter_tbx;
        private System.Windows.Forms.TextBox Phone_tbx;
        private System.Windows.Forms.TextBox Roll_tbx;
        private System.Windows.Forms.TextBox Class_tbx;
        private System.Windows.Forms.TextBox Sec_tbx;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Library_tbx;
        private System.Windows.Forms.TextBox Bus_tbx;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox Photo_pb;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Browse_btn;
        private System.Windows.Forms.OpenFileDialog OFD_controler;
    }
}