﻿namespace C_GUI.Views
{
    partial class FormBanHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnBoLoc = new C_GUI.RJControls.RJButton();
            this._cbxTimKiemHangGiay = new C_GUI.RJControls.RJComboBox();
            this._cbxTimKiemMauSac = new C_GUI.RJControls.RJComboBox();
            this._cbxTimKiemTenGiay = new C_GUI.RJControls.RJComboBox();
            this._lsvShowSanPham = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.TenGiay = new System.Windows.Forms.ColumnHeader();
            this.MauSac = new System.Windows.Forms.ColumnHeader();
            this.HangGiay = new System.Windows.Forms.ColumnHeader();
            this.Nsx = new System.Windows.Forms.ColumnHeader();
            this.Size = new System.Windows.Forms.ColumnHeader();
            this.ChieuCaoDeGiay = new System.Windows.Forms.ColumnHeader();
            this.GiaBan = new System.Windows.Forms.ColumnHeader();
            this.SoLuongTon = new System.Windows.Forms.ColumnHeader();
            this.MoTa = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._cbxTimKiemGioHang = new C_GUI.RJControls.RJComboBox();
            this._lsvGioHang = new System.Windows.Forms.ListView();
            this._Id = new System.Windows.Forms.ColumnHeader();
            this._TenGiay = new System.Windows.Forms.ColumnHeader();
            this._DonGia = new System.Windows.Forms.ColumnHeader();
            this._SoLuong = new System.Windows.Forms.ColumnHeader();
            this._ThanhTien = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._cbxTimKiemHoaDon = new C_GUI.RJControls.RJComboBox();
            this._lsvHoaDon = new System.Windows.Forms.ListView();
            this.IdHoaDon = new System.Windows.Forms.ColumnHeader();
            this.MaHoaDon = new System.Windows.Forms.ColumnHeader();
            this.PhuongThuaMua = new System.Windows.Forms.ColumnHeader();
            this.TrangThai = new System.Windows.Forms.ColumnHeader();
            this.MoTaHoaDon = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this._btnTaoHoaDon = new C_GUI.RJControls.RJButton();
            this._cbxKhachHang = new C_GUI.RJControls.RJComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._btnHuyHoaDon = new C_GUI.RJControls.RJButton();
            this._tbxMaHoaDon = new C_GUI.RJControls.RJTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this._tbxTienThua = new C_GUI.RJControls.RJTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this._tbxTienKhachDua = new C_GUI.RJControls.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._tbxTongTien = new C_GUI.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._tbxGhiChu = new C_GUI.RJControls.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._tbxGiamGia = new C_GUI.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnShipHang = new C_GUI.RJControls.RJButton();
            this._cbxPhuongThucMua = new C_GUI.RJControls.RJComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this._btnThanhToan = new C_GUI.RJControls.RJButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnBoLoc);
            this.groupBox1.Controls.Add(this._cbxTimKiemHangGiay);
            this.groupBox1.Controls.Add(this._cbxTimKiemMauSac);
            this.groupBox1.Controls.Add(this._cbxTimKiemTenGiay);
            this.groupBox1.Controls.Add(this._lsvShowSanPham);
            this.groupBox1.Location = new System.Drawing.Point(14, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1139, 564);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sản Phẩm";
            // 
            // _btnBoLoc
            // 
            this._btnBoLoc.BackColor = System.Drawing.Color.Turquoise;
            this._btnBoLoc.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnBoLoc.BorderColor = System.Drawing.Color.Black;
            this._btnBoLoc.BorderRadius = 15;
            this._btnBoLoc.BorderSize = 2;
            this._btnBoLoc.FlatAppearance.BorderSize = 0;
            this._btnBoLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnBoLoc.ForeColor = System.Drawing.Color.Black;
            this._btnBoLoc.Location = new System.Drawing.Point(713, 33);
            this._btnBoLoc.Name = "_btnBoLoc";
            this._btnBoLoc.Size = new System.Drawing.Size(415, 39);
            this._btnBoLoc.SizeImage = new System.Drawing.Size(20, 20);
            this._btnBoLoc.TabIndex = 57;
            this._btnBoLoc.Text = "Bỏ lọc";
            this._btnBoLoc.TextColor = System.Drawing.Color.Black;
            this._btnBoLoc.UseVisualStyleBackColor = false;
            this._btnBoLoc.Click += new System.EventHandler(this._btnBoLoc_Click);
            // 
            // _cbxTimKiemHangGiay
            // 
            this._cbxTimKiemHangGiay.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxTimKiemHangGiay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemHangGiay.BorderSize = 1;
            this._cbxTimKiemHangGiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxTimKiemHangGiay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxTimKiemHangGiay.ForeColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemHangGiay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemHangGiay.Items.AddRange(new object[] {
            "Tất cả hãng giày"});
            this._cbxTimKiemHangGiay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxTimKiemHangGiay.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemHangGiay.Location = new System.Drawing.Point(478, 32);
            this._cbxTimKiemHangGiay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxTimKiemHangGiay.MinimumSize = new System.Drawing.Size(229, 40);
            this._cbxTimKiemHangGiay.Name = "_cbxTimKiemHangGiay";
            this._cbxTimKiemHangGiay.Padding = new System.Windows.Forms.Padding(1);
            this._cbxTimKiemHangGiay.Size = new System.Drawing.Size(229, 44);
            this._cbxTimKiemHangGiay.TabIndex = 4;
            this._cbxTimKiemHangGiay.Texts = "";
            this._cbxTimKiemHangGiay.OnSelectedIndexChanged += new System.EventHandler(this._cbxTimKiemHangGiay_OnSelectedIndexChanged);
            // 
            // _cbxTimKiemMauSac
            // 
            this._cbxTimKiemMauSac.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxTimKiemMauSac.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemMauSac.BorderSize = 1;
            this._cbxTimKiemMauSac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxTimKiemMauSac.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxTimKiemMauSac.ForeColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemMauSac.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemMauSac.Items.AddRange(new object[] {
            "Tất cả màu sắc"});
            this._cbxTimKiemMauSac.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxTimKiemMauSac.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemMauSac.Location = new System.Drawing.Point(242, 32);
            this._cbxTimKiemMauSac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxTimKiemMauSac.MinimumSize = new System.Drawing.Size(229, 40);
            this._cbxTimKiemMauSac.Name = "_cbxTimKiemMauSac";
            this._cbxTimKiemMauSac.Padding = new System.Windows.Forms.Padding(1);
            this._cbxTimKiemMauSac.Size = new System.Drawing.Size(229, 44);
            this._cbxTimKiemMauSac.TabIndex = 3;
            this._cbxTimKiemMauSac.Texts = "";
            this._cbxTimKiemMauSac.OnSelectedIndexChanged += new System.EventHandler(this._cbxTimKiemMauSac_OnSelectedIndexChanged);
            // 
            // _cbxTimKiemTenGiay
            // 
            this._cbxTimKiemTenGiay.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxTimKiemTenGiay.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemTenGiay.BorderSize = 1;
            this._cbxTimKiemTenGiay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxTimKiemTenGiay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxTimKiemTenGiay.ForeColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemTenGiay.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemTenGiay.Items.AddRange(new object[] {
            "Tất cả tên giày"});
            this._cbxTimKiemTenGiay.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxTimKiemTenGiay.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemTenGiay.Location = new System.Drawing.Point(7, 32);
            this._cbxTimKiemTenGiay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxTimKiemTenGiay.MinimumSize = new System.Drawing.Size(229, 40);
            this._cbxTimKiemTenGiay.Name = "_cbxTimKiemTenGiay";
            this._cbxTimKiemTenGiay.Padding = new System.Windows.Forms.Padding(1);
            this._cbxTimKiemTenGiay.Size = new System.Drawing.Size(229, 44);
            this._cbxTimKiemTenGiay.TabIndex = 2;
            this._cbxTimKiemTenGiay.Texts = "";
            this._cbxTimKiemTenGiay.OnSelectedIndexChanged += new System.EventHandler(this._cbxTimKiemTenGiay_OnSelectedIndexChanged);
            // 
            // _lsvShowSanPham
            // 
            this._lsvShowSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.TenGiay,
            this.MauSac,
            this.HangGiay,
            this.Nsx,
            this.Size,
            this.ChieuCaoDeGiay,
            this.GiaBan,
            this.SoLuongTon,
            this.MoTa});
            this._lsvShowSanPham.FullRowSelect = true;
            this._lsvShowSanPham.Location = new System.Drawing.Point(6, 79);
            this._lsvShowSanPham.Name = "_lsvShowSanPham";
            this._lsvShowSanPham.Size = new System.Drawing.Size(1122, 466);
            this._lsvShowSanPham.TabIndex = 1;
            this._lsvShowSanPham.UseCompatibleStateImageBehavior = false;
            this._lsvShowSanPham.View = System.Windows.Forms.View.Details;
            this._lsvShowSanPham.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._lsvShowSanPham_ColumnClick);
            this._lsvShowSanPham.DoubleClick += new System.EventHandler(this._lsvShowSanPham_DoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "Id";
            this.Id.Width = 0;
            // 
            // TenGiay
            // 
            this.TenGiay.Text = "Tên Giày";
            this.TenGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TenGiay.Width = 100;
            // 
            // MauSac
            // 
            this.MauSac.Text = "Màu Sắc";
            this.MauSac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MauSac.Width = 100;
            // 
            // HangGiay
            // 
            this.HangGiay.Text = "Hãng Giày";
            this.HangGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HangGiay.Width = 100;
            // 
            // Nsx
            // 
            this.Nsx.Text = "Nsx";
            this.Nsx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nsx.Width = 100;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Size.Width = 100;
            // 
            // ChieuCaoDeGiay
            // 
            this.ChieuCaoDeGiay.Text = "Chiều Cao Đế Giày";
            this.ChieuCaoDeGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ChieuCaoDeGiay.Width = 150;
            // 
            // GiaBan
            // 
            this.GiaBan.Text = "Giá Bán";
            this.GiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaBan.Width = 100;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.Text = "Số Lượng Tồn";
            this.SoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuongTon.Width = 100;
            // 
            // MoTa
            // 
            this.MoTa.Text = "Mô Tả";
            this.MoTa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoTa.Width = 365;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._cbxTimKiemGioHang);
            this.groupBox2.Controls.Add(this._lsvGioHang);
            this.groupBox2.Location = new System.Drawing.Point(14, 613);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 485);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ Hàng";
            // 
            // _cbxTimKiemGioHang
            // 
            this._cbxTimKiemGioHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxTimKiemGioHang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemGioHang.BorderSize = 1;
            this._cbxTimKiemGioHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxTimKiemGioHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxTimKiemGioHang.ForeColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemGioHang.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemGioHang.Items.AddRange(new object[] {
            "Tất cả mã giày"});
            this._cbxTimKiemGioHang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxTimKiemGioHang.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemGioHang.Location = new System.Drawing.Point(7, 28);
            this._cbxTimKiemGioHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxTimKiemGioHang.MinimumSize = new System.Drawing.Size(229, 40);
            this._cbxTimKiemGioHang.Name = "_cbxTimKiemGioHang";
            this._cbxTimKiemGioHang.Padding = new System.Windows.Forms.Padding(1);
            this._cbxTimKiemGioHang.Size = new System.Drawing.Size(555, 44);
            this._cbxTimKiemGioHang.TabIndex = 6;
            this._cbxTimKiemGioHang.Texts = "";
            this._cbxTimKiemGioHang.OnSelectedIndexChanged += new System.EventHandler(this._cbxTimKiemGioHang_OnSelectedIndexChanged);
            // 
            // _lsvGioHang
            // 
            this._lsvGioHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Id,
            this._TenGiay,
            this._DonGia,
            this._SoLuong,
            this._ThanhTien});
            this._lsvGioHang.FullRowSelect = true;
            this._lsvGioHang.Location = new System.Drawing.Point(6, 75);
            this._lsvGioHang.Name = "_lsvGioHang";
            this._lsvGioHang.Size = new System.Drawing.Size(563, 404);
            this._lsvGioHang.TabIndex = 0;
            this._lsvGioHang.UseCompatibleStateImageBehavior = false;
            this._lsvGioHang.View = System.Windows.Forms.View.Details;
            this._lsvGioHang.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._lsvGioHang_ColumnClick);
            this._lsvGioHang.DoubleClick += new System.EventHandler(this._lsvGioHang_DoubleClick);
            // 
            // _Id
            // 
            this._Id.Text = "Id";
            this._Id.Width = 0;
            // 
            // _TenGiay
            // 
            this._TenGiay.Text = "Tên Giày ";
            this._TenGiay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._TenGiay.Width = 100;
            // 
            // _DonGia
            // 
            this._DonGia.Text = "Đơn Giá";
            this._DonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._DonGia.Width = 100;
            // 
            // _SoLuong
            // 
            this._SoLuong.Text = "Số Lượng";
            this._SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._SoLuong.Width = 125;
            // 
            // _ThanhTien
            // 
            this._ThanhTien.Text = "Thành tiền";
            this._ThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._ThanhTien.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this._cbxTimKiemHoaDon);
            this.groupBox4.Controls.Add(this._lsvHoaDon);
            this.groupBox4.Location = new System.Drawing.Point(587, 613);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1096, 421);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hóa Đơn";
            // 
            // _cbxTimKiemHoaDon
            // 
            this._cbxTimKiemHoaDon.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxTimKiemHoaDon.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemHoaDon.BorderSize = 1;
            this._cbxTimKiemHoaDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxTimKiemHoaDon.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxTimKiemHoaDon.ForeColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemHoaDon.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxTimKiemHoaDon.Items.AddRange(new object[] {
            "Tất cả hóa đơn",
            "Hóa đơn chờ",
            "Hóa đơn đã ship",
            "Hóa đơn đã thanh toán",
            "Hóa đơn đã hủy"});
            this._cbxTimKiemHoaDon.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxTimKiemHoaDon.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxTimKiemHoaDon.Location = new System.Drawing.Point(7, 28);
            this._cbxTimKiemHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxTimKiemHoaDon.MinimumSize = new System.Drawing.Size(229, 40);
            this._cbxTimKiemHoaDon.Name = "_cbxTimKiemHoaDon";
            this._cbxTimKiemHoaDon.Padding = new System.Windows.Forms.Padding(1);
            this._cbxTimKiemHoaDon.Size = new System.Drawing.Size(1082, 44);
            this._cbxTimKiemHoaDon.TabIndex = 7;
            this._cbxTimKiemHoaDon.Texts = "";
            this._cbxTimKiemHoaDon.OnSelectedIndexChanged += new System.EventHandler(this._cbxTimKiemHoaDon_OnSelectedIndexChanged);
            // 
            // _lsvHoaDon
            // 
            this._lsvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdHoaDon,
            this.MaHoaDon,
            this.PhuongThuaMua,
            this.TrangThai,
            this.MoTaHoaDon});
            this._lsvHoaDon.FullRowSelect = true;
            this._lsvHoaDon.Location = new System.Drawing.Point(7, 75);
            this._lsvHoaDon.Name = "_lsvHoaDon";
            this._lsvHoaDon.Size = new System.Drawing.Size(1082, 404);
            this._lsvHoaDon.TabIndex = 2;
            this._lsvHoaDon.UseCompatibleStateImageBehavior = false;
            this._lsvHoaDon.View = System.Windows.Forms.View.Details;
            this._lsvHoaDon.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this._lsvHoaDon_ColumnClick);
            this._lsvHoaDon.DoubleClick += new System.EventHandler(this._lsvHoaDon_DoubleClick);
            // 
            // IdHoaDon
            // 
            this.IdHoaDon.Text = "Id";
            this.IdHoaDon.Width = 0;
            // 
            // MaHoaDon
            // 
            this.MaHoaDon.Text = "Mã hóa đơn";
            this.MaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaHoaDon.Width = 120;
            // 
            // PhuongThuaMua
            // 
            this.PhuongThuaMua.Text = "Phương thức mua";
            this.PhuongThuaMua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhuongThuaMua.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.Text = "Trạng thái";
            this.TrangThai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TrangThai.Width = 200;
            // 
            // MoTaHoaDon
            // 
            this.MoTaHoaDon.Text = "Mô tả";
            this.MoTaHoaDon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MoTaHoaDon.Width = 650;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khách Hàng";
            // 
            // _btnTaoHoaDon
            // 
            this._btnTaoHoaDon.BackColor = System.Drawing.Color.Turquoise;
            this._btnTaoHoaDon.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnTaoHoaDon.BorderColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.BorderRadius = 15;
            this._btnTaoHoaDon.BorderSize = 2;
            this._btnTaoHoaDon.FlatAppearance.BorderSize = 0;
            this._btnTaoHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnTaoHoaDon.ForeColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.Location = new System.Drawing.Point(17, 175);
            this._btnTaoHoaDon.Name = "_btnTaoHoaDon";
            this._btnTaoHoaDon.Size = new System.Drawing.Size(443, 39);
            this._btnTaoHoaDon.SizeImage = new System.Drawing.Size(20, 20);
            this._btnTaoHoaDon.TabIndex = 16;
            this._btnTaoHoaDon.Text = "Tạo Hóa Đơn";
            this._btnTaoHoaDon.TextColor = System.Drawing.Color.Black;
            this._btnTaoHoaDon.UseVisualStyleBackColor = false;
            this._btnTaoHoaDon.Click += new System.EventHandler(this._btnTaoHoaDon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mã Nhân Viên";
            // 
            // _cbxKhachHang
            // 
            this._cbxKhachHang.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxKhachHang.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxKhachHang.BorderSize = 1;
            this._cbxKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxKhachHang.ForeColor = System.Drawing.Color.DimGray;
            this._cbxKhachHang.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxKhachHang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxKhachHang.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxKhachHang.Location = new System.Drawing.Point(193, 32);
            this._cbxKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxKhachHang.MinimumSize = new System.Drawing.Size(229, 40);
            this._cbxKhachHang.Name = "_cbxKhachHang";
            this._cbxKhachHang.Padding = new System.Windows.Forms.Padding(1);
            this._cbxKhachHang.Size = new System.Drawing.Size(267, 44);
            this._cbxKhachHang.TabIndex = 21;
            this._cbxKhachHang.Texts = "";
            // 
            // _cbxNhanVien
            // 
            this._cbxNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxNhanVien.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNhanVien.BorderSize = 1;
            this._cbxNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxNhanVien.ForeColor = System.Drawing.Color.DimGray;
            this._cbxNhanVien.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxNhanVien.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxNhanVien.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxNhanVien.Location = new System.Drawing.Point(192, 80);
            this._cbxNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxNhanVien.MinimumSize = new System.Drawing.Size(229, 40);
            this._cbxNhanVien.Name = "_cbxNhanVien";
            this._cbxNhanVien.Padding = new System.Windows.Forms.Padding(1);
            this._cbxNhanVien.Size = new System.Drawing.Size(269, 44);
            this._cbxNhanVien.TabIndex = 22;
            this._cbxNhanVien.Texts = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._btnHuyHoaDon);
            this.groupBox3.Controls.Add(this._tbxMaHoaDon);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this._tbxTienThua);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this._tbxTienKhachDua);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this._tbxTongTien);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this._tbxGhiChu);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this._tbxGiamGia);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this._btnShipHang);
            this.groupBox3.Controls.Add(this._cbxPhuongThucMua);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this._btnThanhToan);
            this.groupBox3.Controls.Add(this._cbxKhachHang);
            this.groupBox3.Controls.Add(this._btnTaoHoaDon);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(1159, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(467, 588);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin";
            // 
            // _btnHuyHoaDon
            // 
            this._btnHuyHoaDon.BackColor = System.Drawing.Color.Turquoise;
            this._btnHuyHoaDon.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnHuyHoaDon.BorderColor = System.Drawing.Color.Black;
            this._btnHuyHoaDon.BorderRadius = 15;
            this._btnHuyHoaDon.BorderSize = 2;
            this._btnHuyHoaDon.FlatAppearance.BorderSize = 0;
            this._btnHuyHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnHuyHoaDon.ForeColor = System.Drawing.Color.Black;
            this._btnHuyHoaDon.Location = new System.Drawing.Point(7, 501);
            this._btnHuyHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._btnHuyHoaDon.Name = "_btnHuyHoaDon";
            this._btnHuyHoaDon.Size = new System.Drawing.Size(396, 29);
            this._btnHuyHoaDon.SizeImage = new System.Drawing.Size(20, 20);
            this._btnHuyHoaDon.TabIndex = 57;
            this._btnHuyHoaDon.Text = "Hủy hóa đơn";
            this._btnHuyHoaDon.TextColor = System.Drawing.Color.Black;
            this._btnHuyHoaDon.UseVisualStyleBackColor = false;
            this._btnHuyHoaDon.Click += new System.EventHandler(this._btnHuyHoaDon_Click);
            // 
            // _tbxMaHoaDon
            // 
            this._tbxMaHoaDon.BackColor = System.Drawing.SystemColors.Window;
            this._tbxMaHoaDon.BorderColor = System.Drawing.Color.Black;
            this._tbxMaHoaDon.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxMaHoaDon.BorderRadius = 15;
            this._tbxMaHoaDon.BorderSize = 2;
            this._tbxMaHoaDon.Enabled = false;
            this._tbxMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxMaHoaDon.Location = new System.Drawing.Point(192, 221);
            this._tbxMaHoaDon.Margin = new System.Windows.Forms.Padding(5);
            this._tbxMaHoaDon.MaxLength = 20;
            this._tbxMaHoaDon.Multiline = false;
            this._tbxMaHoaDon.Name = "_tbxMaHoaDon";
            this._tbxMaHoaDon.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this._tbxMaHoaDon.PasswordChar = false;
            this._tbxMaHoaDon.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxMaHoaDon.PlaceholderText = "";
            this._tbxMaHoaDon.Size = new System.Drawing.Size(267, 39);
            this._tbxMaHoaDon.TabIndex = 56;
            this._tbxMaHoaDon.Texts = "";
            this._tbxMaHoaDon.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(16, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 28);
            this.label9.TabIndex = 55;
            this.label9.Text = "Mã hóa đơn";
            // 
            // _tbxTienThua
            // 
            this._tbxTienThua.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTienThua.BorderColor = System.Drawing.Color.Black;
            this._tbxTienThua.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTienThua.BorderRadius = 15;
            this._tbxTienThua.BorderSize = 2;
            this._tbxTienThua.Enabled = false;
            this._tbxTienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTienThua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTienThua.Location = new System.Drawing.Point(191, 481);
            this._tbxTienThua.Margin = new System.Windows.Forms.Padding(5);
            this._tbxTienThua.MaxLength = 20;
            this._tbxTienThua.Multiline = false;
            this._tbxTienThua.Name = "_tbxTienThua";
            this._tbxTienThua.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this._tbxTienThua.PasswordChar = false;
            this._tbxTienThua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTienThua.PlaceholderText = "";
            this._tbxTienThua.Size = new System.Drawing.Size(267, 39);
            this._tbxTienThua.TabIndex = 54;
            this._tbxTienThua.Texts = "0";
            this._tbxTienThua.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(15, 494);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 28);
            this.label8.TabIndex = 53;
            this.label8.Text = "Tiền thừa";
            // 
            // _tbxTienKhachDua
            // 
            this._tbxTienKhachDua.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTienKhachDua.BorderColor = System.Drawing.Color.Black;
            this._tbxTienKhachDua.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTienKhachDua.BorderRadius = 15;
            this._tbxTienKhachDua.BorderSize = 2;
            this._tbxTienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTienKhachDua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTienKhachDua.Location = new System.Drawing.Point(192, 429);
            this._tbxTienKhachDua.Margin = new System.Windows.Forms.Padding(5);
            this._tbxTienKhachDua.MaxLength = 20;
            this._tbxTienKhachDua.Multiline = false;
            this._tbxTienKhachDua.Name = "_tbxTienKhachDua";
            this._tbxTienKhachDua.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this._tbxTienKhachDua.PasswordChar = false;
            this._tbxTienKhachDua.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTienKhachDua.PlaceholderText = "";
            this._tbxTienKhachDua.Size = new System.Drawing.Size(267, 39);
            this._tbxTienKhachDua.TabIndex = 52;
            this._tbxTienKhachDua.Texts = "0";
            this._tbxTienKhachDua.UnderlinedStyle = false;
            this._tbxTienKhachDua._TextChanged += new System.EventHandler(this._tbxTienKhachDua__TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 28);
            this.label7.TabIndex = 51;
            this.label7.Text = "Tiền khách đưa";
            // 
            // _tbxTongTien
            // 
            this._tbxTongTien.BackColor = System.Drawing.SystemColors.Window;
            this._tbxTongTien.BorderColor = System.Drawing.Color.Black;
            this._tbxTongTien.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxTongTien.BorderRadius = 15;
            this._tbxTongTien.BorderSize = 2;
            this._tbxTongTien.Enabled = false;
            this._tbxTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxTongTien.Location = new System.Drawing.Point(192, 377);
            this._tbxTongTien.Margin = new System.Windows.Forms.Padding(5);
            this._tbxTongTien.MaxLength = 20;
            this._tbxTongTien.Multiline = false;
            this._tbxTongTien.Name = "_tbxTongTien";
            this._tbxTongTien.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this._tbxTongTien.PasswordChar = false;
            this._tbxTongTien.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxTongTien.PlaceholderText = "";
            this._tbxTongTien.Size = new System.Drawing.Size(267, 39);
            this._tbxTongTien.TabIndex = 50;
            this._tbxTongTien.Texts = "";
            this._tbxTongTien.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 28);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tổng tiền";
            // 
            // _tbxGhiChu
            // 
            this._tbxGhiChu.BackColor = System.Drawing.SystemColors.Window;
            this._tbxGhiChu.BorderColor = System.Drawing.Color.Black;
            this._tbxGhiChu.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxGhiChu.BorderRadius = 15;
            this._tbxGhiChu.BorderSize = 2;
            this._tbxGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxGhiChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxGhiChu.Location = new System.Drawing.Point(192, 325);
            this._tbxGhiChu.Margin = new System.Windows.Forms.Padding(5);
            this._tbxGhiChu.MaxLength = 20;
            this._tbxGhiChu.Multiline = true;
            this._tbxGhiChu.Name = "_tbxGhiChu";
            this._tbxGhiChu.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this._tbxGhiChu.PasswordChar = false;
            this._tbxGhiChu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxGhiChu.PlaceholderText = "";
            this._tbxGhiChu.Size = new System.Drawing.Size(267, 42);
            this._tbxGhiChu.TabIndex = 48;
            this._tbxGhiChu.Texts = "";
            this._tbxGhiChu.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 28);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ghi chú";
            // 
            // _tbxGiamGia
            // 
            this._tbxGiamGia.BackColor = System.Drawing.SystemColors.Window;
            this._tbxGiamGia.BorderColor = System.Drawing.Color.Black;
            this._tbxGiamGia.BorderFocusColor = System.Drawing.Color.Red;
            this._tbxGiamGia.BorderRadius = 15;
            this._tbxGiamGia.BorderSize = 2;
            this._tbxGiamGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._tbxGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this._tbxGiamGia.Location = new System.Drawing.Point(192, 273);
            this._tbxGiamGia.Margin = new System.Windows.Forms.Padding(5);
            this._tbxGiamGia.MaxLength = 20;
            this._tbxGiamGia.Multiline = false;
            this._tbxGiamGia.Name = "_tbxGiamGia";
            this._tbxGiamGia.Padding = new System.Windows.Forms.Padding(11, 9, 11, 9);
            this._tbxGiamGia.PasswordChar = false;
            this._tbxGiamGia.PlaceholderColor = System.Drawing.Color.DarkGray;
            this._tbxGiamGia.PlaceholderText = "";
            this._tbxGiamGia.Size = new System.Drawing.Size(267, 39);
            this._tbxGiamGia.TabIndex = 46;
            this._tbxGiamGia.Texts = "0";
            this._tbxGiamGia.UnderlinedStyle = false;
            this._tbxGiamGia._TextChanged += new System.EventHandler(this._tbxGiamGia__TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 28);
            this.label1.TabIndex = 45;
            this.label1.Text = "Giảm giá";
            // 
            // _btnShipHang
            // 
            this._btnShipHang.BackColor = System.Drawing.Color.Turquoise;
            this._btnShipHang.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnShipHang.BorderColor = System.Drawing.Color.Black;
            this._btnShipHang.BorderRadius = 15;
            this._btnShipHang.BorderSize = 2;
            this._btnShipHang.FlatAppearance.BorderSize = 0;
            this._btnShipHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnShipHang.ForeColor = System.Drawing.Color.Black;
            this._btnShipHang.Location = new System.Drawing.Point(288, 530);
            this._btnShipHang.Name = "_btnShipHang";
            this._btnShipHang.Size = new System.Drawing.Size(171, 39);
            this._btnShipHang.SizeImage = new System.Drawing.Size(20, 20);
            this._btnShipHang.TabIndex = 44;
            this._btnShipHang.Text = "Ship hàng";
            this._btnShipHang.TextColor = System.Drawing.Color.Black;
            this._btnShipHang.UseVisualStyleBackColor = false;
            this._btnShipHang.Click += new System.EventHandler(this._btnShipHang_Click);
            // 
            // _cbxPhuongThucMua
            // 
            this._cbxPhuongThucMua.BackColor = System.Drawing.Color.WhiteSmoke;
            this._cbxPhuongThucMua.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxPhuongThucMua.BorderSize = 1;
            this._cbxPhuongThucMua.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this._cbxPhuongThucMua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._cbxPhuongThucMua.ForeColor = System.Drawing.Color.DimGray;
            this._cbxPhuongThucMua.IconColor = System.Drawing.Color.MediumSlateBlue;
            this._cbxPhuongThucMua.Items.AddRange(new object[] {
            "Mua tại cửa hàng",
            "Đặt hàng online"});
            this._cbxPhuongThucMua.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this._cbxPhuongThucMua.ListTextColor = System.Drawing.Color.DimGray;
            this._cbxPhuongThucMua.Location = new System.Drawing.Point(192, 128);
            this._cbxPhuongThucMua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._cbxPhuongThucMua.MinimumSize = new System.Drawing.Size(229, 40);
            this._cbxPhuongThucMua.Name = "_cbxPhuongThucMua";
            this._cbxPhuongThucMua.Padding = new System.Windows.Forms.Padding(1);
            this._cbxPhuongThucMua.Size = new System.Drawing.Size(269, 44);
            this._cbxPhuongThucMua.TabIndex = 43;
            this._cbxPhuongThucMua.Texts = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 28);
            this.label4.TabIndex = 42;
            this.label4.Text = "Phương thức mua";
            // 
            // _btnThanhToan
            // 
            this._btnThanhToan.BackColor = System.Drawing.Color.Turquoise;
            this._btnThanhToan.BackgroundColor = System.Drawing.Color.Turquoise;
            this._btnThanhToan.BorderColor = System.Drawing.Color.Black;
            this._btnThanhToan.BorderRadius = 15;
            this._btnThanhToan.BorderSize = 2;
            this._btnThanhToan.FlatAppearance.BorderSize = 0;
            this._btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._btnThanhToan.ForeColor = System.Drawing.Color.Black;
            this._btnThanhToan.Location = new System.Drawing.Point(8, 530);
            this._btnThanhToan.Name = "_btnThanhToan";
            this._btnThanhToan.Size = new System.Drawing.Size(273, 39);
            this._btnThanhToan.SizeImage = new System.Drawing.Size(20, 20);
            this._btnThanhToan.TabIndex = 41;
            this._btnThanhToan.Text = "Thanh Toán";
            this._btnThanhToan.TextColor = System.Drawing.Color.Black;
            this._btnThanhToan.UseVisualStyleBackColor = false;
            this._btnThanhToan.Click += new System.EventHandler(this._btnThanhToan_Click);
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private ListView _lsvShowSanPham;
        private ColumnHeader Id;
        private ColumnHeader TenGiay;
        private ColumnHeader MauSac;
        private ColumnHeader HangGiay;
        private ColumnHeader Nsx;
        private ColumnHeader Size;
        private ColumnHeader ChieuCaoDeGiay;
        private ColumnHeader GiaBan;
        private ColumnHeader SoLuongTon;
        private ColumnHeader MoTa;
        private ListView _lsvGioHang;
        private ColumnHeader _Id;
        private ColumnHeader _TenGiay;
        private ColumnHeader _DonGia;
        private ColumnHeader _SoLuong;
        private ListView _lsvHoaDon;
        private ColumnHeader IdHoaDon;
        private ColumnHeader MaHoaDon;
        private Label label2;
        private RJControls.RJButton _btnTaoHoaDon;
        private RJControls.RJComboBox _cbxKhachHang;
        private GroupBox groupBox3;
        private RJControls.RJButton _btnThanhToan;
        private RJControls.RJComboBox _cbxPhuongThucMua;
        private Label label4;
        private ColumnHeader PhuongThuaMua;
        private RJControls.RJButton _btnShipHang;
        private RJControls.RJComboBox _cbxTimKiemHangGiay;
        private RJControls.RJComboBox _cbxTimKiemMauSac;
        private RJControls.RJComboBox _cbxTimKiemTenGiay;
        private RJControls.RJComboBox _cbxTimKiemGioHang;
        private ColumnHeader _ThanhTien;
        private RJControls.RJComboBox _cbxTimKiemHoaDon;
        private RJControls.RJTextBox _tbxTienThua;
        private Label label8;
        private RJControls.RJTextBox _tbxTienKhachDua;
        private Label label7;
        private RJControls.RJTextBox _tbxTongTien;
        private Label label6;
        private RJControls.RJTextBox _tbxGhiChu;
        private Label label5;
        private RJControls.RJTextBox _tbxGiamGia;
        private Label label1;
        private RJControls.RJTextBox _tbxMaHoaDon;
        private Label label9;
        private ColumnHeader TrangThai;
        private ColumnHeader MoTaHoaDon;
        private RJControls.RJButton _btnBoLoc;
        private RJControls.RJButton _btnHuyHoaDon;
    }
}