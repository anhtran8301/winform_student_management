using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace ManagementStudentFirebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Declare

        private readonly DataTable dt = new DataTable();
        private readonly IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "J9ZPoQ1mIsRoyvPNfeoZHYruDCtqoJ5cLXP340fd",
            BasePath = "https://quanlysinhviendb-d59d5-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        #endregion

        #region Functions

        void Connecting()
        {
            txtHoTen.Focus();
            client = new FireSharp.FirebaseClient(config);
            //thêm headercolumn cho datagridview
            dt.Columns.Add("Mã");
            dt.Columns.Add("Họ và tên");
            dt.Columns.Add("Khoa");
            dt.Columns.Add("Lớp");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Địa chỉ");

            dtgDSHS.DataSource = dt;
        }
        

        private async void export()
        {
            //TRước khi lấy danh sách, xóa danh sách đang có trong DataGridView
            dt.Rows.Clear();
            int i = 0;
            //lấy tổng học sinh ở trên Firebase mục "SiSo"
            FirebaseResponse resp1 = await client.GetAsync("SiSo/");
            Counter obj1 = resp1.ResultAs<Counter>();

            int cnt = Convert.ToInt32(obj1.cnt);
            ErrorProvider errorProvider = new ErrorProvider();

            //Sử dụng vòng lặp while lặp đến tổng học sinh đang có
            while (true)
            {
                if (i == cnt)
                {
                    break;
                }
                i++;
                try
                {
                    //kết nối tới firebase và lấy danh sách về
                    FirebaseResponse resp2 = await client.GetAsync("QuanLyHocSinh/" + i);
                    Data obj2 = resp2.ResultAs<Data>();

                    DataRow row = dt.NewRow();

                    row["Mã"] = obj2.MSHS;
                    row["Họ và tên"] = obj2.HoTen;
                    row["Khoa"] = obj2.Khoa;
                    row["Lớp"] = obj2.Lop;
                    row["Ngày sinh"] = obj2.NgaySinh;
                    row["Địa chỉ"] = obj2.DiaChi;
                    row["Giới tính"] = obj2.GioiTinh;
                    // dùng phương thức Add() để đổ dữ liệu vào Datatable
                    dt.Rows.Add(row);
                    //hiển thị tổng học sinh
                    Total();
                    errorProvider.SetError(dtgDSHS, "");
                }
                catch(Exception e)
                {
                    errorProvider.SetError(dtgDSHS, $"Có lỗi xảy ra: {e.Message}");
 }
            }
        }

        private void Total()
        {
            int count = 0;
            if (dtgDSHS.Rows.Count <= 0)
            {
                txtTongHS.Text = "0";
            }
            else
            {
                count = Convert.ToInt32(dtgDSHS.Rows.Count);
                txtTongHS.Text = count.ToString();
            }
        }

        void BindingListStudent()
        {
            txtMaHS.DataBindings.Add(new Binding("Text", dtgDSHS.DataSource, "Mã", true, DataSourceUpdateMode.Never));
            txtHoTen.DataBindings.Add(new Binding("Text", dtgDSHS.DataSource, "Họ và tên", true, DataSourceUpdateMode.Never));
            txtKhoa.DataBindings.Add(new Binding("Text", dtgDSHS.DataSource, "Khoa", true, DataSourceUpdateMode.Never));
            txtLop.DataBindings.Add(new Binding("Text", dtgDSHS.DataSource, "Lớp", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dtgDSHS.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            dtpickerNgaySinh.DataBindings.Add(new Binding("Value", dtgDSHS.DataSource, "Ngày Sinh", true, DataSourceUpdateMode.Never));
            cboGioiTinh.DataBindings.Add(new Binding("Text", dtgDSHS.DataSource, "Giới Tính", true, DataSourceUpdateMode.Never));
        }

        void Reset()
        {
            txtHoTen.Text = "";
            txtMaHS.Text = "";
            txtKhoa.Text = "";
            txtLop.Text = "";
            txtDiaChi.Text = "";
            cboGioiTinh.Text = "Nam";
            txtHoTen.Focus();
        }

        private async void AddStudent()
        {
            string TxtkhoapValueFromAddStudent =string.Empty;
            string TxthotenpValueFromAddStudent = string.Empty;
            string TxtDiaChiPValueFromAddStudent = string.Empty;
            string TxtLopPValueFromAddStudent = string.Empty;
            string TxtMaHSPValueFromAddStudent = string.Empty;
            string TxtDateValueFromAddStudent = string.Empty;
            string TxtSexValueFromAddStudent = string.Empty;

            using (AddStudent add = new AddStudent())
            {
                if (add.ShowDialog() == DialogResult.OK) // Hiển thị form pop-up và chờ người dùng nhập thông tin
                {
                    // Lấy thông tin từ pop-up form sau khi người dùng nhập đủ
                    TxthotenpValueFromAddStudent = add.TxtHotenPValue;
                    TxtkhoapValueFromAddStudent=add.TxtKhoaPValue;
                    TxtDateValueFromAddStudent = add.TxtDateValue;
                    TxtDiaChiPValueFromAddStudent = add.TxtDiaChiPValue;
                    TxtMaHSPValueFromAddStudent = add.TxtMaHSPValue;
                    TxtLopPValueFromAddStudent = add.TxtLopPValue;
                    TxtSexValueFromAddStudent = add.TxtSexValue;

                    try
                    {
                        //lấy số lượng tổng học sinh
                        FirebaseResponse resp = await client.GetAsync("SiSo");
                        Counter get = resp.ResultAs<Counter>();

                        //khởi tạo một object thuộc Class Data
                        var data = new Data
                        {
                            MSHS = (Convert.ToInt32(get.cnt) + 1).ToString(),
                            HoTen = TxthotenpValueFromAddStudent,
                            Khoa=TxtkhoapValueFromAddStudent,
                            Lop = TxtLopPValueFromAddStudent,
                            NgaySinh = TxtDateValueFromAddStudent.ToString(),
                            DiaChi = TxtDiaChiPValueFromAddStudent,
                            GioiTinh = TxtSexValueFromAddStudent
                        };

                        //Đẩy dữ liệu lên Firebase
                        SetResponse response = await client.SetAsync("QuanLyHocSinh/" + data.MSHS, data);
                        Data result = response.ResultAs<Data>();

                        MessageBox.Show("Đã thêm mới thành công học sinh có mã " + result.MSHS);
                        Reset();

                        var obj = new Counter
                        {
                            cnt = data.MSHS
                        };

                        SetResponse response1 = await client.SetAsync("SiSo", obj);
                        export();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }


        private async void EditStudent()
        {
            if (txtMaHS.Text == "")
            {
                MessageBox.Show("Vui lòng chọn học sinh cần sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FirebaseResponse resp1 = await client.GetAsync("SiSo");
                Counter obj1 = resp1.ResultAs<Counter>();

                int cnt = Convert.ToInt32(obj1.cnt);
                if (Convert.ToInt32(txtMaHS.Text) > cnt)
                {
                    MessageBox.Show("Không tìm thấy học sinh cần sửa thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaHS.Text = "";
                    txtMaHS.Focus();
                }
                else
                {
                    var data = new Data
                    {
                        MSHS = txtMaHS.Text,
                        HoTen = txtHoTen.Text,
                        Khoa= txtKhoa.Text,
                        Lop = txtLop.Text,
                        NgaySinh = dtpickerNgaySinh.Text.ToString(),
                        DiaChi = txtDiaChi.Text,
                        GioiTinh = cboGioiTinh.Text
                    };

                    FirebaseResponse response = await client.UpdateAsync("QuanLyHocSinh/" + txtMaHS.Text, data);
                    Data result = response.ResultAs<Data>();
                    MessageBox.Show("Sửa thành công học sinh có mã: " + result.MSHS, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                    export();
                }
            }
        }

        private async void DeleteStudent()
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn xóa hết ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                FirebaseResponse response = await client.DeleteAsync("QuanLyHocSinh");
                MessageBox.Show("Đã xóa hết học sinh thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FirebaseResponse resp = await client.GetAsync("SiSo");
                Counter get = resp.ResultAs<Counter>();

                var obj = new Counter
                {
                    cnt = "0"
                };

                SetResponse response1 = await client.SetAsync("SiSo", obj);
                Reset();
                export();
                txtTongHS.Text = "0";
            }
        }
        private async void DeleteStudentSingle()
        {
            // Lấy mã học sinh từ TextBox txtMaHS
            string maHocSinh = txtMaHS.Text;

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dg == DialogResult.Yes)
            {
                FirebaseResponse response = await client.DeleteAsync("QuanLyHocSinh/" + maHocSinh);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Đã xóa học sinh thành công !!! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FirebaseResponse resp = await client.GetAsync("SiSo");
                    Counter get = resp.ResultAs<Counter>();

                    int currentCount = int.Parse(get.cnt);
                    if (currentCount > 0)
                    {
                        currentCount--;
                        var obj = new Counter
                        {
                            cnt = currentCount.ToString()
                        };

                        SetResponse response1 = await client.SetAsync("SiSo", obj);
                    }
                    Reset();
                    export();
                    txtTongHS.Text = currentCount.ToString();
                }
                else
                {
                    MessageBox.Show("Xóa học sinh thất bại. Vui lòng thử lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);

                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "Quản lý học sinh";

                // export header
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export content
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // save workbook
                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        #endregion

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {
            Connecting();
            export();
            BindingListStudent();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.Cancel)
            {
                e.Cancel = true; // Hủy sự kiện đóng form
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
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
                export();
                progressBar1.Value = progressBar1.Minimum;
                progressBar1.Visible = false;
            }
        }
        private void btnLayThongTin_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            timer1.Start();
            progressBar1.Visible = true;
        }

        private void time2_tick(object sender, EventArgs e) 
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer2.Stop(); // Stop the timer when the progress reaches 100
                Reset();
                progressBar1.Value = progressBar1.Minimum;
                progressBar1.Visible = false;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            timer2.Start();
            progressBar1.Visible = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            AddStudent();
        }


        private void time3_tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer3.Stop(); // Stop the timer when the progress reaches 100
                EditStudent();
                progressBar1.Value = progressBar1.Minimum;
                progressBar1.Visible = false;
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            timer3.Start();
            progressBar1.Visible = true;
        }
        private void time4_tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer4.Stop(); // Stop the timer when the progress reaches 100
                DeleteStudent();
                progressBar1.Value = progressBar1.Minimum;
                progressBar1.Visible = false;
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            timer4.Start();
            progressBar1.Visible = true;
        }

        private void txtLocDS_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtLocDS.Text, out int maFilter))
            {
                // Nếu là số, lọc theo trường "Mã"
                string rowFilter = string.Format("{0} = {1}", "Mã", maFilter);
                (dtgDSHS.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            else
            {
                // Nếu không phải số, lọc theo trường "Lớp"
                string rowFilter = string.Format("{0} like '{1}' OR {2} like '{3}'", "Lớp", "*" + txtLocDS.Text + "*", "Khoa", "*" + txtLocDS.Text + "*");
                (dtgDSHS.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
            }
            Total();
        }

        private void time5_tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer5.Stop(); // Stop the timer when the progress reaches 100
                ToExcel(dtgDSHS, saveFileDialog1.FileName);
                progressBar1.Value = progressBar1.Minimum;
                progressBar1.Visible = false;
            }
        }
        private void xuatDSHS_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Value = progressBar1.Minimum;
                timer5.Start();
                progressBar1.Visible = true;
            }
        }
        private void time6_tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer6.Stop(); // Stop the timer when the progress reaches 100
                DeleteStudentSingle();
                progressBar1.Value = progressBar1.Minimum;
                progressBar1.Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            timer6.Start();
            progressBar1.Visible = true;
        }

        #endregion

        private void dtgDSHS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtLop_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLop_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
