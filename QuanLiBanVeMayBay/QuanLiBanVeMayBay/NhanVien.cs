using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanVeMayBay
{
    public partial class NhanVien : Form
    {
        String flag;
        public NhanVien()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dt.Connect();
            ShowData();
            LockCOntrol();
            txtSearch.Text = "Tìm kiếm theo tên, mã, sđt, địa chỉ";
            txtSearch.ForeColor = Color.LightGray;
            dataGridViewNhanVien.AllowUserToAddRows = false;
            dataGridViewNhanVien.AllowUserToDeleteRows = false;
            dataGridViewNhanVien.ReadOnly = true;
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtTenNhanVien.Text = dataGridViewNhanVien.Rows[numrow].Cells[1].Value.ToString();
            txtMaNhanVien.Text = dataGridViewNhanVien.Rows[numrow].Cells[0].Value.ToString();
            txtSoDienThoai.Text = dataGridViewNhanVien.Rows[numrow].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridViewNhanVien.Rows[numrow].Cells[3].Value.ToString();

            //UnlockControl();
            btnSua.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = true;
            btnXoa.Enabled = true;
            txtMaNhanVien.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
            txtTenNhanVien.ReadOnly = true;
        }

        private void ShowData()
        {
            dataGridViewNhanVien.DataSource = dt.ExecuteData("Select manv 'Mã nhân viên', tennv 'Tên nhân viên', dienthoai 'Số điện thoại', diachi 'Địa chỉ'" + " from NHANVIEN ");
            dataGridViewNhanVien.Columns["Tên nhân viên"].Width = 150;  //đặt lại độ rộng cột
            dataGridViewNhanVien.Columns["Địa chỉ"].Width = 300;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            UnlockControl();
            flag = "add";
          
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            String query = "Select manv 'Mã nhân viên', tennv 'Tên nhân viên', dienthoai 'Số điện thoại', diachi 'Địa chỉ'"
                           + " from NHANVIEN "
                           + " where "
                           + " manv like '%" + txtSearch.Text + "%'"
                           + " or tennv like N'%" + txtSearch.Text + "%'"
                           + " or dienthoai like '%" + txtSearch.Text + "%'"
                           + " or diachi like N'%" + txtSearch.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dt.conn);
            adapter.Fill(data);
            dataGridViewNhanVien.DataSource = data.Tables[0];
            //dataGridViewNhanVien.Columns["Tên nhân viên"].Width = 150;  //đặt lại độ rộng cột
            //dataGridViewNhanVien.Columns["Địa chỉ"].Width = 300;
            txtSearch.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            UnlockControl();
            txtMaNhanVien.ReadOnly = true;
            flag = "edit";
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
                string query = " DELETE NHANVIEN "
                            + " WHERE "
                                    + "manv = '" + txtMaNhanVien.Text + "' and "
                                    + "tennv = '" + txtTenNhanVien.Text + "' and "
                                    + "dienthoai = '" + txtSoDienThoai.Text + "' and "
                                    + "diachi = '" + txtDiaChi.Text + "' ";

                bool kq = dt.exeSQL(query);
                if (kq == true)
                {
                    MessageBox.Show("Đã xóa dữ liệu thành công");
                    ShowData();
                    txtMaNhanVien.Text = "";
                    txtDiaChi.Text = "";
                    txtSoDienThoai.Text = "";
                    txtTenNhanVien.Text = "";
                }
                else
                {
                    MessageBox.Show("Không thể xóa dữ liệu");
                }

                txtMaNhanVien.Text = "";
                txtDiaChi.Text = "";
                txtSoDienThoai.Text = "";
                txtTenNhanVien.Text = "";
                LockCOntrol();

            
           
        }

        public void LockCOntrol()
        {
            btnAdd.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;


            txtTenNhanVien.ReadOnly = true;
            txtMaNhanVien.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            txtSoDienThoai.ReadOnly = true;
           
            btnAdd.Focus();

        }

        public void UnlockControl()
        {
            btnAdd.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnSave.Enabled = true;
            btnTimKiem.Enabled = true;
            btnCancel.Enabled = true;
           

            txtTenNhanVien.ReadOnly = false;
            txtMaNhanVien.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            txtSoDienThoai.ReadOnly = false;

            txtTenNhanVien.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                if (checkData())
                {
                    string query = " INSERT INTO NHANVIEN (manv, tennv, dienthoai, diachi, matkhau) VALUES ("
                            + "'" + txtMaNhanVien.Text + "', "
                            + "N'" + txtTenNhanVien.Text + "', "
                            + "'" + txtSoDienThoai.Text + "', "
                            + "N'" + txtDiaChi.Text + "', "
                            + "'123')";
                    bool kq = dt.exeSQL(query);
                    if (kq == true)
                    {
                        MessageBox.Show("Đã thêm dữ liệu");
                        ShowData();

                        txtMaNhanVien.Text = "";
                        txtDiaChi.Text = "";
                        txtSoDienThoai.Text = "";
                        txtTenNhanVien.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm dữ liệu");
                    }
                }
            }
            else
            {
                if (checkData())
                {
                    string query = " UPDATE NHANVIEN "
                           + " SET "
                                   + "tennv = '" + txtTenNhanVien.Text + "', "+ "dienthoai = '" + txtSoDienThoai.Text + "', "
                                   + "diachi = '" + txtDiaChi.Text + "' "
                           + " WHERE "
                                   + "manv = '" + txtMaNhanVien.Text + "'";
                    bool kq = dt.exeSQL(query);
                    if (kq == true)
                    {
                        MessageBox.Show("Đã sửa dữ liệu thành công");
                        ShowData();
                        txtMaNhanVien.Text = "";
                        txtDiaChi.Text = "";
                        txtSoDienThoai.Text = "";
                        txtTenNhanVien.Text = "";

                        txtMaNhanVien.ReadOnly = true;
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa dữ liệu");
                    }
                }
            }
            LockCOntrol();
        }

        public bool checkData()
        {
            if (string.IsNullOrWhiteSpace(txtTenNhanVien.Text))
            {
                MessageBox.Show("Nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNhanVien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMaNhanVien.Text))
            {

                MessageBox.Show("Nhập mã nhân viên  ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {

                MessageBox.Show("Nhập số điện thoại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoDienThoai.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {

                MessageBox.Show("Nhập địa chỉ ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return false;
            }
           

            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = "";
            txtDiaChi.Text = "";
            txtSoDienThoai.Text = "";
            txtTenNhanVien.Text = "";
            LockCOntrol();
        }

        private void btnAppearAll_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm theo tên, mã, sđt, địa chỉ")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm theo tên, mã, sđt, địa chỉ";
                txtSearch.ForeColor = Color.LightGray;
            }
        }

        private void dataGridViewNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
