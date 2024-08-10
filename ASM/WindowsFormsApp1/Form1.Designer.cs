namespace WindowsFormsApp1
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
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartmentid = new System.Windows.Forms.Label();
            this.lblchoosedepartment = new System.Windows.Forms.Label();
            this.lblyearofbirth = new System.Windows.Forms.Label();
            this.lblhometown = new System.Windows.Forms.Label();
            this.rtb_studentname = new System.Windows.Forms.RichTextBox();
            this.rtb_studentID = new System.Windows.Forms.RichTextBox();
            this.rtb_departmentID = new System.Windows.Forms.RichTextBox();
            this.rtb_yearofbirth = new System.Windows.Forms.RichTextBox();
            this.rtb_hometown = new System.Windows.Forms.RichTextBox();
            this.cb_choosedepartment = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentname.Location = new System.Drawing.Point(8, 85);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(98, 15);
            this.lblstudentname.TabIndex = 0;
            this.lblstudentname.Text = "Student Name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(23, 204);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(74, 15);
            this.lblstudentid.TabIndex = 1;
            this.lblstudentid.Text = "Student ID";
            // 
            // lbldepartmentid
            // 
            this.lbldepartmentid.AutoSize = true;
            this.lbldepartmentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldepartmentid.Location = new System.Drawing.Point(6, 307);
            this.lbldepartmentid.Name = "lbldepartmentid";
            this.lbldepartmentid.Size = new System.Drawing.Size(100, 15);
            this.lbldepartmentid.TabIndex = 2;
            this.lbldepartmentid.Text = "Department ID";
            // 
            // lblchoosedepartment
            // 
            this.lblchoosedepartment.AutoSize = true;
            this.lblchoosedepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoosedepartment.Location = new System.Drawing.Point(6, 378);
            this.lblchoosedepartment.Name = "lblchoosedepartment";
            this.lblchoosedepartment.Size = new System.Drawing.Size(134, 15);
            this.lblchoosedepartment.TabIndex = 3;
            this.lblchoosedepartment.Text = "Choose Department";
            // 
            // lblyearofbirth
            // 
            this.lblyearofbirth.AutoSize = true;
            this.lblyearofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyearofbirth.Location = new System.Drawing.Point(396, 98);
            this.lblyearofbirth.Name = "lblyearofbirth";
            this.lblyearofbirth.Size = new System.Drawing.Size(85, 15);
            this.lblyearofbirth.TabIndex = 4;
            this.lblyearofbirth.Text = "Year of birth";
            // 
            // lblhometown
            // 
            this.lblhometown.AutoSize = true;
            this.lblhometown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhometown.Location = new System.Drawing.Point(395, 233);
            this.lblhometown.Name = "lblhometown";
            this.lblhometown.Size = new System.Drawing.Size(83, 15);
            this.lblhometown.TabIndex = 5;
            this.lblhometown.Text = "Home Town";
            // 
            // rtb_studentname
            // 
            this.rtb_studentname.Location = new System.Drawing.Point(135, 50);
            this.rtb_studentname.Name = "rtb_studentname";
            this.rtb_studentname.Size = new System.Drawing.Size(220, 93);
            this.rtb_studentname.TabIndex = 6;
            this.rtb_studentname.Text = "";
            // 
            // rtb_studentID
            // 
            this.rtb_studentID.Location = new System.Drawing.Point(135, 164);
            this.rtb_studentID.Name = "rtb_studentID";
            this.rtb_studentID.Size = new System.Drawing.Size(220, 93);
            this.rtb_studentID.TabIndex = 7;
            this.rtb_studentID.Text = "";
            // 
            // rtb_departmentID
            // 
            this.rtb_departmentID.Location = new System.Drawing.Point(135, 279);
            this.rtb_departmentID.Name = "rtb_departmentID";
            this.rtb_departmentID.Size = new System.Drawing.Size(220, 93);
            this.rtb_departmentID.TabIndex = 8;
            this.rtb_departmentID.Text = "";
            // 
            // rtb_yearofbirth
            // 
            this.rtb_yearofbirth.Location = new System.Drawing.Point(488, 50);
            this.rtb_yearofbirth.Name = "rtb_yearofbirth";
            this.rtb_yearofbirth.Size = new System.Drawing.Size(220, 93);
            this.rtb_yearofbirth.TabIndex = 9;
            this.rtb_yearofbirth.Text = "";
            // 
            // rtb_hometown
            // 
            this.rtb_hometown.Location = new System.Drawing.Point(488, 181);
            this.rtb_hometown.Name = "rtb_hometown";
            this.rtb_hometown.Size = new System.Drawing.Size(220, 93);
            this.rtb_hometown.TabIndex = 10;
            this.rtb_hometown.Text = "";
            // 
            // cb_choosedepartment
            // 
            this.cb_choosedepartment.FormattingEnabled = true;
            this.cb_choosedepartment.Location = new System.Drawing.Point(146, 378);
            this.cb_choosedepartment.Name = "cb_choosedepartment";
            this.cb_choosedepartment.Size = new System.Drawing.Size(199, 21);
            this.cb_choosedepartment.TabIndex = 11;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(676, 406);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 41);
            this.btn_save.TabIndex = 12;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.cb_choosedepartment);
            this.Controls.Add(this.rtb_hometown);
            this.Controls.Add(this.rtb_yearofbirth);
            this.Controls.Add(this.rtb_departmentID);
            this.Controls.Add(this.rtb_studentID);
            this.Controls.Add(this.rtb_studentname);
            this.Controls.Add(this.lblhometown);
            this.Controls.Add(this.lblyearofbirth);
            this.Controls.Add(this.lblchoosedepartment);
            this.Controls.Add(this.lbldepartmentid);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblstudentname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartmentid;
        private System.Windows.Forms.Label lblchoosedepartment;
        private System.Windows.Forms.Label lblyearofbirth;
        private System.Windows.Forms.Label lblhometown;
        private System.Windows.Forms.RichTextBox rtb_studentname;
        private System.Windows.Forms.RichTextBox rtb_studentID;
        private System.Windows.Forms.RichTextBox rtb_departmentID;
        private System.Windows.Forms.RichTextBox rtb_yearofbirth;
        private System.Windows.Forms.RichTextBox rtb_hometown;
        private System.Windows.Forms.ComboBox cb_choosedepartment;
        private System.Windows.Forms.Button btn_save;
    }
}