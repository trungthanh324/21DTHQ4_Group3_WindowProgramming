using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanVeMayBay
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();

        private void DoanhThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void btnTimTatCa_Click(object sender, EventArgs e)
        {
            dt.Connect();
            DataSet data = new DataSet();
            string query = "Select MAPHIEU 'Mã phiếu', MAKH 'Mã khách hàng', MACHUYENBAY 'Mã chuyến bay', MATUYENBAY 'Mã tuyến bay', MAHANGVE 'Mã hạng vé', SOGHEDAT 'Số ghế đặt', NGAYDAT 'Ngày đặt', GIATIEN 'Giá tiền'  "
                        + " from DATCHO ";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewDoanhThu.DataSource = data.Tables[0];
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dt.Connect();
            DataSet data = new DataSet();
            string query = " Select MAPHIEU 'Mã phiếu', MAKH 'Mã khách hàng', MACHUYENBAY 'Mã chuyến bay', MATUYENBAY 'Mã tuyến bay', MAHANGVE 'Mã hạng vé', SOGHEDAT 'Số ghế đặt', NGAYDAT 'Ngày đặt', GIATIEN 'Giá tiền' "
                        + "from DATCHO "
                         + " where "
                                + "NGAYDAT between '" + dateTimeTruoc.Text + "' and '" + dateTimeSau.Text + "' ";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewDoanhThu.DataSource = data.Tables[0];
        }
    }
}
