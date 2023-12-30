namespace QuanLiBanVeMayBay
{
    partial class ThongTinKhachHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTTKhachHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(478, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // dataGridViewTTKhachHang
            // 
            this.dataGridViewTTKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTTKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewTTKhachHang.Location = new System.Drawing.Point(0, 102);
            this.dataGridViewTTKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewTTKhachHang.Name = "dataGridViewTTKhachHang";
            this.dataGridViewTTKhachHang.ReadOnly = true;
            this.dataGridViewTTKhachHang.RowHeadersWidth = 62;
            this.dataGridViewTTKhachHang.RowTemplate.Height = 28;
            this.dataGridViewTTKhachHang.Size = new System.Drawing.Size(1232, 258);
            this.dataGridViewTTKhachHang.TabIndex = 1;
            // 
            // ThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLiBanVeMayBay.Properties.Resources.plane10;
            this.ClientSize = new System.Drawing.Size(1232, 360);
            this.Controls.Add(this.dataGridViewTTKhachHang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ThongTinKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRA CỨU THÔNG TIN KHÁCH HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongTinKhachHang_FormClosed);
            this.Load += new System.EventHandler(this.ThongTinKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTKhachHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTTKhachHang;
    }
}