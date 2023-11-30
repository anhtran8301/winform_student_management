using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementStudentFirebase
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent(); 
          

        }
       
        public string TxtHotenPValue
        {
            get { return txtHoTenp.Text; }
        }
        public string TxtDiaChiPValue
        {
            get { return txtDiaChip.Text; }
        }
        public string TxtKhoaPValue
        {
            get { return txtKhoap.Text; }
        }
        public string TxtLopPValue
        {
            get { return txtLopp.Text; }
        }
        public string TxtMaHSPValue
        {
            get { return txtMaHSp.Text; }
        }
        public string TxtDateValue
        {
            get { return dtpickerNgaySinhp.Text; }
        }
        public string TxtSexValue
        {
            get { return cboGioiTinhp.Text; }
        }

        private void time1_tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Stop(); // Stop the timer when the progress reaches 100
                this.DialogResult = DialogResult.OK;
            }
        }
        private void AddNew_Click(object sender, EventArgs e)
        {
            if (txtHoTenp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập họ và tên học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtHoTenp.Focus();
            }
            else if (txtLopp.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lớp cho học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLopp.Focus();
            }
            else if (txtDiaChip.Text == "")
            {
                MessageBox.Show("Vui lòng nhập địa chỉ của học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChip.Focus();
            }
            else if (txtKhoap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập khoa của học sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKhoap.Focus();
            }
            else
            {
                progressBar1.Value = progressBar1.Minimum;
                timer1.Start();
                
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
