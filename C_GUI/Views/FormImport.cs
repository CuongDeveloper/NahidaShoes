using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using OfficeOpenXml;
using System.Data;
using System.Text.RegularExpressions;
using Size = A_DAL.Entities.Size;

namespace C_GUI.Views
{
    public partial class FormImport : Form
    {
        public string TenMausac;
        public string TenNSX;
        public string TenSize;
        public string TenHangGiay;
        public int KichCo;
        public string TenGiay;
        public string Mota;
        public int GiaNhap;
        public int GiaBan;
        public int SoluongTon;
        private readonly IQLChiTietGiay _ChiTietGiay;
        private readonly IQLMauSac _MauSac;
        private readonly IQLNsx _Nsx;
        private readonly IQLSize _Size;
        private readonly IQLHangGiay _hangGiay;
        private readonly IQLChieuCaoDeGiay _ChieuCaoDeGiay;
        private readonly IQLGiay _Giay;
        public FormImport()
        {
            InitializeComponent();
            _ChiTietGiay = new QLChiTietGiay();
            _MauSac = new QLMauSac();
            _Nsx = new QLNsx();
            _Size = new QLSize();
            _hangGiay = new QLHangGiay();
            _ChieuCaoDeGiay = new QLChieuCaoDeGiay();
            _Giay = new QLGiay();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có muốn chọn Nguồn Excel Ko", "Thông Báo", MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {


                OpenFileDialog openFileDialog = new()
                {
                    FileName = btn_link.Text,
                    Filter = "Excel Spreadsheet (*.XLSX;*.XLSM)|*.XLSX;*.XLSM"
                };
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    btn_link.Text = openFileDialog.FileName;
                }

                DataTable dt = new();

                _ = dt.Columns.Add("Tên Màu Sắc");
                _ = dt.Columns.Add("Tên NSX");
                _ = dt.Columns.Add("Tên Size");
                _ = dt.Columns.Add("Hãng Giày");
                _ = dt.Columns.Add("Kích Cỡ");
                _ = dt.Columns.Add("Tên Giày");
                _ = dt.Columns.Add("Mô Tả");
                _ = dt.Columns.Add("Giá Nhập");
                _ = dt.Columns.Add("Giá bán");
                _ = dt.Columns.Add("Số Lượng tồn");
                dt.Rows.Clear();
                _dgrvThongTinSanPham.AllowUserToAddRows = false;

                try
                {
                    // mo file excel
                    ExcelPackage package = new(new FileInfo(btn_link.Text));
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                    {
                        try
                        {
                            int j = 1;
                            object tenmausac = worksheet.Cells[i, j++].Value;
                            object tennsx = worksheet.Cells[i, j++].Value;
                            object namsize = worksheet.Cells[i, j++].Value;
                            object hanggiay = worksheet.Cells[i, j++].Value;
                            object kichco = worksheet.Cells[i, j++].Value;
                            object tengiay = worksheet.Cells[i, j++].Value;
                            object mota = worksheet.Cells[i, j++].Value;
                            object gianhap = worksheet.Cells[i, j++].Value;
                            object giaban = worksheet.Cells[i, j++].Value;
                            object soluongton = worksheet.Cells[i, j++].Value;

                            _ = dt.Rows.Add(tenmausac, tennsx, namsize, hanggiay, kichco, tengiay, mota, gianhap, giaban,
                                soluongton);
                        }
                        catch (Exception)
                        {
                            _ = MessageBox.Show("Error");
                           
                        }
                    }
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Error");
                    throw;
                }

                _dgrvThongTinSanPham.DataSource = dt.DefaultView;
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
          
            DialogResult dialogResult = MessageBox.Show("Bạn Muốn Lưu Dữ Liệu chứ ?", "Thông Báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < _dgrvThongTinSanPham.Rows.Count; i++)
                {
                    try
                    {

                        TenMausac = _dgrvThongTinSanPham.Rows[i].Cells[0].Value.ToString();
                        TenNSX = _dgrvThongTinSanPham.Rows[i].Cells[1].Value.ToString();
                        TenSize = _dgrvThongTinSanPham.Rows[i].Cells[2].Value.ToString();
                        TenHangGiay = _dgrvThongTinSanPham.Rows[i].Cells[3].Value.ToString();
                        KichCo = int.Parse(_dgrvThongTinSanPham.Rows[i].Cells[4].Value.ToString());
                        TenGiay = _dgrvThongTinSanPham.Rows[i].Cells[5].Value.ToString();
                        Mota = _dgrvThongTinSanPham.Rows[i].Cells[6].Value.ToString();
                        GiaBan = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[7].Value.ToString());
                        GiaNhap = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[8].Value.ToString());
                        SoluongTon = int.Parse(_dgrvThongTinSanPham.Rows[i].Cells[9].Value.ToString());
                        if (TenMausac == "")
                        {
                            MessageBox.Show("Màu Sắc Không Để Trống");
                            return;
                        }

                        if (TenNSX == "")
                        {
                            MessageBox.Show("Tên Nhà Sản Xuất không Được Để Trống");
                            return;
                        }

                        if (TenSize=="")
                        {
                            MessageBox.Show("Không Được Để trống Tên Size");
                            return;
                        }

                        if (TenHangGiay=="")
                        {
                            MessageBox.Show("Không Được Để Trông");
                            return;
                        }

                        if (Convert.ToString(KichCo)=="")
                        {
                            MessageBox.Show("Không Được Để Trống");
                            return;
                        }

                        if (TenGiay =="")
                        {
                            MessageBox.Show("Không Được Để Trống Tên Giày");
                            return;
                        }

                        if (Convert.ToString(GiaNhap)=="")
                        {
                            MessageBox.Show("Không Được Để Trống Giá Nhập");
                            return;
                        }
                        if (Convert.ToString(GiaBan) == "")
                        {
                            MessageBox.Show("Không Được Để Trống Giá Bán");
                            return;
                        }
                        if (Convert.ToString(SoluongTon) == "")
                        {
                            MessageBox.Show("Không Được Để Trống Số Lượng Tồn");
                            return;
                        }


                        if (KichCo>=50)
                        {
                            MessageBox.Show("Không Có giày loại này");
                            return;
                        }
                        if (GiaNhap > GiaBan) 
                        {
                            MessageBox.Show("Giá Nhập Lơn Hơn Giá Bán");
                            return;
                        }
                        if (SoluongTon == 0)
                        {
                            MessageBox.Show("Số Lượng Tồn Không ai lại đi Nhập là Không cả");
                            return;
                        }
                        if (GiaBan == 0)
                        {
                            MessageBox.Show("Giá bán Không ai lại đi Nhập là Không cả Buôn bán là Phải có lãi");
                            return;
                        }

                        if (GiaNhap<0)
                        {
                            MessageBox.Show("Không Được Nhập Âm Tiền Hoặc 0");
                            return;
                        }
                        if (GiaBan < 0)
                        {
                            MessageBox.Show("Không Được Nhập Âm Tiền Hoặc 0");
                            return;
                        }

                        if (SoluongTon < 0)
                        {
                            MessageBox.Show("Vui Lòng Không Nhập số lượng tồn Âm hoặc không");
                            return;
                        }
                       


                        try
                        {
                            float giamGia = Convert.ToSingle(GiaNhap);
                            float tienKhachDua = Convert.ToSingle(GiaBan);
                            float thanhToanOnline = Convert.ToSingle(SoluongTon);

                        }
                        catch (Exception)
                        {
                            _ = MessageBox.Show("KHông Nhập chữ hoặc Ký Tự Đặc Biêt");
                            return;
                        }
                        
                        if (Regex.IsMatch(TenMausac, @"[0-9]+") == true)
                        {

                            MessageBox.Show("Mã màu Sắc Không chứa Số ", "ERR");
                            return ;
                        }
                        if (Regex.IsMatch(TenNSX, @"[0-9]+") == true)
                        {

                            MessageBox.Show("Tên Nhà Sản Xuất Không chứa Số ", "ERR");
                            return;
                        }
                        if (Regex.IsMatch(Convert.ToString(KichCo), @"^[a-zA-Z]") == true)
                        {

                            MessageBox.Show("Tên nhân Viên không được chứa số", "ERR");
                            return ;
                        }
                        Nsx n = new()
                        {
                            MaNsx = (_Nsx.GetAll().Count + 1).ToString(),
                            TenNsx = TenNSX,
                            DiaChi = "Ha Noi",
                            TrangThai = 1
                        };
                        Guid IdNsx = _Nsx.IdNsx(n);
                        //  MessageBox.Show(IdNsx.ToString());


                        MauSac m = new()
                        {
                            MaMauSac = (_MauSac.GetAll().Count + 1).ToString(),
                            TenMauSac = TenMausac,
                            TrangThai = 1
                        };
                        Guid idMauSac = _MauSac.IdMauSac(m);

                        Size s = new()
                        {
                            MaSize = (_Size.GetAll().Count + 1).ToString(),
                            TenSize = TenSize,
                            SoSize = 42,
                            TrangThai = 1
                        };
                        Guid idSize = _Size.IdSize(s);

                        HangGiay h = new()
                        {
                            MaHangGiay = (_hangGiay.GetAll().Count + 1).ToString(),
                            TenHangGiay = TenHangGiay,
                            TrangThai = 1
                        };
                        Guid IdHangGiay = _hangGiay.IdHangGiay(h);

                        ChieuCaoDeGiay k = new()
                        {
                            MaKichCo = (_ChieuCaoDeGiay.GetAll().Count + 1).ToString(),
                            KichCo = KichCo,
                            TrangThai = 1
                        };
                        Guid IdKichCo = _ChieuCaoDeGiay.IdChieuCaoDeGiay(k);

                        Giay l = new()
                        {
                            MaGiay = (_Giay.GetAll().Count + 1).ToString(),
                            TenGiay = TenGiay,
                            TrangThai = 1,

                        };
                        Guid giay = _Giay.idGiay(l);
                        //  MessageBox.Show(giay.ToString());
                        ChiTietGiay spCt = new()
                        {
                            Id = Guid.NewGuid(),
                            MoTa = Mota,
                            TrangThai = 1,
                            SoLuongTon = SoluongTon,
                            GiaBan = GiaBan,
                            GiaNhap = GiaNhap,
                            IdGiay = giay,
                            IdHangGiay = IdHangGiay,
                            IdNsx = IdNsx,
                            IdMauSac = idMauSac,
                            IdChieuCaoDeGiay = IdKichCo,
                            IdSize = idSize,

                        };
                        _ = _ChiTietGiay.Add(spCt);
                        // MessageBox.Show("ID ChiTietSanPham");
                        _ = MessageBox.Show("Thêm Thanh Công");
                    }
                    catch (Exception)
                    {

                        _ = MessageBox.Show("Hãy Nhập Đúng Giá Trị Đầu Vào");
                    }
                }
                



            }
        }

        private void FormImport_FormClosed(object sender, FormClosedEventArgs e)
        {
            TrangChu trnagChu = new TrangChu();
            this.Hide();
            trnagChu.Show();
        }
    }
}


