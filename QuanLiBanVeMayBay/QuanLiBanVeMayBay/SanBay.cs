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
    public partial class SanBay : Form
    {
        public SanBay()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();
        private void SanBay_Load(object sender, EventArgs e)
        {
            dt.Connect();

            //Trình bày dữ liệu lên dataGridView
            ShowData();
        }

        private void SanBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void dataGridViewSanBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaSanBay.Text = dataGridViewSanBay.Rows[numrow].Cells[0].Value.ToString();
            txtTenSanBay.Text = dataGridViewSanBay.Rows[numrow].Cells[1].Value.ToString();
            txtMaSanBay.ReadOnly = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            string query = " Select masanbay 'Mã sân bay', tensanbay 'Tên sân bay' "
                        + " from SANBAY "
                        + " where "
                        + " masanbay like '%" + txtSearch.Text + "%'"
                        + " or tensanbay like N'%" + txtSearch.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewSanBay.DataSource = data.Tables[0];

            txtMaSanBay.Text = "";
            txtTenSanBay.Text = "";
            txtSearch.Text = "";
        }

        private void ShowData()
        {
            dataGridViewSanBay.DataSource = dt.ExecuteData("Select masanbay ' Mã sân bay ', tensanbay ' Tên sân bay' " + " from SANBAY ");
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = " INSERT INTO SANBAY VALUES ("
                                + "'" + txtMaSanBay.Text + "',"
                                + " N'" + txtTenSanBay.Text + "')";
            bool kq = dt.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Đã thêm dữ liệu");
                ShowData();
            }
            else
            {
                MessageBox.Show("Không thể thêm dữ liệu");
            }
            txtMaSanBay.Text = "";
            txtTenSanBay.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = " UPDATE SANBAY "
                        + " SET "
                                + "tensanbay = N'" + txtTenSanBay.Text + "' "
                        + " WHERE "
                                + "masanbay = '" + txtMaSanBay.Text + "'";
            bool kq = dt.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Đã sửa dữ liệu thành công");
                ShowData();
            }
            else
            {
                MessageBox.Show("Không thể sửa dữ liệu");
            }

            txtMaSanBay.Text = "";
            txtTenSanBay.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = " DELETE SANBAY "
                        + " WHERE "
                                + "masanbay = '" + txtMaSanBay.Text + "' and "
                                + "tensanbay = N'" + txtTenSanBay.Text + "' ";
            bool kq = dt.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Đã xóa dữ liệu thành công");
                ShowData();
            }
            else
            {
                MessageBox.Show("Không thể xóa dữ liệu");
            }

            txtMaSanBay.Text = "";
            txtTenSanBay.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtMaSanBay.Text = "";
            txtTenSanBay.Text = "";
            txtMaSanBay.ReadOnly = false;
        }
    }
}
