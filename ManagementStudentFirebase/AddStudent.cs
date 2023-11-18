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
            txtHoTenp.Height = 50; // Đặt chiều cao là 50 (ví dụ)

        }
       
        public string TxtHotenPValue
        {
            get { return txtHoTenp.Text; }
        }
        public string TxtDiaChiPValue
        {
            get { return txtDiaChip.Text; }
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
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
