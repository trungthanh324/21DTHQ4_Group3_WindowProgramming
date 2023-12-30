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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiBanVeMayBay
{
    public partial class DatCho : Form
    {
        public DatCho()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult retThoat = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(retThoat == DialogResult.Yes)
            {
                this.Close();
            }    
        }

        ConnectData dt = new ConnectData();
        private void DatCho_Load(object sender, EventArgs e)
        {
            dt.Connect();
            ShowData();
        }

        private void DatCho_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void dataGridViewDatCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaPhieu.Text = dataGridViewDatCho.Rows[numrow].Cells[0].Value.ToString();
            comboBoxMaKhachHang.Text = dataGridViewDatCho.Rows[numrow].Cells[1].Value.ToString();
            comboBoxMaChuyenBay.Text = dataGridViewDatCho.Rows[numrow].Cells[2].Value.ToString();
            
            comboBoxMaTuyenBay.Text = dataGridViewDatCho.Rows[numrow].Cells[3].Value.ToString();
            comboBoxHangVe.Text = dataGridViewDatCho.Rows[numrow].Cells[4].Value.ToString();
            txtSoGheDat.Text = dataGridViewDatCho.Rows[numrow].Cells[5].Value.ToString();
            dateTimeNgayDat.Text = dataGridViewDatCho.Rows[numrow].Cells[6].Value.ToString();
            txtGiaTien.Text = dataGridViewDatCho.Rows[numrow].Cells[7].Value.ToString();
        }

        private void ShowData()
        {
            //DataSet data = new DataSet();
            //string query = " Select MAPHIEU 'Mã phiếu', MAKH 'Mã khách hàng', MACHUYENBAY 'Mã chuyến bay', MATUYENBAY 'Mã tuyến bay', MAHANGVE 'Mã hạng vé', SOGHEDAT 'Số ghế đặt', NGAYDAT 'Ngày đặt', GIATIEN 'Giá tiền' "
            //            + " from DATCHO";
            //SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            //adp.Fill(data);
            //dataGridViewDatCho.DataSource = data.Tables[0];

            comboBoxMaChuyenBay.DataSource = dt.ExecuteData("Select * from CCHUYENBAY");
            comboBoxMaChuyenBay.DisplayMember = "machuyenbay";
            comboBoxMaChuyenBay.ValueMember = "machuyenbay";
            this.comboBoxMaChuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBoxMaTuyenBay.DataSource = dt.ExecuteData("Select * from TUYENBAY");
            comboBoxMaTuyenBay.DisplayMember = "matuyenbay";
            comboBoxMaTuyenBay.ValueMember = "matuyenbay";
            this.comboBoxMaTuyenBay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBoxMaKhachHang.DataSource = dt.ExecuteData("Select * from KKHACHHANG");
            comboBoxMaKhachHang.DisplayMember = "MAKH";
            comboBoxMaKhachHang.ValueMember = "MAKH";
            this.comboBoxMaKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            comboBoxHangVe.DataSource = dt.ExecuteData("Select * from HANGVE");
            comboBoxHangVe.DisplayMember = "tenhangve";
            comboBoxHangVe.ValueMember = "mahangve";
            this.comboBoxHangVe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            dataGridViewDatCho.DataSource = dt.ExecuteData(" Select MAPHIEU 'Mã phiếu', MAKH 'Mã khách hàng', MACHUYENBAY 'Mã chuyến bay', MATUYENBAY 'Mã tuyến bay', MAHANGVE 'Mã hạng vé', SOGHEDAT 'Số ghế đặt', NGAYDAT 'Ngày đặt', GIATIEN 'Giá tiền' from DATCHO");
            dataGridViewDatCho.Columns["Mã khách hàng"].Width = 150;
            dataGridViewDatCho.Columns["Mã chuyến bay"].Width = 150;
            dataGridViewDatCho.Columns["Giá tiền"].Width = 115;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO DATCHO VALUES ('"+txtMaPhieu.Text+"', '"+comboBoxMaKhachHang.Text+"', '"+comboBoxMaChuyenBay.Text+"', '"+comboBoxMaTuyenBay.Text+"','"+comboBoxHangVe.Text+"','"+txtSoGheDat.Text+"','"+dateTimeNgayDat.Text+"', '"+txtGiaTien.Text+"')";
              
                
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
            
         
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = " UPDATE DATCHO "
                        + " SET "
                                + "MAKH = '" + comboBoxMaKhachHang.Text + "', "
                                + "MACHUYENBAY = '" + comboBoxMaChuyenBay.Text + "', "
                                + "MATUYENBAY = '" + comboBoxMaTuyenBay.Text + "', "
                                + "MAHANGVE = N'" + comboBoxHangVe.Text + "', "
                                + "SOGHEDAT = '" + txtSoGheDat.Text + "', "
                                + "NGAYDAT = '" + dateTimeNgayDat.Text + "', "
                                + "GIATIEN = '" + txtGiaTien.Text + "' "
                        + " WHERE "
                                + "MAPHIEU = '" + txtMaPhieu.Text + "'";
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
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = " DELETE DATCHO "
                        + " WHERE "
                                + "MAPHIEU = '" + txtMaPhieu.Text + "'"; 
                                //and "
                                //+ "MAKH = '" + comboBoxMaKhachHang.Text + "' and "
                                //+ "MACHUYENBAY = '" + comboBoxMaChuyenBay.Text + "' and "
                                //+ "MATUYENBAY = '" + comboBoxMaTuyenBay.Text + "' and "
                                //+ "MAHANGVE = N'" + comboBoxHangVe.Text + "' and "
                                //+ "SOGHEDAT = '" + txtSoGheDat.Text + "' and "
                                //+ "NGAYDAT = '" + dateTimeNgayDat.Text + "' and "
                                //+ "GIATIEN = '" + txtGiaTien.Text + "' ";
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
          
            
        }

        private void txtGiaTien_TextChanged(object sender, EventArgs e)
        {
            int tongTien = 0;
            int soGheDat;
            int giaTien;

            if (txtSoGheDat.Text == "")
            {
                giaTien = Convert.ToInt32(txtGiaTien.Text);
                tongTien = giaTien * 0;
            }
            else
            {
                giaTien = Convert.ToInt32(txtGiaTien.Text);
                soGheDat = Convert.ToInt32(txtSoGheDat.Text);
                tongTien = soGheDat * giaTien;
            }
            txtThanhTien.Text = tongTien.ToString();
        }

        private void txtSoGheDat_TextChanged(object sender, EventArgs e)
        {
            int tongTien = 0;
            int soGheDat;
            int giaTien;

            if (txtGiaTien.Text == "")
            {
                soGheDat = Convert.ToInt32(txtSoGheDat.Text);
                tongTien = soGheDat * 0;
            }
            else
            {
                soGheDat = Convert.ToInt32(txtSoGheDat.Text);
                giaTien = Convert.ToInt32(txtGiaTien.Text);
                tongTien = soGheDat * giaTien;
            }
            txtThanhTien.Text = tongTien.ToString();
        }

        private void dateTimeNgayDat_ValueChanged(object sender, EventArgs e)
        {
           
                try
                {
                    DateTime selectedDate = dateTimeNgayDat.Value;
                    DateTime maxDate = DateTime.Today.AddDays(-1);

                    if (selectedDate > maxDate)
                    {
                        dateTimeNgayDat.Value = maxDate;
                        MessageBox.Show("Vui lòng chọn ngày trước ngày hôm nay.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi kiểm tra ngày tháng. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }
    }
}

