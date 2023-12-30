namespace QuanLiBanVeMayBay
{
    partial class TuyenBay
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
            this.dataGridViewTuyenBay = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTenSanBayDen = new System.Windows.Forms.ComboBox();
            this.comboBoxTenSanBayDi = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTuyenBay = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuyenBay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTuyenBay
            // 
            this.dataGridViewTuyenBay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTuyenBay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTuyenBay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewTuyenBay.Location = new System.Drawing.Point(0, 316);
            this.dataGridViewTuyenBay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTuyenBay.Name = "dataGridViewTuyenBay";
            this.dataGridViewTuyenBay.ReadOnly = true;
            this.dataGridViewTuyenBay.RowHeadersWidth = 62;
            this.dataGridViewTuyenBay.RowTemplate.Height = 28;
            this.dataGridViewTuyenBay.Size = new System.Drawing.Size(1246, 271);
            this.dataGridViewTuyenBay.TabIndex = 1;
            this.dataGridViewTuyenBay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTuyenBay_CellClick);
            this.dataGridViewTuyenBay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTuyenBay_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::QuanLiBanVeMayBay.Properties.Resources.plane8;
            this.groupBox1.Controls.Add(this.comboBoxTenSanBayDen);
            this.groupBox1.Controls.Add(this.comboBoxTenSanBayDi);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaTuyenBay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1235, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuyển bay:";
            // 
            // comboBoxTenSanBayDen
            // 
            this.comboBoxTenSanBayDen.FormattingEnabled = true;
            this.comboBoxTenSanBayDen.Location = new System.Drawing.Point(581, 143);
            this.comboBoxTenSanBayDen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTenSanBayDen.Name = "comboBoxTenSanBayDen";
            this.comboBoxTenSanBayDen.Size = new System.Drawing.Size(346, 33);
            this.comboBoxTenSanBayDen.TabIndex = 13;
            this.comboBoxTenSanBayDen.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenSanBayDen_SelectedIndexChanged);
            // 
            // comboBoxTenSanBayDi
            // 
            this.comboBoxTenSanBayDi.FormattingEnabled = true;
            this.comboBoxTenSanBayDi.Location = new System.Drawing.Point(581, 96);
            this.comboBoxTenSanBayDi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTenSanBayDi.Name = "comboBoxTenSanBayDi";
            this.comboBoxTenSanBayDi.Size = new System.Drawing.Size(346, 33);
            this.comboBoxTenSanBayDi.TabIndex = 12;
            this.comboBoxTenSanBayDi.SelectedIndexChanged += new System.EventHandler(this.comboBoxTenSanBayDi_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(803, 235);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(124, 34);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(631, 235);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 34);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(452, 235);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 34);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(278, 235);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 34);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sân bay đến:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên sân bay đi:";
            // 
            // txtMaTuyenBay
            // 
            this.txtMaTuyenBay.Location = new System.Drawing.Point(581, 48);
            this.txtMaTuyenBay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaTuyenBay.Name = "txtMaTuyenBay";
            this.txtMaTuyenBay.Size = new System.Drawing.Size(346, 30);
            this.txtMaTuyenBay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tuyến bay:";
            // 
            // TuyenBay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 587);
            this.Controls.Add(this.dataGridViewTuyenBay);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TuyenBay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLiTuyenBay";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TuyenBay_FormClosed);
            this.Load += new System.EventHandler(this.TuyenBay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTuyenBay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridViewTuyenBay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTuyenBay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox comboBoxTenSanBayDen;
        private System.Windows.Forms.ComboBox comboBoxTenSanBayDi;
    }
}