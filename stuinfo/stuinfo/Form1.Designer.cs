namespace stuinfo
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
            this.txt_name = new System.Windows.Forms.Label();
            this.txt_rollNo = new System.Windows.Forms.Label();
            this.cmb_degree = new System.Windows.Forms.Label();
            this.cmb_semester = new System.Windows.Forms.Label();
            this.txt_cgpa = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtgpa = new System.Windows.Forms.TextBox();
            this.txtrollNo = new System.Windows.Forms.TextBox();
            this.cmbdegree = new System.Windows.Forms.ComboBox();
            this.cmbsemester = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txt_gpa = new System.Windows.Forms.Label();
            this.txtcgpa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(27, 47);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(73, 27);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "Name";
            // 
            // txt_rollNo
            // 
            this.txt_rollNo.AutoSize = true;
            this.txt_rollNo.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_rollNo.Location = new System.Drawing.Point(343, 47);
            this.txt_rollNo.Name = "txt_rollNo";
            this.txt_rollNo.Size = new System.Drawing.Size(77, 27);
            this.txt_rollNo.TabIndex = 2;
            this.txt_rollNo.Text = "Rollno";
            // 
            // cmb_degree
            // 
            this.cmb_degree.AutoSize = true;
            this.cmb_degree.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_degree.Location = new System.Drawing.Point(617, 46);
            this.cmb_degree.Name = "cmb_degree";
            this.cmb_degree.Size = new System.Drawing.Size(85, 27);
            this.cmb_degree.TabIndex = 4;
            this.cmb_degree.Text = "Degree";
            // 
            // cmb_semester
            // 
            this.cmb_semester.AutoSize = true;
            this.cmb_semester.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.cmb_semester.Location = new System.Drawing.Point(860, 48);
            this.cmb_semester.Name = "cmb_semester";
            this.cmb_semester.Size = new System.Drawing.Size(106, 27);
            this.cmb_semester.TabIndex = 5;
            this.cmb_semester.Text = "Semester";
            // 
            // txt_cgpa
            // 
            this.txt_cgpa.AutoSize = true;
            this.txt_cgpa.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_cgpa.Location = new System.Drawing.Point(1337, 48);
            this.txt_cgpa.Name = "txt_cgpa";
            this.txt_cgpa.Size = new System.Drawing.Size(68, 27);
            this.txt_cgpa.TabIndex = 6;
            this.txt_cgpa.Text = "CGPA";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(114, 49);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(215, 26);
            this.txtname.TabIndex = 7;
            // 
            // txtgpa
            // 
            this.txtgpa.Location = new System.Drawing.Point(1195, 49);
            this.txtgpa.Name = "txtgpa";
            this.txtgpa.Size = new System.Drawing.Size(133, 26);
            this.txtgpa.TabIndex = 9;
            // 
            // txtrollNo
            // 
            this.txtrollNo.Location = new System.Drawing.Point(430, 47);
            this.txtrollNo.Name = "txtrollNo";
            this.txtrollNo.Size = new System.Drawing.Size(180, 26);
            this.txtrollNo.TabIndex = 10;
            // 
            // cmbdegree
            // 
            this.cmbdegree.FormattingEnabled = true;
            this.cmbdegree.Items.AddRange(new object[] {
            "BS",
            "MS",
            "PHD"});
            this.cmbdegree.Location = new System.Drawing.Point(708, 47);
            this.cmbdegree.Name = "cmbdegree";
            this.cmbdegree.Size = new System.Drawing.Size(146, 28);
            this.cmbdegree.TabIndex = 11;
            // 
            // cmbsemester
            // 
            this.cmbsemester.FormattingEnabled = true;
            this.cmbsemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbsemester.Location = new System.Drawing.Point(973, 47);
            this.cmbsemester.Name = "cmbsemester";
            this.cmbsemester.Size = new System.Drawing.Size(146, 28);
            this.cmbsemester.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1539, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 211);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(1667, 230);
            this.dataGridView2.TabIndex = 14;
            // 
            // txt_gpa
            // 
            this.txt_gpa.AutoSize = true;
            this.txt_gpa.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.txt_gpa.Location = new System.Drawing.Point(1128, 49);
            this.txt_gpa.Name = "txt_gpa";
            this.txt_gpa.Size = new System.Drawing.Size(55, 27);
            this.txt_gpa.TabIndex = 3;
            this.txt_gpa.Text = "GPA";
            // 
            // txtcgpa
            // 
            this.txtcgpa.Location = new System.Drawing.Point(1418, 49);
            this.txtcgpa.Name = "txtcgpa";
            this.txtcgpa.Size = new System.Drawing.Size(100, 26);
            this.txtcgpa.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1764, 466);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbsemester);
            this.Controls.Add(this.cmbdegree);
            this.Controls.Add(this.txtrollNo);
            this.Controls.Add(this.txtgpa);
            this.Controls.Add(this.txtcgpa);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txt_cgpa);
            this.Controls.Add(this.cmb_semester);
            this.Controls.Add(this.cmb_degree);
            this.Controls.Add(this.txt_gpa);
            this.Controls.Add(this.txt_rollNo);
            this.Controls.Add(this.txt_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Label txt_rollNo;
        private System.Windows.Forms.Label cmb_degree;
        private System.Windows.Forms.Label cmb_semester;
        private System.Windows.Forms.Label txt_cgpa;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtgpa;
        private System.Windows.Forms.TextBox txtrollNo;
        private System.Windows.Forms.ComboBox cmbdegree;
        private System.Windows.Forms.ComboBox cmbsemester;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label txt_gpa;
        private System.Windows.Forms.TextBox txtcgpa;
    }
}

