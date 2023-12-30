﻿namespace QuanLiBanVeMayBay
{
    partial class DatCho
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewDatCho = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxHangVe = new System.Windows.Forms.ComboBox();
            this.dateTimeNgayDat = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.comboBoxMaTuyenBay = new System.Windows.Forms.ComboBox();
            this.comboBoxMaKhachHang = new System.Windows.Forms.ComboBox();
            this.comboBoxMaChuyenBay = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSoGheDat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatCho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDatCho
            // 
            this.dataGridViewDatCho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatCho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDatCho.Location = new System.Drawing.Point(11, 247);
            this.dataGridViewDatCho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewDatCho.Name = "dataGridViewDatCho";
            this.dataGridViewDatCho.ReadOnly = true;
            this.dataGridViewDatCho.RowHeadersWidth = 62;
            this.dataGridViewDatCho.RowTemplate.Height = 28;
            this.dataGridViewDatCho.Size = new System.Drawing.Size(1302, 198);
            this.dataGridViewDatCho.TabIndex = 1;
            this.dataGridViewDatCho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatCho_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLiBanVeMayBay.Properties.Resources.plane2;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.comboBoxHangVe);
            this.groupBox1.Controls.Add(this.dateTimeNgayDat);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.comboBoxMaTuyenBay);
            this.groupBox1.Controls.Add(this.comboBoxMaKhachHang);
            this.groupBox1.Controls.Add(this.comboBoxMaChuyenBay);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtSoGheDat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1302, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu đặt chỗ:";
            // 
            // comboBoxHangVe
            // 
            this.comboBoxHangVe.FormattingEnabled = true;
            this.comboBoxHangVe.Location = new System.Drawing.Point(634, 86);
            this.comboBoxHangVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHangVe.Name = "comboBoxHangVe";
            this.comboBoxHangVe.Size = new System.Drawing.Size(248, 33);
            this.comboBoxHangVe.TabIndex = 29;
            // 
            // dateTimeNgayDat
            // 
            this.dateTimeNgayDat.CustomFormat = "hh:mm:ss  MM/dd/ yyyy";
            this.dateTimeNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayDat.Location = new System.Drawing.Point(634, 136);
            this.dateTimeNgayDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgayDat.MaxDate = new System.DateTime(2023, 12, 28, 0, 0, 0, 0);
            this.dateTimeNgayDat.Name = "dateTimeNgayDat";
            this.dateTimeNgayDat.Size = new System.Drawing.Size(248, 30);
            this.dateTimeNgayDat.TabIndex = 28;
            this.dateTimeNgayDat.Value = new System.DateTime(2023, 12, 28, 0, 0, 0, 0);
            this.dateTimeNgayDat.ValueChanged += new System.EventHandler(this.dateTimeNgayDat_ValueChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1145, 188);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(122, 37);
            this.btnThoat.TabIndex = 27;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(394, 188);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(122, 37);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(790, 188);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(122, 37);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(47, 188);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(122, 37);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // comboBoxMaTuyenBay
            // 
            this.comboBoxMaTuyenBay.FormattingEnabled = true;
            this.comboBoxMaTuyenBay.Location = new System.Drawing.Point(193, 86);
            this.comboBoxMaTuyenBay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaTuyenBay.Name = "comboBoxMaTuyenBay";
            this.comboBoxMaTuyenBay.Size = new System.Drawing.Size(228, 33);
            this.comboBoxMaTuyenBay.TabIndex = 23;
            // 
            // comboBoxMaKhachHang
            // 
            this.comboBoxMaKhachHang.FormattingEnabled = true;
            this.comboBoxMaKhachHang.Location = new System.Drawing.Point(634, 35);
            this.comboBoxMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaKhachHang.Name = "comboBoxMaKhachHang";
            this.comboBoxMaKhachHang.Size = new System.Drawing.Size(248, 33);
            this.comboBoxMaKhachHang.TabIndex = 22;
            // 
            // comboBoxMaChuyenBay
            // 
            this.comboBoxMaChuyenBay.FormattingEnabled = true;
            this.comboBoxMaChuyenBay.Location = new System.Drawing.Point(193, 140);
            this.comboBoxMaChuyenBay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaChuyenBay.Name = "comboBoxMaChuyenBay";
            this.comboBoxMaChuyenBay.Size = new System.Drawing.Size(228, 33);
            this.comboBoxMaChuyenBay.TabIndex = 20;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(1060, 138);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtThanhTien.Multiline = true;
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(229, 30);
            this.txtThanhTien.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Moccasin;
            this.label7.Location = new System.Drawing.Point(925, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Thành tiền:";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(1060, 82);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGiaTien.Multiline = true;
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(228, 30);
            this.txtGiaTien.TabIndex = 15;
            this.txtGiaTien.TextChanged += new System.EventHandler(this.txtGiaTien_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Moccasin;
            this.label8.Location = new System.Drawing.Point(925, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giá tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Moccasin;
            this.label9.Location = new System.Drawing.Point(17, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mã tuyến bay:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Moccasin;
            this.label10.Location = new System.Drawing.Point(451, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 25);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã hàng khách:";
            // 
            // txtSoGheDat
            // 
            this.txtSoGheDat.Location = new System.Drawing.Point(1060, 38);
            this.txtSoGheDat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoGheDat.Multiline = true;
            this.txtSoGheDat.Name = "txtSoGheDat";
            this.txtSoGheDat.Size = new System.Drawing.Size(228, 30);
            this.txtSoGheDat.TabIndex = 9;
            this.txtSoGheDat.TextChanged += new System.EventHandler(this.txtSoGheDat_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Moccasin;
            this.label5.Location = new System.Drawing.Point(451, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày đặt:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Moccasin;
            this.label4.Location = new System.Drawing.Point(925, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số ghế đặt:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Moccasin;
            this.label3.Location = new System.Drawing.Point(451, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hạng vé:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Moccasin;
            this.label2.Location = new System.Drawing.Point(17, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã chuyến bay:";
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(193, 31);
            this.txtMaPhieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhieu.Multiline = true;
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(228, 30);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // DatCho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 455);
            this.Controls.Add(this.dataGridViewDatCho);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DatCho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÍ ĐẶT CHỖ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatCho_FormClosed);
            this.Load += new System.EventHandler(this.DatCho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatCho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSoGheDat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMaTuyenBay;
        private System.Windows.Forms.ComboBox comboBoxMaKhachHang;
        private System.Windows.Forms.ComboBox comboBoxMaChuyenBay;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridViewDatCho;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDat;
        private System.Windows.Forms.ComboBox comboBoxHangVe;
    }
}