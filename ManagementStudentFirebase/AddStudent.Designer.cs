namespace ManagementStudentFirebase
{
    partial class AddStudent
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Khoa = new System.Windows.Forms.Label();
            this.txtKhoap = new System.Windows.Forms.TextBox();
            this.cboGioiTinhp = new System.Windows.Forms.ComboBox();
            this.dtpickerNgaySinhp = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChip = new System.Windows.Forms.TextBox();
            this.txtLopp = new System.Windows.Forms.TextBox();
            this.txtHoTenp = new System.Windows.Forms.TextBox();
            this.txtMaHSp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddNew = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Khoa);
            this.groupBox1.Controls.Add(this.txtKhoap);
            this.groupBox1.Controls.Add(this.cboGioiTinhp);
            this.groupBox1.Controls.Add(this.dtpickerNgaySinhp);
            this.groupBox1.Controls.Add(this.txtDiaChip);
            this.groupBox1.Controls.Add(this.txtLopp);
            this.groupBox1.Controls.Add(this.txtHoTenp);
            this.groupBox1.Controls.Add(this.txtMaHSp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(39, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 337);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm sinh viên";
            // 
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Location = new System.Drawing.Point(24, 113);
            this.Khoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(38, 16);
            this.Khoa.TabIndex = 17;
            this.Khoa.Text = "Khoa";
            // 
            // txtKhoap
            // 
            this.txtKhoap.Location = new System.Drawing.Point(127, 110);
            this.txtKhoap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKhoap.Name = "txtKhoap";
            this.txtKhoap.Size = new System.Drawing.Size(161, 22);
            this.txtKhoap.TabIndex = 16;
            // 
            // cboGioiTinhp
            // 
            this.cboGioiTinhp.FormattingEnabled = true;
            this.cboGioiTinhp.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinhp.Location = new System.Drawing.Point(127, 248);
            this.cboGioiTinhp.Name = "cboGioiTinhp";
            this.cboGioiTinhp.Size = new System.Drawing.Size(161, 24);
            this.cboGioiTinhp.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cboGioiTinhp, "Giới tính của học sinh mới");
            // 
            // dtpickerNgaySinhp
            // 
            this.dtpickerNgaySinhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpickerNgaySinhp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpickerNgaySinhp.Location = new System.Drawing.Point(127, 195);
            this.dtpickerNgaySinhp.Name = "dtpickerNgaySinhp";
            this.dtpickerNgaySinhp.Size = new System.Drawing.Size(161, 22);
            this.dtpickerNgaySinhp.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dtpickerNgaySinhp, "Chọn ngày tháng năm sinh");
            // 
            // txtDiaChip
            // 
            this.txtDiaChip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChip.Location = new System.Drawing.Point(127, 295);
            this.txtDiaChip.Name = "txtDiaChip";
            this.txtDiaChip.Size = new System.Drawing.Size(161, 22);
            this.txtDiaChip.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtDiaChip, "Địa chỉ của học sinh mới");
            // 
            // txtLopp
            // 
            this.txtLopp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLopp.Location = new System.Drawing.Point(127, 145);
            this.txtLopp.Name = "txtLopp";
            this.txtLopp.Size = new System.Drawing.Size(161, 22);
            this.txtLopp.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtLopp, "Nhập lớp của học sinh mới");
            // 
            // txtHoTenp
            // 
            this.txtHoTenp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenp.Location = new System.Drawing.Point(127, 74);
            this.txtHoTenp.Name = "txtHoTenp";
            this.txtHoTenp.Size = new System.Drawing.Size(161, 22);
            this.txtHoTenp.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtHoTenp, "Nhập họ và tên học sinh mới");
            // 
            // txtMaHSp
            // 
            this.txtMaHSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHSp.Location = new System.Drawing.Point(127, 35);
            this.txtMaHSp.Name = "txtMaHSp";
            this.txtMaHSp.ReadOnly = true;
            this.txtMaHSp.Size = new System.Drawing.Size(161, 22);
            this.txtMaHSp.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtMaHSp, "Nhập mã học sinh mới");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(24, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã học sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // AddNew
            // 
            this.AddNew.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddNew.Location = new System.Drawing.Point(366, 351);
            this.AddNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(117, 34);
            this.AddNew.TabIndex = 8;
            this.AddNew.Text = "THÊM MỚI";
            this.toolTip1.SetToolTip(this.AddNew, "Thêm thông tin học sinh mới");
            this.AddNew.UseVisualStyleBackColor = false;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.time1_tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(506, 352);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(124, 29);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 393);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.AddNew);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGioiTinhp;
        private System.Windows.Forms.DateTimePicker dtpickerNgaySinhp;
        private System.Windows.Forms.TextBox txtDiaChip;
        private System.Windows.Forms.TextBox txtLopp;
        private System.Windows.Forms.TextBox txtHoTenp;
        private System.Windows.Forms.TextBox txtMaHSp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddNew;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Khoa;
        private System.Windows.Forms.TextBox txtKhoap;
    }
}