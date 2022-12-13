using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.Views
{
    public partial class FormBanHang : Form
    {
        private readonly IQLChiTietGiay _qlChiTietGiay;
        private readonly IQLHoaDonChiTiet _qlHoaDonChiTiet;
        private readonly IQLKhachHang _qlKhachHang;
        private readonly IQLChiTietSale _qlChiTietSale;
        private readonly IQLSale _qlSale;
        private readonly IQLHoaDon _qlHoaDon;
        private readonly IQLGiay _qlGiay;
        private readonly IQLMauSac _qlMauSac;
        private readonly IQLHangGiay _qlHangGiay;
        private readonly IQLChiTietThanhToan _qlChiTietThanhToan;
        private readonly IQLPhuongThucThanhToan _qlPhuongThucThanhToan;
        private Guid idHoaDon;
        private readonly ListViewColumnSorter lvwColumnSorter;
        private HoaDon? hoaDon;
        private Guid idHoaDonChiTiet;
        private HoaDonChiTiet? hoaDonChiTiet;
        Guid idThanhToanOnline;
        Guid idThanhToanOffline;

        public FormBanHang()
        {
            InitializeComponent();
            _qlChiTietGiay = new QLChiTietGiay();
            _qlHoaDonChiTiet = new QLHoaDonChiTiet();
            _qlKhachHang = new QLKhachHang();
            _qlChiTietSale = new QLChiTietSale();
            _qlSale = new QLSale();
            _qlHoaDon = new QLHoaDon();
            _qlGiay = new QLGiay();
            _qlMauSac = new QLMauSac();
            _qlHangGiay = new QLHangGiay();
            LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
            LoadComboBox();
            LoadHoaDon(_qlHoaDon.GetAllView().ToList());
            idHoaDon = Guid.NewGuid();
            idHoaDonChiTiet = Guid.NewGuid();
            if (_lsvHoaDon.Items.Count > 0)
            {
                idHoaDon = new Guid(_lsvHoaDon.Items[0].SubItems[5].Text);
            }
            if (_lsvGioHang.Items.Count > 0)
            {
                idHoaDonChiTiet = new Guid(_lsvGioHang.Items[0].SubItems[4].Text);
            }
            LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
            lvwColumnSorter = new ListViewColumnSorter();
            _lsvShowSanPham.ListViewItemSorter = lvwColumnSorter;
            _lsvHoaDon.ListViewItemSorter = lvwColumnSorter;
            _lsvGioHang.ListViewItemSorter = lvwColumnSorter;
            _cbxPhuongThucMua.SelectedItem = "Mua tại cửa hàng";
            LoadData(idHoaDon);
            LoadDataGioHang(idHoaDonChiTiet);
            _cbxTimKiemHoaDon.SelectedItem = "Tất cả hóa đơn";
            _cbxTimKiemGioHang.SelectedItem = "Tất cả mã giày";
            _cbxTimKiemTenGiay.SelectedItem = "Tất cả tên giày";
            _cbxTimKiemMauSac.SelectedItem = "Tất cả màu sắc";
            _cbxTimKiemHangGiay.SelectedItem = "Tất cả hãng giày";
            hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
            hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().Find(c => c.Id == idHoaDonChiTiet);
            _cbxCheDoXem.SelectedItem = "Tile";
            _cbxCheDoXemGioHang.SelectedItem = "LargeIcon";
            _cbxCheDoXemHoaDon.SelectedItem = "LargeIcon";
            _cbxPhuongThucThanhToan.SelectedItem = "Thanh toán online và tiền mặt";
            _qlChiTietThanhToan = new QLChiTietThanhToan();
            _qlPhuongThucThanhToan = new QlPhuongThucThanhToan();
            idThanhToanOffline = _qlPhuongThucThanhToan.GetAllView().FirstOrDefault(c => c.PhuongThucThanhToan.MaPhuongThucThanhToan == "Offline").PhuongThucThanhToan.Id;
            idThanhToanOnline = _qlPhuongThucThanhToan.GetAllView().FirstOrDefault(c => c.PhuongThucThanhToan.MaPhuongThucThanhToan == "Online").PhuongThucThanhToan.Id;
        }

        private void LoadChiTietGiay(List<ChiTietGiayView> lstChiTietGiayView)
        {
            try
            {
                _lsvShowSanPham.Items.Clear();
                ImageList img = new()
                {
                    ImageSize = new System.Drawing.Size(75, 75)
                };
                foreach (B_BUS.View_Models.ChiTietGiayView item in lstChiTietGiayView)
                {
                    if (item.ChiTietGiay.Anh != null)
                    {
                        img.Images.Add(item.ChiTietGiay.Id.ToString(), Image.FromStream(new MemoryStream(item.ChiTietGiay.Anh)));
                    }
                    else
                    {
                        img.Images.Add(item.ChiTietGiay.Id.ToString(), Properties.Resources.ch__m_c);
                    }
                }
                _lsvShowSanPham.LargeImageList = img;
                foreach (B_BUS.View_Models.ChiTietGiayView item in lstChiTietGiayView)
                {
                    string[] row = { item.Giay.TenGiay, item.MauSac.TenMauSac, item.HangGiay.TenHangGiay, item.Nsx.TenNsx, item.Size.TenSize, item.ChieuCaoDeGiay.MaKichCo, item.ChiTietGiay.GiaBan.ToString(), item.ChiTietGiay.SoLuongTon.ToString(), item.ChiTietGiay.MoTa, item.ChiTietGiay.Id.ToString() };
                    ListViewItem listViewItem = new(row)
                    {
                        ImageKey = item.ChiTietGiay.Id.ToString()
                    };
                    _ = _lsvShowSanPham.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void LoadChiTietHoaDon(List<HoaDonChiTietView> lstHoaDonChiTietView)
        {
            try
            {
                _lsvGioHang.Items.Clear();
                ImageList img = new()
                {
                    ImageSize = new System.Drawing.Size(50, 50)
                };
                foreach (B_BUS.View_Models.HoaDonChiTietView item in lstHoaDonChiTietView)
                {
                    if (item.ChTietGiay.Anh != null)
                    {
                        img.Images.Add(item.ChTietGiay.Id.ToString(), Image.FromStream(new MemoryStream(item.ChTietGiay.Anh)));
                    }
                    else
                    {
                        img.Images.Add(item.ChTietGiay.Id.ToString(), Properties.Resources.ch__m_c);
                    }
                }
                _lsvGioHang.LargeImageList = img;
                foreach (B_BUS.View_Models.HoaDonChiTietView item in lstHoaDonChiTietView)
                {
                    string[] row = { _qlGiay.GetAll().Find(c => c.Id == item.ChTietGiay.IdGiay).MaGiay, item.HoaDonChiTiet.DonGia.ToString(), item.HoaDonChiTiet.SoLuong.ToString(), (item.HoaDonChiTiet.DonGia * item.HoaDonChiTiet.SoLuong).ToString(), item.HoaDonChiTiet.Id.ToString() };
                    ListViewItem listViewItem = new(row)
                    {
                        ImageKey = item.ChTietGiay.Id.ToString()
                    };
                    _ = _lsvGioHang.Items.Add(listViewItem);
                }
                if (_lsvGioHang.Items.Count > 0)
                {
                    idHoaDonChiTiet = new Guid(_lsvGioHang.Items[0].SubItems[4].Text);
                }
                hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().Find(c => c.Id == idHoaDonChiTiet);
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void LoadHoaDon(List<HoaDonView> lstHoaDonView)
        {
            try
            {
                _lsvHoaDon.Items.Clear();
                ImageList img = new()
                {
                    ImageSize = new System.Drawing.Size(50, 50)
                };
                img.Images.Add(Properties.Resources.cart_empty);
                _lsvHoaDon.LargeImageList = img;
                foreach (B_BUS.View_Models.HoaDonView item in lstHoaDonView)
                {
                    string[] row = { item.HoaDon.MaHoaDon, item.HoaDon.PhuongThucMua == 0 ? "Mua tại cửa hàng" : "Đặt hàng online", item.HoaDon.TrangThai == 0 ? "Hóa đơn chờ" : item.HoaDon.TrangThai == 1 ? "Hóa đơn đã thanh toán" : item.HoaDon.TrangThai == 2 ? "Hóa đơn đã ship" : "Hóa đơn đã hủy", item.HoaDon.GhiChu, item.KhachHang == null ? "Khách hàng mới" : item.KhachHang.SoCCCD, item.HoaDon.Id.ToString() };
                    ListViewItem listViewItem = new(row)
                    {
                        ImageIndex = 0
                    };
                    _ = _lsvHoaDon.Items.Add(listViewItem);
                }
                if (_lsvHoaDon.Items.Count > 0)
                {
                    idHoaDon = new Guid(_lsvHoaDon.Items[0].SubItems[5].Text);
                }
                hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void LoadComboBox()
        {
            try
            {
                foreach (Giay item in _qlGiay.GetAll())
                {
                    _ = _cbxTimKiemGioHang.Items.Add(item.MaGiay);
                }
                foreach (Giay item in _qlGiay.GetAll())
                {
                    _ = _cbxTimKiemTenGiay.Items.Add(item.TenGiay);
                }
                foreach (MauSac item in _qlMauSac.GetAll())
                {
                    _ = _cbxTimKiemMauSac.Items.Add(item.TenMauSac);
                }
                foreach (HangGiay item in _qlHangGiay.GetAll())
                {
                    _ = _cbxTimKiemHangGiay.Items.Add(item.TenHangGiay);
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (_tbxTenKhachHang.Texts.Trim() == "" && _tbxDiaChi.Texts.Trim() == "" && _tbxSoDienThoai.Texts.Trim() == "" && _tbxCMND.Texts.Trim() == "" && _tbxEmail.Texts.Trim() == "")
                {
                    string maHoaDon = "HD0";
                    if (_qlHoaDon.GetAll().Count > 0)
                    {
                        maHoaDon = "HD" + _qlHoaDon.GetAll().Max(c => Convert.ToInt32(c.MaHoaDon[2..]) + 1);
                    }
                    Guid idNhanVien = TrangChu.NhanVienLogin.Id;
                    int phuongThucMua = _cbxPhuongThucMua.SelectedItem.ToString() == "Đặt hàng online" ? 1 : 0;
                    bool thongBao = _qlHoaDon.Add(new HoaDon() { MaHoaDon = maHoaDon, IdKhachHang = null, IdNhanVien = idNhanVien, PhuongThucMua = phuongThucMua });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Thêm thành công");
                        LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                    }
                }
                else
                {
                    if (_tbxCMND.Texts.Trim() != "")
                    {
                        string? tenKhachHang = _tbxTenKhachHang.Texts.Trim() == "" ? null : _tbxTenKhachHang.Texts.Trim();
                        DateTime ngaySinh = _dtpNgaySinh.Value;
                        string? diaChi = _tbxDiaChi.Texts.Trim() == "" ? null : _tbxDiaChi.Texts.Trim();
                        string? soDienThoai = _tbxSoDienThoai.Texts.Trim() == "" ? null : _tbxSoDienThoai.Texts.Trim();
                        string cmnd = _tbxCMND.Texts.Trim();
                        string? email = _tbxEmail.Text.Trim() == "" ? null : _tbxEmail.Text.Trim();
                        if (_qlKhachHang.GetAll().Any(c => c.SoCCCD == cmnd))
                        {
                            _ = MessageBox.Show("Khách hàng cũ. Thông tin khách hàng sẽ được chỉnh sửa");
                            KhachHang khachHang = _qlKhachHang.GetAll().FirstOrDefault(c => c.SoCCCD == cmnd);
                            khachHang.TenKhachHang = tenKhachHang;
                            khachHang.DiaChi = diaChi;
                            khachHang.Sdt = soDienThoai;
                            khachHang.Email = email;
                            khachHang.NgaySinh = ngaySinh;
                            _ = _qlKhachHang.Update(khachHang);
                        }
                        else
                        {
                            _ = MessageBox.Show("Khách hàng mới. Khách hàng sẽ được thêm");
                            string maKhachHang = "KH0";
                            if (_qlKhachHang.GetAll().Count > 0)
                            {
                                maKhachHang = "KH" + _qlKhachHang.GetAll().Max(c => Convert.ToInt32(c.MaKhachHang[2..]) + 1);
                            }
                            _ = _qlKhachHang.Add(new KhachHang() { MaKhachHang = maKhachHang, TenKhachHang = tenKhachHang, NgaySinh = ngaySinh, DiaChi = diaChi, Sdt = soDienThoai, SoCCCD = cmnd, Email = email });
                        }
                        string maHoaDon = "HD0";
                        if (_qlHoaDon.GetAll().Count > 0)
                        {
                            maHoaDon = "HD" + _qlHoaDon.GetAll().Max(c => Convert.ToInt32(c.MaHoaDon[2..]) + 1);
                        }
                        Guid idKhachHang = _qlKhachHang.GetAll().FirstOrDefault(c => c.SoCCCD == _tbxCMND.Texts.Trim().ToString()).Id;
                        Guid idNhanVien = TrangChu.NhanVienLogin.Id;
                        int phuongThucMua = _cbxPhuongThucMua.SelectedItem.ToString() == "Đặt hàng online" ? 1 : 0;
                        bool thongBao = _qlHoaDon.Add(new HoaDon() { MaHoaDon = maHoaDon, IdKhachHang = idKhachHang, IdNhanVien = idNhanVien, PhuongThucMua = phuongThucMua });
                        if (thongBao)
                        {
                            _ = MessageBox.Show("Thêm thành công");
                            LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                        }
                    }
                    else
                    {
                        _ = MessageBox.Show("Số chứng minh nhân dân không được để trống");
                    }
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _lsvShowSanPham_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (hoaDon != null)
                {
                    if (hoaDon.TrangThai == 0)
                    {
                        if (_lsvShowSanPham.SelectedItems.Count > 0)
                        {
                            Guid idGiay = new(_lsvShowSanPham.SelectedItems[0].SubItems[9].Text);
                            ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == idGiay);
                            HoaDonChiTiet? hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().FirstOrDefault(c => c.IdHoaDon == idHoaDon && c.IdChiTietGiay == idGiay);
                            List<ChiTietSale> lstChiTietSale = _qlChiTietSale.GetAll().Where(c => c.IdChiTietGiay == idGiay).ToList();
                            float phanTramGiam = 0;
                            float soTienGiam = 0;
                            foreach (ChiTietSale item in lstChiTietSale)
                            {
                                Sale sale = _qlSale.GetAll().FirstOrDefault(c => c.Id == item.IdSale);
                                if (sale.NgayKetThuc > DateTime.Now && sale.NgayBatDau < DateTime.Now)
                                {
                                    phanTramGiam += sale.PhanTramGiamGia;
                                    soTienGiam += sale.SoTiemGiamGia;
                                }
                            }
                            float donGia = (chiTietGiay.GiaBan * (100 - phanTramGiam) / 100) - soTienGiam;
                            if (donGia < 0)
                            {
                                donGia = 0;
                            }
                            if (hoaDonChiTiet == null)
                            {
                                _ = _qlHoaDonChiTiet.Add(new HoaDonChiTiet() { IdHoaDon = idHoaDon, IdChiTietGiay = idGiay, SoLuong = 1, DonGia = donGia });
                            }
                            else
                            {
                                hoaDonChiTiet.SoLuong++;
                                chiTietGiay.SoLuongTon--;
                                _ = _qlChiTietGiay.Update(chiTietGiay);
                                _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                                LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
                            }
                            LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                            LoadData(idHoaDon);
                            LoadDataGioHang(idHoaDonChiTiet);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _lsvHoaDon_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (_lsvHoaDon.SelectedItems.Count > 0)
                {
                    idHoaDon = new Guid(_lsvHoaDon.SelectedItems[0].SubItems[5].Text);
                    hoaDon = _qlHoaDon.GetAll().Find(c => c.Id == idHoaDon);
                    LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                    LoadData(idHoaDon);
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _lsvGioHang_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (hoaDon != null)
                {
                    if (hoaDon.TrangThai == 0)
                    {
                        Guid idHoaDonChiTiet = new(_lsvGioHang.SelectedItems[0].SubItems[4].Text);
                        HoaDonChiTiet hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().Find(c => c.Id == idHoaDonChiTiet);
                        ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == hoaDonChiTiet.IdChiTietGiay);
                        if (hoaDonChiTiet.SoLuong > 1)
                        {
                            hoaDonChiTiet.SoLuong--;
                            _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                        }
                        else
                        {
                            _ = _qlHoaDonChiTiet.Delete(hoaDonChiTiet);
                        }
                        chiTietGiay.SoLuongTon++;
                        _ = _qlChiTietGiay.Update(chiTietGiay);
                        LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                        LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
                        LoadData(idHoaDon);
                    }
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    float giamGia = Convert.ToSingle(_tbxGiamGia.Texts.Trim());
                    float tienKhachDua = Convert.ToSingle(_tbxTienKhachDua.Texts.Trim());
                    float thanhToanOnline = Convert.ToSingle(_tbxThanhToanOnline.Texts.Trim());

                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                    return;
                }
                if (hoaDon != null)
                {
                    if (hoaDon.TrangThai is not 1 and not (-1))
                    {
                        if (Convert.ToSingle(_tbxTienThua.Texts.Trim()) >= 0)
                        {

                            if (hoaDon.PhuongThucMua == 1 && hoaDon.TrangThai != 2)
                            {
                                DialogResult result = MessageBox.Show("Đây là hóa đơn đặt hàng online khi thanh toán sẽ thực hiện ship cho khách. Hãy chắc chắn rằng khách hàng đã đồng ý với các điều khoản của cửa hàng về sản phẩm và đồng ý với phí ship đã định", "Thông báo", MessageBoxButtons.OKCancel);
                                if (result == DialogResult.OK)
                                {
                                    hoaDon.TrangThai = 1;
                                    hoaDon.ThoiGianThanhToan = DateTime.Now;
                                    hoaDon.GiamGia = Convert.ToSingle(_tbxGiamGia.Texts.Trim());
                                    hoaDon.GhiChu = _tbxGhiChu.Texts.Trim();
                                    _qlChiTietThanhToan.Add(new ChiTietThanhToan() { IdHoaDon = hoaDon.Id, IdPhuongThucThanhToan = idThanhToanOnline, SoTienThanhToan = Convert.ToSingle(_tbxThanhToanOnline.Texts.Trim()) });
                                    _qlChiTietThanhToan.Add(new ChiTietThanhToan() { IdHoaDon = hoaDon.Id, IdPhuongThucThanhToan = idThanhToanOffline, SoTienThanhToan = Convert.ToSingle(_tbxTienKhachDua.Texts.Trim()) });
                                    _ = _qlHoaDon.Update(hoaDon);
                                    _ = MessageBox.Show("Thanh toán thành công");
                                    LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                                    return;
                                }
                            }
                            hoaDon.TrangThai = 1;
                            hoaDon.ThoiGianThanhToan = DateTime.Now;
                            hoaDon.GiamGia = Convert.ToSingle(_tbxGiamGia.Texts.Trim());
                            hoaDon.GhiChu = _tbxGhiChu.Texts.Trim();
                            hoaDon.TongSoTien = Convert.ToSingle(_tbxTongTien.Texts.Trim());
                            _qlChiTietThanhToan.Add(new ChiTietThanhToan() { IdHoaDon = hoaDon.Id, IdPhuongThucThanhToan = idThanhToanOnline, SoTienThanhToan = Convert.ToSingle(_tbxThanhToanOnline.Texts.Trim()) });
                            _qlChiTietThanhToan.Add(new ChiTietThanhToan() { IdHoaDon = hoaDon.Id, IdPhuongThucThanhToan = idThanhToanOffline, SoTienThanhToan = Convert.ToSingle(_tbxTienKhachDua.Texts.Trim()) });
                            _ = _qlHoaDon.Update(hoaDon);
                            _ = MessageBox.Show("Thanh toán thành công");
                            LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void LoadData(Guid? idHoaDon)
        {
            try
            {
                if (hoaDon != null)
                {
                    _tbxMaHoaDon.Texts = hoaDon.MaHoaDon;
                    float tongTien = 0;
                    foreach (HoaDonChiTiet? item in _qlHoaDonChiTiet.GetAll().Where(c => c.IdHoaDon == idHoaDon))
                    {
                        tongTien += item.SoLuong * item.DonGia;
                    }
                    _tbxTongTien.Texts = tongTien.ToString();
                    _tbxTienKhachDua.Texts = "0";
                    _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts.Trim()) - Convert.ToSingle(_tbxTongTien.Texts.Trim())).ToString();
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void LoadDataGioHang(Guid? idhoaDonChiTiet)
        {
            try
            {
                if (hoaDonChiTiet != null)
                {
                    _tbxDonGia.Texts = hoaDonChiTiet.DonGia.ToString();
                    _tbxSoLuong.Texts = hoaDonChiTiet.SoLuong.ToString();
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _lsvShowSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                _lsvShowSanPham.Sort();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _lsvGioHang_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                _lsvGioHang.Sort();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _lsvHoaDon_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            try
            {
                // Determine if clicked column is already the column that is being sorted.
                if (e.Column == lvwColumnSorter.SortColumn)
                {
                    // Reverse the current sort direction for this column.
                    lvwColumnSorter.Order = lvwColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                }
                else
                {
                    // Set the column number that is to be sorted; default to ascending.
                    lvwColumnSorter.SortColumn = e.Column;
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }

                // Perform the sort with these new sort options.
                _lsvHoaDon.Sort();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }

        }

        private void _btnShipHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (hoaDon != null)
                {
                    if (hoaDon.TrangThai == 0)
                    {
                        if (hoaDon.PhuongThucMua == 1)
                        {
                            DialogResult result = MessageBox.Show("Hãy chắc chắn rằng khách hàng đã đồng ý với các điều khoản của cửa hàng về sản phẩm và đồng ý với phí ship đã định", "Thông báo", MessageBoxButtons.OKCancel);
                            if (result == DialogResult.OK)
                            {
                                hoaDon.ThoiGianShip = DateTime.Now;
                                hoaDon.TrangThai = 2;
                                _ = _qlHoaDon.Update(hoaDon);
                                _ = MessageBox.Show("Đã gửi yêu cầu ship hàng hóa đơn này");
                                LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                            }
                        }
                        else
                        {
                            _ = MessageBox.Show("Hóa đơn mua tại cửa hàng không cần ship");
                        }
                    }
                    else
                    {
                        _ = MessageBox.Show("Đơn hàng đã ship");
                    }
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _tbxTienKhachDua__TextChanged(object sender, EventArgs e)
        {
            try
            {
                float tienKhachDua;
                try
                {
                    tienKhachDua = Convert.ToSingle(_tbxTienKhachDua.Texts.Trim());
                }
                catch (Exception)
                {
                    tienKhachDua = 0;
                }
                _tbxTienThua.Texts = (tienKhachDua + Convert.ToSingle(_tbxThanhToanOnline.Texts.Trim()) - Convert.ToSingle(_tbxTongTien.Texts.Trim())).ToString();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _tbxGiamGia__TextChanged(object sender, EventArgs e)
        {
            try
            {
                float giamGia = 0;
                try
                {
                    giamGia = Convert.ToSingle(_tbxGiamGia.Texts.Trim());
                }
                catch (Exception)
                {
                    giamGia = 0;
                }
                float tongTien = 0;
                foreach (HoaDonChiTiet? item in _qlHoaDonChiTiet.GetAll().Where(c => c.IdHoaDon == idHoaDon))
                {
                    tongTien += item.SoLuong * item.DonGia;
                }
                _tbxTongTien.Texts = tongTien.ToString();
                _tbxTongTien.Texts = (Convert.ToSingle(_tbxTongTien.Texts.Trim()) - giamGia).ToString();
                _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts.Trim()) + Convert.ToSingle(_tbxThanhToanOnline.Texts.Trim()) - Convert.ToSingle(_tbxTongTien.Texts.Trim())).ToString();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void LocHoaDon()
        {
            try
            {
                int trangThai = _cbxTimKiemHoaDon.SelectedItem == "Tất cả hóa đơn" ? -2 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn chờ" ? 0 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn đã ship" ? 2 : _cbxTimKiemHoaDon.SelectedItem == "Hóa đơn đã thanh toán" ? 1 : -1;
                List<HoaDonView> lstHoaDonView = _qlHoaDon.GetAllView();
                if (trangThai != -2)
                {
                    lstHoaDonView = lstHoaDonView.Where(c => c.HoaDon.TrangThai == trangThai).ToList();
                }
                if (_tbxKhachHnag.Texts.Trim() != "")
                {
                    lstHoaDonView = lstHoaDonView.Where(c => c.KhachHang.SoCCCD.ToUpper().Contains(_tbxKhachHnag.Texts.Trim().ToUpper())).ToList();
                }
                LoadHoaDon(lstHoaDonView);
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxTimKiemHoaDon_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocHoaDon();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxTimKiemGioHang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string maGiay = _cbxTimKiemGioHang.SelectedItem == "Tất cả mã giày" ? "-1" : _cbxTimKiemGioHang.SelectedItem.ToString();
                if (maGiay == "-1")
                {
                    LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                }
                else
                {
                    LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon && _qlGiay.GetAll().Find(d => d.Id == c.ChTietGiay.IdGiay).MaGiay == maGiay).ToList());
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void LocChiTietGiay()
        {
            try
            {
                if (_cbxTimKiemTenGiay.SelectedItem == null || _cbxTimKiemMauSac.SelectedItem == null || _cbxTimKiemHangGiay.SelectedItem == null)
                {
                    return;
                }
                List<ChiTietGiayView> lstChiTietGiayView = _qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList();
                string tenGiay = _cbxTimKiemTenGiay.SelectedItem == "Tất cả tên giày" ? "-1" : _cbxTimKiemTenGiay.SelectedItem.ToString();
                if (tenGiay != "-1")
                {
                    lstChiTietGiayView = lstChiTietGiayView.Where(c => c.Giay.TenGiay == tenGiay).ToList();
                }
                string tenMauSac = _cbxTimKiemMauSac.SelectedItem == "Tất cả màu sắc" ? "-1" : _cbxTimKiemMauSac.SelectedItem.ToString();
                if (tenMauSac != "-1")
                {
                    lstChiTietGiayView = lstChiTietGiayView.Where(c => c.MauSac.TenMauSac == tenMauSac).ToList();
                }
                string tenHangGiay = _cbxTimKiemHangGiay.SelectedItem == "Tất cả hãng giày" ? "-1" : _cbxTimKiemHangGiay.SelectedItem.ToString();
                if (tenHangGiay != "-1")
                {
                    lstChiTietGiayView = lstChiTietGiayView.Where(c => c.HangGiay.TenHangGiay == tenHangGiay).ToList();
                }
                LoadChiTietGiay(lstChiTietGiayView);
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxTimKiemTenGiay_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocChiTietGiay();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxTimKiemMauSac_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocChiTietGiay();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxTimKiemHangGiay_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocChiTietGiay();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _btnBoLoc_Click(object sender, EventArgs e)
        {
            try
            {
                _cbxTimKiemTenGiay.SelectedItem = "Tất cả tên giày";
                _cbxTimKiemMauSac.SelectedItem = "Tất cả màu sắc";
                _cbxTimKiemHangGiay.SelectedItem = "Tất cả hãng giày";
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _btnHuyHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                if (hoaDon != null)
                {
                    if (hoaDon.TrangThai is not 1 and not (-1))
                    {
                        hoaDon.TrangThai = -1;
                        _ = _qlHoaDon.Update(hoaDon);
                        _ = MessageBox.Show("Đã hủy hóa đơn");
                        LoadHoaDon(_qlHoaDon.GetAllView().ToList());
                    }
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _tbxKhachHnag__TextChanged(object sender, EventArgs e)
        {
            try
            {
                LocHoaDon();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _tbxThanhToanOnline__TextChanged(object sender, EventArgs e)
        {
            try
            {
                float thanhToanOnline;
                try
                {
                    thanhToanOnline = Convert.ToSingle(_tbxThanhToanOnline.Texts.Trim());
                }
                catch (Exception)
                {
                    thanhToanOnline = 0;
                }
                _tbxTienThua.Texts = (Convert.ToSingle(_tbxTienKhachDua.Texts.Trim()) + thanhToanOnline - Convert.ToSingle(_tbxTongTien.Texts.Trim())).ToString();
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxCheDoXem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_cbxCheDoXem.SelectedItem.ToString() == "Tile")
                {
                    _lsvShowSanPham.View = View.Tile;
                }
                else if (_cbxCheDoXem.SelectedItem.ToString() == "List")
                {
                    _lsvShowSanPham.View = View.List;
                }
                else if (_cbxCheDoXem.SelectedItem.ToString() == "SmallIcon")
                {
                    _lsvShowSanPham.View = View.SmallIcon;
                }
                else if (_cbxCheDoXem.SelectedItem.ToString() == "Details")
                {
                    _lsvShowSanPham.View = View.Details;
                }
                else if (_cbxCheDoXem.SelectedItem.ToString() == "LargeIcon")
                {
                    _lsvShowSanPham.View = View.LargeIcon;
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxPhuongThucThanhToan_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_cbxPhuongThucThanhToan.SelectedItem.ToString() == "Thanh toán online và tiền mặt")
                {
                    _tbxTienKhachDua.Enabled = true;
                    _tbxThanhToanOnline.Enabled = true;
                }
                else if (_cbxPhuongThucThanhToan.SelectedItem.ToString() == "Thanh toán tiền mặt")
                {
                    _tbxTienKhachDua.Enabled = true;
                    _tbxThanhToanOnline.Enabled = false;
                    _tbxThanhToanOnline.Texts = "0";
                }
                else if (_cbxPhuongThucThanhToan.SelectedItem.ToString() == "Thanh toán online")
                {
                    _tbxTienKhachDua.Enabled = false;
                    _tbxThanhToanOnline.Enabled = true;
                    _tbxTienKhachDua.Texts = "0";
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxCheDoXemGioHang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_cbxCheDoXemGioHang.SelectedItem.ToString() == "Tile")
                {
                    _lsvGioHang.View = View.Tile;
                }
                else if (_cbxCheDoXemGioHang.SelectedItem.ToString() == "List")
                {
                    _lsvGioHang.View = View.List;
                }
                else if (_cbxCheDoXemGioHang.SelectedItem.ToString() == "SmallIcon")
                {
                    _lsvGioHang.View = View.SmallIcon;
                }
                else if (_cbxCheDoXemGioHang.SelectedItem.ToString() == "Details")
                {
                    _lsvGioHang.View = View.Details;
                }
                else if (_cbxCheDoXemGioHang.SelectedItem.ToString() == "LargeIcon")
                {
                    _lsvGioHang.View = View.LargeIcon;
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _cbxCheDoXemHoaDon_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_cbxCheDoXemHoaDon.SelectedItem.ToString() == "Tile")
                {
                    _lsvHoaDon.View = View.Tile;
                }
                else if (_cbxCheDoXemHoaDon.SelectedItem.ToString() == "List")
                {
                    _lsvHoaDon.View = View.List;
                }
                else if (_cbxCheDoXemHoaDon.SelectedItem.ToString() == "SmallIcon")
                {
                    _lsvHoaDon.View = View.SmallIcon;
                }
                else if (_cbxCheDoXemHoaDon.SelectedItem.ToString() == "Details")
                {
                    _lsvHoaDon.View = View.Details;
                }
                else if (_cbxCheDoXemHoaDon.SelectedItem.ToString() == "LargeIcon")
                {
                    _lsvHoaDon.View = View.LargeIcon;
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _lsvGioHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_lsvGioHang.SelectedItems.Count > 0)
                {
                    idHoaDonChiTiet = new Guid(_lsvGioHang.SelectedItems[0].SubItems[4].Text);
                    hoaDonChiTiet = _qlHoaDonChiTiet.GetAll().Find(c => c.Id == idHoaDonChiTiet);
                    LoadDataGioHang(idHoaDonChiTiet);
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _btnSuaChiTietHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    float donGia = Convert.ToSingle(_tbxDonGia.Texts.Trim());
                    int soLuong = Convert.ToInt32(_tbxSoLuong.Texts.Trim());

                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                    return;
                }
                if (Convert.ToInt32(_tbxSoLuong.Texts.Trim()) == 0)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc số lượng là 0", "Thông báo", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == hoaDonChiTiet.IdChiTietGiay);
                        chiTietGiay.SoLuongTon += hoaDonChiTiet.SoLuong;
                        _ = _qlChiTietGiay.Update(chiTietGiay);
                        _ = _qlHoaDonChiTiet.Delete(hoaDonChiTiet);
                        LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                        LoadData(idHoaDon);
                        LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
                        return;
                    }
                }
                if (hoaDonChiTiet != null)
                {
                    ChiTietGiay? chiTietGiay = _qlChiTietGiay.GetAll().FirstOrDefault(c => c.Id == hoaDonChiTiet.IdChiTietGiay);
                    chiTietGiay.SoLuongTon += hoaDonChiTiet.SoLuong - Convert.ToInt32(_tbxSoLuong.Texts.Trim());
                    if (chiTietGiay.SoLuongTon < 0)
                    {
                        return;
                    }

                    _ = _qlChiTietGiay.Update(chiTietGiay);
                    hoaDonChiTiet.DonGia = Convert.ToSingle(_tbxDonGia.Texts.Trim());
                    hoaDonChiTiet.SoLuong = Convert.ToInt32(_tbxSoLuong.Texts.Trim());
                    _ = _qlHoaDonChiTiet.Update(hoaDonChiTiet);
                    LoadChiTietHoaDon(_qlHoaDonChiTiet.GetAllView().Where(c => c.HoaDonChiTiet.IdHoaDon == idHoaDon).ToList());
                    LoadData(idHoaDon);
                    LoadChiTietGiay(_qlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList());
                    _ = MessageBox.Show("Sửa thành công");
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(ex.Message);
            }
        }
    }
}
