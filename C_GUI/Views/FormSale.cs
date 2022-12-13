using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;
using System.Data;

namespace C_GUI.QLForm
{
    public partial class FormSale : Form
    {
        public IQLSale _IQlSale;
        public IQLChiTietSale _IQlChiTietSale;
        public IQLGiay _IQlGiay;
        public IQLChiTietGiay _IQlChiTietGiay;
        public IQLHangGiay _IQlHangGiay;
        public IQLMauSac _IQlMauSac;
        public IQLNsx _IQlNsx;
        private Guid _ID;
        public FormSale()
        {
            InitializeComponent();
            _IQlSale = new QLSale();
            _IQlChiTietSale = new QLChiTietSale();
            _IQlChiTietGiay = new QLChiTietGiay();
            _IQlGiay = new QLGiay();
            _IQlHangGiay = new QLHangGiay();
            _IQlMauSac = new QLMauSac();
            _IQlNsx = new QLNsx();
            txt_ptgiam.Texts = "0";
            txt_sotiengiam.Texts = "0";
            LoadData(_IQlSale.GetAllView());
            LoadDataSP();
            Loadcmb();
            LoadDataSP2(_IQlChiTietGiay.GetAllView());
        }
        public void Loadcmb()
        {
            try
            {
                cmb_giay.Items.Clear();
                cmb_sale.Items.Clear();
                cmb_hanggiay.Items.Clear();
                cmb_mausac.Items.Clear();

                _ = cmb_giay.Items.Add("Tất cả tên giày");
                _ = cmb_hanggiay.Items.Add("Tất cả hãng giày");
                _ = cmb_mausac.Items.Add("Tất cả màu sắc");

                foreach (Sale a in _IQlSale.GetAll())
                {
                    _ = cmb_sale.Items.Add(a.TenChuongTrinh);
                }

                foreach (Giay a in _IQlGiay.GetAll())
                {
                    _ = cmb_giay.Items.Add(a.TenGiay);
                }
                foreach (HangGiay a in _IQlHangGiay.GetAll())
                {
                    _ = cmb_hanggiay.Items.Add(a.TenHangGiay);
                }

                foreach (MauSac a in _IQlMauSac.GetAll())
                {
                    _ = cmb_mausac.Items.Add(a.TenMauSac);
                }

                cmb_giay.SelectedIndex = 0;
                cmb_hanggiay.SelectedIndex = 0;
                cmb_mausac.SelectedIndex = 0;

            }
            catch (Exception)
            {
                _ = MessageBox.Show("hãy kiểm tra lại Cmb");
            }




        }
        public void LoadData(List<SaleView> saleViews)
        {
            int stt = 1;
            dgrid_show.ColumnCount = 9;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "mã giảm giá";
            dgrid_show.Columns[3].Name = "tên chương trình ";
            dgrid_show.Columns[4].Name = "% giảm giá";
            dgrid_show.Columns[5].Name = "số tiền giảm";
            dgrid_show.Columns[6].Name = "ngày bắt đầu";
            dgrid_show.Columns[7].Name = "ngày kết thúc";
            dgrid_show.Columns[8].Name = "trạng thái";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = false;
            foreach (SaleView a in saleViews)
            {
                _ = dgrid_show.Rows.Add(stt++, a.Sale.Id, a.Sale.MaGiamGia, a.Sale.TenChuongTrinh, a.Sale.PhanTramGiamGia, a.Sale.SoTiemGiamGia, a.Sale.NgayBatDau, a.Sale.NgayKetThuc, (a.Sale.NgayBatDau <= DateTime.Now && a.Sale.NgayKetThuc >= DateTime.Now) ? "hoat dong" : "khong hoat dong");
            }
        }




        public void LoadDataSP()
        {
            int stt = 1;
            dgrid_showsanpham.ColumnCount = 12;
            dgrid_showsanpham.Columns[0].Name = "stt";
            dgrid_showsanpham.Columns[1].Name = "tên chương trình ";
            dgrid_showsanpham.Columns[2].Name = "Giá bán";
            dgrid_showsanpham.Columns[3].Name = "Giá Khuyến mại";
            dgrid_showsanpham.Columns[4].Name = "Màu sắc";
            dgrid_showsanpham.Columns[5].Name = "Tên giày";
            dgrid_showsanpham.Columns[6].Name = "Giá nhập";
            dgrid_showsanpham.Columns[7].Name = "Số lượng tồn";
            dgrid_showsanpham.Columns[8].Name = "Hãng giày";
            dgrid_showsanpham.Columns[9].Name = "NSX";
            dgrid_showsanpham.Columns[10].Name = "trạng thái";
            dgrid_showsanpham.Columns[11].Name = "id";

            dgrid_showsanpham.Rows.Clear();
            foreach (ChiTietGiayView a in _IQlChiTietGiay.GetAllViewSale())
            {
                ChiTietSaleView? b = _IQlChiTietSale.GetAllView().Find(c => c.ChiTietSale.IdChiTietGiay == a.ChiTietGiay.Id);
                SaleView? c = _IQlSale.GetAllView().Find(c => c.Sale.Id == b.ChiTietSale.IdSale);
                //var c = _IQlChiTietSale.GetAllView().Find(c => c.ChiTietSale.IdSale == b.Sale.Id);
                _ = dgrid_showsanpham.Rows.Add(stt++, c.Sale.TenChuongTrinh, a.ChiTietGiay.GiaBan, a.ChiTietGiay.GiaBan - (a.ChiTietGiay.GiaBan * (c.Sale.PhanTramGiamGia / 100)) - c.Sale.SoTiemGiamGia, a.MauSac.TenMauSac, a.Giay.TenGiay, a.ChiTietGiay.GiaNhap, a.ChiTietGiay.SoLuongTon, a.HangGiay.TenHangGiay, a.Nsx.TenNsx, (c.Sale.NgayBatDau <= DateTime.Now && c.Sale.NgayKetThuc >= DateTime.Now) ? "hoat dong" : "khong hoat dong", b.ChiTietSale.Id);
            }
        }
        public void LoadDataSP2(List<ChiTietGiayView> chiTietGiayViews)
        {
            int stt = 1;
            dgrid_SP.ColumnCount = 9;
            dgrid_SP.Columns[0].Name = "stt";
            dgrid_SP.Columns[1].Name = "Giá bán";
            dgrid_SP.Columns[2].Name = "Màu sắc";
            dgrid_SP.Columns[3].Name = "Tên giày";
            dgrid_SP.Columns[4].Name = "Giá nhập";
            dgrid_SP.Columns[5].Name = "Số lượng tồn";
            dgrid_SP.Columns[6].Name = "Hãng giày";
            dgrid_SP.Columns[7].Name = "NSX";
            dgrid_SP.Columns[8].Name = "id";
            dgrid_SP.Columns[8].Visible = true;
            dgrid_SP.Rows.Clear();
            foreach (ChiTietGiayView a in chiTietGiayViews)
            {
                //var c = _IQlChiTietSale.GetAllView().Find(c => c.ChiTietSale.IdSale == b.Sale.Id);
                _ = dgrid_SP.Rows.Add(stt++, a.ChiTietGiay.GiaBan, a.MauSac.TenMauSac, a.Giay.TenGiay, a.ChiTietGiay.GiaNhap, a.ChiTietGiay.SoLuongTon, a.HangGiay.TenHangGiay, a.Nsx.TenNsx, a.ChiTietGiay.Id);
            }
        }
        public Sale GetvaluaContro()
        {
            return new Sale()
            {
                MaGiamGia = txt_ma.Texts,
                TenChuongTrinh = txt_ten.Texts,
                PhanTramGiamGia = float.Parse(txt_ptgiam.Texts),
                SoTiemGiamGia = float.Parse(txt_sotiengiam.Texts),
                NgayBatDau = dtp_ngaybatdau.Value,
                NgayKetThuc = dtp_ngayketthuc.Value,
                TrangThai = (dtp_ngaybatdau.Value <= DateTime.Now && dtp_ngayketthuc.Value >= DateTime.Now) ? 0 : 1,
            };
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                float giamGia = Convert.ToSingle(txt_ptgiam.Texts);
                float tienKhachDua = Convert.ToSingle(txt_sotiengiam.Texts);
                ;
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                return;
            }

            try
            {
                if (dtp_ngaybatdau.Value < DateTime.Today || dtp_ngayketthuc.Value < dtp_ngaybatdau.Value)
                {
                    _ = MessageBox.Show("Kiểm tra lại lịch");
                    return;
                }


                if (int.Parse(txt_ptgiam.Texts) is < 0 or > 100)
                {
                    _ = MessageBox.Show("Kiểm tra lại số %");
                    return;
                }

                if (txt_ma.Texts == null || txt_ten.Texts == null || txt_ptgiam.Texts == null || txt_sotiengiam.Texts == null)
                {
                    _ = MessageBox.Show("Kiểm tra lại thoonh tin nhập");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {


                    _ = _IQlSale.Add(GetvaluaContro());
                    LoadData(_IQlSale.GetAllView());
                    LoadDataSP();
                    Loadcmb();

                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Đã tồn tại hãy kiểm tra lại");
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtp_ngaybatdau.Value < DateTime.Now || dtp_ngayketthuc.Value < dtp_ngaybatdau.Value)
                {
                    _ = MessageBox.Show("Kiểm tra lại lịch");
                    return;
                }
                if (int.Parse(txt_ptgiam.Texts) is < 0 or > 100)
                {
                    _ = MessageBox.Show("Kiểm tra lại số %");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool thongBao = _IQlSale.Update(new A_DAL.Entities.Sale() { Id = _ID, MaGiamGia = txt_ma.Texts, TenChuongTrinh = txt_ten.Texts, PhanTramGiamGia = float.Parse(txt_ptgiam.Texts), SoTiemGiamGia = float.Parse(txt_sotiengiam.Texts), NgayBatDau = dtp_ngaybatdau.Value, NgayKetThuc = dtp_ngayketthuc.Value, TrangThai = (dtp_ngaybatdau.Value <= DateTime.Now && dtp_ngayketthuc.Value >= DateTime.Now) ? 0 : 1 });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Sửa thành công");
                        LoadData(_IQlSale.GetAllView());
                        LoadDataSP();
                        Loadcmb();

                    }
                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool thongBao = _IQlSale.Delete(_IQlSale.GetAll().Find(c => c.Id == _ID));

                    if (thongBao)
                    {
                        _ = MessageBox.Show("Xóa thành công");
                        LoadData(_IQlSale.GetAllView()); LoadDataSP();
                        Loadcmb();

                    }
                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
                txt_ma.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
                txt_ten.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
                txt_ptgiam.Texts = dgrid_show.Rows[index].Cells[4].Value.ToString();
                txt_sotiengiam.Texts = dgrid_show.Rows[index].Cells[5].Value.ToString();
                dtp_ngaybatdau.Value = DateTime.Parse(dgrid_show.Rows[index].Cells[6].Value.ToString());
                dtp_ngayketthuc.Value = DateTime.Parse(dgrid_show.Rows[index].Cells[7].Value.ToString());
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }


        }

        private void txt_timkiem__TextChanged(object sender, EventArgs e)
        {
            LoadData(_IQlSale.GetAllView().Where(c => c.Sale.TenChuongTrinh.ToLower().Contains(txt_timkiem.Texts.ToLower()) || c.Sale.MaGiamGia.ToLower().Contains(txt_timkiem.Texts.ToLower())).ToList());
        }
        public List<ChiTietSale> GetvaluaControSALE()
        {

            List<ChiTietSale> chiTietSales;
            chiTietSales = new List<ChiTietSale>();
            SaleView? x = _IQlSale.GetAllView().FirstOrDefault(c => c.Sale.TenChuongTrinh == cmb_sale.Texts);

            //foreach (DataGridViewRow a in dgrid_SP.Rows)
            //{
            //    chiTietSales.Add(new ChiTietSale()
            //    {
            //          IdSale = x.Sale.Id,
            //         IdChiTietGiay = Guid.NewGuid(a.Cells[8].Value.ToString())
            //    });

            //}

            for (int i = 0; i < dgrid_SP.Rows.Count; i++)
            {
                Guid IDChitietGiay = new(dgrid_SP.Rows[i].Cells[8].Value.ToString());
                chiTietSales.Add(new ChiTietSale()
                {
                    IdSale = x.Sale.Id,
                    IdChiTietGiay = IDChitietGiay
                });

            }

            return chiTietSales;

            #region a




            //var x = _IQlSale.GetAllView().FirstOrDefault(c => c.Sale.TenChuongTrinh == cmb_sale.Texts);

            //var y = _IQlGiay.GetAllView().FirstOrDefault(c => c.Giay.TenGiay == cmb_giay.Texts);

            //var hg = _IQlHangGiay.GetAllView().FirstOrDefault(c => c.HangGiay.TenHangGiay == cmb_hanggiay.Texts);

            //var ms = _IQlMauSac.GetAllView().FirstOrDefault(c => c.MauSac.TenMauSac == cmb_mausac.Texts);

            //var nsx = _IQlNsx.GetAllView().FirstOrDefault(c => c.Nsx.TenNsx == cmb_nsx.Texts);
            //if (
            //    y!=null&&
            //    hg != null&&
            //    ms != null&& 
            //    nsx!=null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    & c.ChiTietGiay.IdHangGiay == hg.HangGiay.Id
            //                                                    & c.ChiTietGiay.IdMauSac == ms.MauSac.Id
            //                                                    & c.ChiTietGiay.IdNsx == nsx.Nsx.Id);

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y != null &&
            //    hg == null &&
            //    ms == null &&
            //    nsx == null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    );

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y == null &&
            //    hg != null &&
            //    ms == null &&
            //    nsx == null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdHangGiay == hg.HangGiay.Id
            //    );

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y == null &&
            //    hg == null &&
            //    ms != null &&
            //    nsx == null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdMauSac == ms.MauSac.Id
            //    );

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y == null &&
            //    hg == null &&
            //    ms == null &&
            //    nsx != null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c =>  c.ChiTietGiay.IdNsx == nsx.Nsx.Id);

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y != null &&
            //    hg != null &&
            //    ms == null &&
            //    nsx == null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    & c.ChiTietGiay.IdHangGiay == hg.HangGiay.Id
            //                                                    );

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y != null &&
            //    hg == null &&
            //    ms != null &&
            //    nsx == null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    & c.ChiTietGiay.IdMauSac == ms.MauSac.Id
            //                                                    );

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y != null &&
            //    hg == null &&
            //    ms == null &&
            //    nsx != null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    & c.ChiTietGiay.IdNsx == nsx.Nsx.Id);

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y == null &&
            //    hg != null &&
            //    ms != null &&
            //    nsx == null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdHangGiay == hg.HangGiay.Id
            //                                                    & c.ChiTietGiay.IdMauSac == ms.MauSac.Id
            //                                                    );

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y == null &&
            //    hg != null &&
            //    ms == null &&
            //    nsx != null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => 
            //                                                     c.ChiTietGiay.IdHangGiay == hg.HangGiay.Id

            //                                                    & c.ChiTietGiay.IdNsx == nsx.Nsx.Id);

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y == null &&
            //    hg == null &&
            //    ms != null &&
            //    nsx != null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c =>  c.ChiTietGiay.IdMauSac == ms.MauSac.Id
            //                                                    & c.ChiTietGiay.IdNsx == nsx.Nsx.Id);

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y != null &&
            //    hg != null &&
            //    ms != null &&
            //    nsx == null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    & c.ChiTietGiay.IdHangGiay == hg.HangGiay.Id
            //                                                    & c.ChiTietGiay.IdMauSac == ms.MauSac.Id
            //                                                    );

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y != null &&
            //    hg == null &&
            //    ms != null &&
            //    nsx != null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    & c.ChiTietGiay.IdMauSac == ms.MauSac.Id
            //                                                    & c.ChiTietGiay.IdNsx == nsx.Nsx.Id);

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y != null &&
            //    hg != null &&
            //    ms == null &&
            //    nsx != null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    & c.ChiTietGiay.IdHangGiay == hg.HangGiay.Id
            //                                                    & c.ChiTietGiay.IdNsx == nsx.Nsx.Id);

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}
            //if (
            //    y == null &&
            //    hg != null &&
            //    ms != null &&
            //    nsx != null
            //)
            //{
            //    var z = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.IdGiay == y.Giay.Id
            //                                                    & c.ChiTietGiay.IdHangGiay == hg.HangGiay.Id
            //                                                    & c.ChiTietGiay.IdMauSac == ms.MauSac.Id
            //                                                    & c.ChiTietGiay.IdNsx == nsx.Nsx.Id);

            //    List<ChiTietSale> cChiTietSales;
            //    cChiTietSales = new List<ChiTietSale>();
            //    foreach (var a in z)
            //    {
            //        Guid IdSale = x.Sale.Id;
            //        Guid IdChiTietGiay = a.ChiTietGiay.Id;
            //        int TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1;
            //        cChiTietSales.Add(new ChiTietSale()
            //        {
            //            IdSale = IdSale,
            //            IdChiTietGiay = IdChiTietGiay,
            //            TrangThai = TrangThai,
            //        });
            //    }

            //    return cChiTietSales;
            //}



            //List<ChiTietSale> cu;
            //cu = new List<ChiTietSale>();

            //return cu;

            ////return new ChiTietSale()
            ////{
            ////    IdSale = x.Sale.Id,
            ////    IdChiTietGiay = z
            ////    TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1,
            ////};

            #endregion
        }


        private void btn_themsale_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_sale.SelectedItem != null && cmb_hanggiay.SelectedItem != null && cmb_giay.SelectedItem != null && cmb_mausac.SelectedItem != null)
                {

                    DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (ChiTietSale a in GetvaluaControSALE())
                        {
                            _ = _IQlChiTietSale.Add(a);
                        }
                        LoadDataSP();

                    }
                }
                else
                {
                    _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                    return;
                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Đã tồn tại hãy kiểm tra lại");
            }


        }


        private void btn_xoasale_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool thongBao = _IQlChiTietSale.Delete(_IQlChiTietSale.GetAll().Find(c => c.Id == _ID));

                    if (thongBao)
                    {
                        _ = MessageBox.Show("Xóa thành công");
                        LoadDataSP();
                    }
                }
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }





        private void btn_giay_Click(object sender, EventArgs e)
        {
            try
            {
                FormGiay formGiay = new();
                formGiay.Show();
                Loadcmb();
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }

        private void btn_hanggiay_Click(object sender, EventArgs e)
        {
            try
            {
                FormHangGiay formHangGiayGiay = new();
                formHangGiayGiay.Show();
                Loadcmb();
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {
            try
            {
                FormMauSac formMauSac = new();
                formMauSac.Show();
                Loadcmb();
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }





        private void cmb_giay_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                LocChiTietGiay();
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_giay.SelectedIndex = 0;
                cmb_hanggiay.SelectedIndex = 0;
                cmb_mausac.SelectedIndex = 0;
                LoadDataSP2(_IQlChiTietGiay.GetAllView());
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }

        private void cmb_hanggiay_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocChiTietGiay();
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }



        private void cmb_mausac_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LocChiTietGiay();
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }


        private void LocChiTietGiay()
        {
            try
            {
                if (cmb_giay.SelectedItem == null || cmb_hanggiay.SelectedItem == null || cmb_mausac.SelectedItem == null)
                {
                    return;
                }
                List<ChiTietGiayView> lstChiTietGiayView = _IQlChiTietGiay.GetAllView().Where(c => c.ChiTietGiay.SoLuongTon > 0).ToList();
                string? tenGiay = cmb_giay.SelectedItem == "Tất cả tên giày" ? "-1" : cmb_giay.SelectedItem.ToString();
                if (tenGiay != "-1")
                {
                    lstChiTietGiayView = lstChiTietGiayView.Where(c => c.Giay.TenGiay == tenGiay).ToList();
                }
                string? tenMauSac = cmb_mausac.SelectedItem == "Tất cả màu sắc" ? "-1" : cmb_mausac.SelectedItem.ToString();
                if (tenMauSac != "-1")
                {
                    lstChiTietGiayView = lstChiTietGiayView.Where(c => c.MauSac.TenMauSac == tenMauSac).ToList();
                }
                string? tenHangGiay = cmb_hanggiay.SelectedItem == "Tất cả hãng giày" ? "-1" : cmb_hanggiay.SelectedItem.ToString();
                if (tenHangGiay != "-1")
                {
                    lstChiTietGiayView = lstChiTietGiayView.Where(c => c.HangGiay.TenHangGiay == tenHangGiay).ToList();
                }
                LoadDataSP2(lstChiTietGiayView);
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }

        private void dgrid_showsanpham_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                _ID = Guid.Parse(dgrid_showsanpham.Rows[index].Cells[11].Value.ToString());
                ChiTietSaleView? a = _IQlChiTietSale.GetAllView().FirstOrDefault(c => c.ChiTietSale.Id == _ID);
                ChiTietGiayView? b = _IQlChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.Id == a.ChiTietGiay.Id);
                cmb_sale.SelectedItem = _IQlChiTietSale.GetAllView().FirstOrDefault(c => c.ChiTietSale.IdSale == a.ChiTietSale.IdSale).Sale.TenChuongTrinh;
                cmb_giay.SelectedItem = _IQlChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.Id == b.ChiTietGiay.Id).Giay.TenGiay;
                cmb_hanggiay.SelectedItem = _IQlChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.Id == b.ChiTietGiay.Id).HangGiay.TenHangGiay;
                cmb_mausac.SelectedItem = _IQlChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.Id == b.ChiTietGiay.Id).MauSac.TenMauSac;
            }
            catch (Exception)
            {
                _ = MessageBox.Show(" hãy kiểm tra lại");
            }

        }
    }
}
