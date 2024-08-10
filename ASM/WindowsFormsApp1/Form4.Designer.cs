namespace WindowsFormsApp1
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_departmentcode = new System.Windows.Forms.RichTextBox();
            this.rtb_departmentname = new System.Windows.Forms.RichTextBox();
            this.rtb_phonenumber = new System.Windows.Forms.RichTextBox();
            this.btn_filter = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Makhoa,
            this.Tenkhoa,
            this.Dienthoai});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // Makhoa
            // 
            this.Makhoa.HeaderText = "Makhoa";
            this.Makhoa.Name = "Makhoa";
            // 
            // Tenkhoa
            // 
            this.Tenkhoa.HeaderText = "Tenkhoa";
            this.Tenkhoa.Name = "Tenkhoa";
            // 
            // Dienthoai
            // 
            this.Dienthoai.HeaderText = "Dienthoai";
            this.Dienthoai.Name = "Dienthoai";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(73, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(344, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(592, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone number";
            // 
            // rtb_departmentcode
            // 
            this.rtb_departmentcode.Location = new System.Drawing.Point(0, 323);
            this.rtb_departmentcode.Name = "rtb_departmentcode";
            this.rtb_departmentcode.Size = new System.Drawing.Size(247, 59);
            this.rtb_departmentcode.TabIndex = 4;
            this.rtb_departmentcode.Text = "";
            // 
            // rtb_departmentname
            // 
            this.rtb_departmentname.Location = new System.Drawing.Point(269, 323);
            this.rtb_departmentname.Name = "rtb_departmentname";
            this.rtb_departmentname.Size = new System.Drawing.Size(247, 59);
            this.rtb_departmentname.TabIndex = 5;
            this.rtb_departmentname.Text = "";
            // 
            // rtb_phonenumber
            // 
            this.rtb_phonenumber.Location = new System.Drawing.Point(541, 323);
            this.rtb_phonenumber.Name = "rtb_phonenumber";
            this.rtb_phonenumber.Size = new System.Drawing.Size(247, 59);
            this.rtb_phonenumber.TabIndex = 6;
            this.rtb_phonenumber.Text = "";
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(106, 398);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(57, 50);
            this.btn_filter.TabIndex = 7;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(243, 398);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(57, 50);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(411, 398);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(57, 50);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(541, 398);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(57, 50);
            this.btn_refresh.TabIndex = 10;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.rtb_phonenumber);
            this.Controls.Add(this.rtb_departmentname);
            this.Controls.Add(this.rtb_departmentcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dienthoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_departmentcode;
        private System.Windows.Forms.RichTextBox rtb_departmentname;
        private System.Windows.Forms.RichTextBox rtb_phonenumber;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_refresh;
    }
}