using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using C_GUI.QLForm;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using B_BUS.View_Models;
using Excel = Microsoft.Office.Interop.Excel;


namespace C_GUI.Views
{
    public partial class FormSanPham : Form
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
        private readonly FormNsx c;
        private readonly FormSize size;
        private readonly FormHangGiay HangGiay;
        private readonly FormChieuCaoDeGiay ChieuCaoDeGiay;
        private readonly FormMauSac MauSac;
        private readonly IQLChiTietGiay _ChiTietGiay;
        private readonly IQLMauSac _MauSac;
        private readonly IQLNsx _Nsx;
        private readonly IQLSize _Size;
        private readonly IQLHangGiay _hangGiay;
        private readonly IQLChieuCaoDeGiay _ChieuCaoDeGiay;
        private readonly IQLGiay _Giay;
        private readonly IQLChiTietTheLoai _ChiTietTheLoai;
        private readonly IQLTheLoai _theloai;
        private readonly FormTheLoai TheLoai;
        private readonly FormGiay Giay;
        private Guid Idwhenclick;
        private readonly IQLChiTietTheLoai _Ichotiett;
        public FormSanPham()
        {
            InitializeComponent();
            _ChiTietGiay = new QLChiTietGiay();
            _MauSac = new QLMauSac();
            _Nsx = new QLNsx();
            _Size = new QLSize();
            _hangGiay = new QLHangGiay();
            _ChieuCaoDeGiay = new QLChieuCaoDeGiay();
            _Giay = new QLGiay();
            _ChiTietTheLoai = new QLChiTietTheLoai();
            _theloai = new QLTheLoai();
            c = new FormNsx();
            size = new FormSize();
            HangGiay = new FormHangGiay();
            ChieuCaoDeGiay = new FormChieuCaoDeGiay();
            MauSac = new FormMauSac();
            TheLoai = new FormTheLoai();
            Giay = new FormGiay();
            _Ichotiett = new QLChiTietTheLoai();
            btn_save.Visible = false;
            LoadData(_ChiTietGiay.GetAllView());
            LoadComBo();
            btn_export.Visible = false;
            dTheLoai();
            
            //cmb_mausac.SelectedItem="Màu Sắc 1";
            //_rjcmbNSX.SelectedItem=1;
            //_rjcmbSize.SelectedItem = 1;
            //_rjcmbHangGiay.SelectedItem = 1;
            //_rjcmbCCDeGiay.SelectedItem = 1;
            //_rjcmbTenGiay.SelectedItem = 1;
            //cmb_theloai.SelectedItem = 1;
        }

        private void dTheLoai()
        {
           // var ten = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == _rjcmbTenGiay.Texts);
            dgrvtheloai.ColumnCount = 2;
            dgrvtheloai.Columns[0].Name = "Tên";
            dgrvtheloai.Columns[1].Name = "Thê Loại";
            dgrvtheloai.Rows.Clear();
            dgrvtheloai.Columns[0].Visible = false;
            dgrvtheloai.AllowUserToAddRows=false;
            foreach (var c in _ChiTietTheLoai.GetAllView().Where(c=>c.ChiTietGiay.Id ==Idwhenclick))
            {
                dgrvtheloai.Rows.Add(c.ChiTietGiay.IdGiay,c.TheLoai.TenTheLoai);
            }
        }
        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {
            LoadData(_ChiTietGiay.GetAllView().Where(c => c.Giay.TenGiay.ToLower().Contains(tbx_timkiem.Texts.ToLower()) ||c.Size.TenSize.ToLower().Contains(tbx_timkiem.Texts.ToLower())|| c.Nsx.TenNsx.ToLower().Contains(tbx_timkiem.Texts.ToLower())|| c.MauSac.TenMauSac.ToLower().Contains(tbx_timkiem.Texts.ToLower())|| c.HangGiay.TenHangGiay.ToLower().Contains(tbx_timkiem.Texts.ToLower())).ToList());
        }

        public bool check()
        {
            if (Regex.IsMatch(_rjtbxSoLuongTon.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                _ = MessageBox.Show("Vui Lòng Không Nhập Số Lượng Tồn Không Có Ký Tự Đặc Biet", "ERR");
                return false;
            }
            if (Regex.IsMatch(_rjtbxGiaNhap.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                _ = MessageBox.Show("Vui Lòng Không Nhập Giá Nhập Không Có Ký Tự Đặc Biet", "ERR");
                return false;
            }
            if (Regex.IsMatch(_rjtbxGiaBan.Text, @"^[a-zA-Z0-9 ]*$") == false)
            {

                _ = MessageBox.Show("giá Bán không được chứa ký tự đặc biệt", "ERR");
                return false;
            }
            //if (Regex.IsMatch(_rjtbxGiaNhap.Text,@"^[a-zA-Z]+$") == false)
            //{

            //    MessageBox.Show("Giá Nhập Không đc nhập chữ  ", "ERR");
            //    return false;
            //}
            //if (Regex.IsMatch(_rjtbxGiaBan.Text, @"^[a-zA-Z]+$") == false)
            //{

            //    MessageBox.Show("Giá Bán Không đc nhập chữ  ", "ERR");
            //    return false;
            //}
            //if (Regex.IsMatch(_rjtbxSoLuongTon.Text, @"^\d+$") == false)
            //{

            //    MessageBox.Show("Số Lượng Tồn Không đc viết chữ  ", "ERR");
            //    return false;
            //}
            if (string.IsNullOrEmpty(cmb_mausac.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Chọn Màu Sắc");
                return false;
            }

            if (string.IsNullOrEmpty(_rjcmbHangGiay.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Chọn Hãng Giày");
                return false;
            }

            if (string.IsNullOrEmpty(_rjcmbNSX.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Chọn Nhà Sản Xuất");
                return false;
            }

            if (string.IsNullOrEmpty(_rjcmbSize.Texts))
            {
                _ = MessageBox.Show("Vui Lòng chọn Size ");
                return false;

            }

            if (string.IsNullOrEmpty(_rjcmbCCDeGiay.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Kích Cỡ");
                return false;
            }

            if (string.IsNullOrEmpty(_rjcmbTenGiay.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Chọn Tên giay");
                return false;
            }

            if (string.IsNullOrEmpty(_rjtbxGiaBan.Texts))
            {
                _ = MessageBox.Show("vui Lòng Nhập số tiền bán");
                return false;
            }


            if (Convert.ToInt32(_rjtbxGiaBan.Texts) < Convert.ToInt32(_rjtbxGiaNhap.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Nhập Giá Bán Cao Hơn giá Nhập");
                return false;
            }


            //
            if (string.IsNullOrEmpty(_rjtbxGiaNhap.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Nhập Giá Nhập");
                return false;
            }
            if (Convert.ToInt32(_rjtbxGiaNhap.Texts) <= 0)
            {
                _ = MessageBox.Show("Vui Lòng không nhập tiền Âm hoặc bằng ko");
                return false;
            }
            if (Convert.ToInt32(_rjtbxGiaBan.Texts) <= 0)
            {
                _ = MessageBox.Show("Vui Lòng không nhập tiền Âm hoặc bằng ko");
                return false;
            }
            if (Convert.ToInt32(_rjtbxSoLuongTon.Texts) <= 0)
            {
                _ = MessageBox.Show("Vui Lòng không nhập tiền lượng tồn âm");
                return false;
            }
            if (Convert.ToInt32(_rjtbxGiaNhap.Texts) > Convert.ToInt32(_rjtbxGiaBan.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Nhập Giá Nhập Lớn Hơn Giá bán");
                return false;
            }


            //
            if (string.IsNullOrEmpty(_rjtbxSoLuongTon.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Nhập Số Lương");
                return false;
            }


            if (Convert.ToInt32(_rjtbxGiaBan.Texts) <= 0)
            {
                _ = MessageBox.Show("Vui Lòng không nhập tiền Âm hoặc bằng ko");
                return false;
            }

           
            return true;
        }
        public void LoadComBo()
        {
            cmb_mausac.Items.Clear();
            foreach (MauSac mauSac in _MauSac.GetAll())
            {
                _ = cmb_mausac.Items.Add(mauSac.TenMauSac);
            }
            _rjcmbNSX.Items.Clear();
            foreach (Nsx nsx in _Nsx.GetAll())
            {
                _ = _rjcmbNSX.Items.Add(nsx.TenNsx);
            }
            _rjcmbSize.Items.Clear();
            foreach (A_DAL.Entities.Size siz in _Size.GetAll())
            {
                _ = _rjcmbSize.Items.Add(siz.TenSize);
            }
            _rjcmbHangGiay.Items.Clear();
            foreach (HangGiay hangGiay in _hangGiay.GetAll())
            {
                _ = _rjcmbHangGiay.Items.Add(hangGiay.TenHangGiay);
            }
            _rjcmbCCDeGiay.Items.Clear();
            foreach (ChieuCaoDeGiay chieuCaoDeGiay in _ChieuCaoDeGiay.GetAll())
            {
                _ = _rjcmbCCDeGiay.Items.Add(chieuCaoDeGiay.KichCo);
            }
            _rjcmbTenGiay.Items.Clear();
            foreach (Giay VARIABLE in _Giay.GetAll())
            {
                _ = _rjcmbTenGiay.Items.Add(VARIABLE.TenGiay);
            }
            cmb_theloai.Items.Clear();
            foreach (TheLoai a in _theloai.GetAll())
            {
                _ = cmb_theloai.Items.Add(a.MaTheLoai);
            }

        }

        public void LoadData(List<ChiTietGiayView> chiTietGiayViews)
        {
            _dgrvThongTinSanPham.ColumnCount = 11;
            _dgrvThongTinSanPham.Columns[0].Name = "ID";
            _dgrvThongTinSanPham.Columns[0].Visible = false;
            _dgrvThongTinSanPham.Columns[1].Name = "Tên Màu Sắc";
            _dgrvThongTinSanPham.Columns[2].Name = "Tên Nhà Sản Xuất";
            _dgrvThongTinSanPham.Columns[3].Name = "Tên Size";
            _dgrvThongTinSanPham.Columns[4].Name = "Tên hãng Giày";
            _dgrvThongTinSanPham.Columns[5].Name = " Kich Co";
            _dgrvThongTinSanPham.Columns[6].Name = "Tên giày";
            _dgrvThongTinSanPham.Columns[7].Name = "Mô Tả ";
            _dgrvThongTinSanPham.Columns[8].Name = "Gia Bán";
            _dgrvThongTinSanPham.Columns[9].Name = "Giá Nhập";
            _dgrvThongTinSanPham.Columns[10].Name = "Số Lương Tồn";

            _dgrvThongTinSanPham.Rows.Clear();
            _dgrvThongTinSanPham.AllowUserToAddRows = false;
            foreach (B_BUS.View_Models.ChiTietGiayView VARIABLE in chiTietGiayViews)
            {
                _ = _dgrvThongTinSanPham.Rows.Add(VARIABLE.ChiTietGiay.Id, VARIABLE.MauSac.TenMauSac, VARIABLE.Nsx.TenNsx, VARIABLE.Size.TenSize, VARIABLE.HangGiay.TenHangGiay, VARIABLE.ChieuCaoDeGiay.KichCo, VARIABLE.Giay.TenGiay, VARIABLE.ChiTietGiay.MoTa, VARIABLE.ChiTietGiay.GiaBan, VARIABLE.ChiTietGiay.GiaNhap, VARIABLE.ChiTietGiay.SoLuongTon);
            }
        }

        private void btn_nsx_Click(object sender, EventArgs e)
        {
            LoadComBo();
            _ = c.ShowDialog();


        }

        private void btn_size_Click(object sender, EventArgs e)
        {

            _ = size.ShowDialog();
            LoadComBo();
        }

        private void Btn_hanggiay_Click(object sender, EventArgs e)
        {

            _ = HangGiay.ShowDialog();
            LoadComBo();
        }

        private void btn_chieuCaodegiay_Click(object sender, EventArgs e)
        {

            _ = ChieuCaoDeGiay.ShowDialog();
            LoadComBo();
        }

        private void btn_mausac_Click(object sender, EventArgs e)
        {

            _ = MauSac.ShowDialog();
            LoadComBo();
        }

        private void btn_theloai_Click(object sender, EventArgs e)
        {

            _ = TheLoai.ShowDialog();
            LoadComBo();
        }

        private void btn_giay_Click(object sender, EventArgs e)
        {
            _ = Giay.ShowDialog();
            LoadComBo();
        }

        private void _rjbtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                ChiTietGiay? xoa = _ChiTietGiay.GetAll().FirstOrDefault(c => c.Id == Idwhenclick);
                DialogResult a = MessageBox.Show("Thông Báo", "Bạn Có Muốn Sửa Không", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {

                    if (_ChiTietGiay.Delete(xoa))
                    {
                        _ = MessageBox.Show("Xóa Thành Công");
                        LoadData(_ChiTietGiay.GetAllView());
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi");
            }
            
        }

        private void _rjbtnAdd_Click(object sender, EventArgs e)
        {

            DialogResult hoi = MessageBox.Show(" Thông Báo", "Bạn có Muốn thêm ko", MessageBoxButtons.YesNo);
            //if (_rjcmbHangGiay.Texts == "" || _rjcmbCCDeGiay.Texts == "" || _rjcmbNSX.Texts == "" ||
            //    _rjcmbSize.Texts == "" || _rjcmbSize.Texts == "" || _rjtbxSoLuongTon.Texts == "" ||
            //    _rjtbxGiaNhap.Texts == "" || _rjtbxGiaBan.Texts == "" || _rjtbxSoLuongTon.Texts == "")
            //{
            //    MessageBox.Show("bạn Đang điền thiếu vui lòng điền lại");
            //}
            //else
            //{


            byte[] anh = converterDemo(anhsp);
            MauSac? mausac = _MauSac.GetAll().FirstOrDefault(c => c.TenMauSac == cmb_mausac.Texts);
            Nsx? nsx = _Nsx.GetAll().FirstOrDefault(c => c.TenNsx == _rjcmbNSX.Texts);
            HangGiay? hanggiay = _hangGiay.GetAll().FirstOrDefault(c => c.TenHangGiay == _rjcmbHangGiay.Texts);
            A_DAL.Entities.Size? size = _Size.GetAll().FirstOrDefault(c => c.TenSize == _rjcmbSize.Texts);
            Giay? giay = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == _rjcmbTenGiay.Texts);
            ChieuCaoDeGiay? ccDeGiay = _ChieuCaoDeGiay.GetAll().FirstOrDefault(c => c.KichCo == int.Parse(_rjcmbCCDeGiay.Texts));
            try
            {
                float giamGia = Convert.ToSingle(_rjtbxGiaNhap.Texts.Trim());
                float tienKhachDua = Convert.ToSingle(_rjtbxGiaBan.Texts.Trim());
                float thanhToanOnline = Convert.ToSingle(_rjtbxSoLuongTon.Texts.Trim());

            }
            catch (Exception)
            {
                _ = MessageBox.Show("KHông Nhập chữ hoặc Ký Tự Đặc Biệt");
                return;
            }

            if (check() == false)
            {
                return;
            }
            
            if (_ChiTietGiay.CheckMa(size.Id,nsx.Id,mausac.Id,hanggiay.Id,giay.Id,ccDeGiay.Id) == false)
            {
                MessageBox.Show("Mã Trùng");
                return;
            }

            bool thongbao = _ChiTietGiay.Add(new ChiTietGiay()
            {
                Id = Guid.NewGuid(),
                IdMauSac = mausac.Id,
                IdNsx = nsx.Id,
                IdSize = size.Id,
                IdHangGiay = hanggiay.Id,
                IdChieuCaoDeGiay = ccDeGiay.Id,
                IdGiay = giay.Id,
                MoTa = _rtbxMota.Text,
                GiaBan = int.Parse(_rjtbxGiaBan.Texts),
                GiaNhap = int.Parse(_rjtbxGiaNhap.Texts),
                SoLuongTon = int.Parse(_rjtbxSoLuongTon.Texts),
                Anh = anh,
                TrangThai = 1
            });

            if (hoi == DialogResult.Yes)
            {
                if (thongbao)
                {
                    _ = MessageBox.Show("Thêm Thành Công");
                    LoadData(_ChiTietGiay.GetAllView());
                }
                else
                {
                    _ = MessageBox.Show("Thêm Thất Bại");
                }
            }
        }
        //}

        private void _dgrvThongTinSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Idwhenclick = Guid.Parse(_dgrvThongTinSanPham.Rows[index].Cells[0].Value.ToString());
            cmb_mausac.SelectedItem = _dgrvThongTinSanPham.Rows[index].Cells[1].Value.ToString();
            _rjcmbNSX.SelectedItem = _dgrvThongTinSanPham.Rows[index].Cells[2].Value.ToString();
            _rjcmbSize.SelectedItem = _dgrvThongTinSanPham.Rows[index].Cells[3].Value.ToString();
            _rjcmbHangGiay.SelectedItem = _dgrvThongTinSanPham.Rows[index].Cells[4].Value.ToString();
            _rjcmbCCDeGiay.Texts = _dgrvThongTinSanPham.Rows[index].Cells[5].Value.ToString();
            _rjcmbTenGiay.Texts = _dgrvThongTinSanPham.Rows[index].Cells[6].Value.ToString();
            if (_dgrvThongTinSanPham.Rows[index].Cells[7].Value != null)
            {
                _rtbxMota.Text = _dgrvThongTinSanPham.Rows[index].Cells[7].Value.ToString();
            }
            _rjtbxGiaBan.Texts = _dgrvThongTinSanPham.Rows[index].Cells[8].Value.ToString();
            _rjtbxGiaNhap.Texts = _dgrvThongTinSanPham.Rows[index].Cells[9].Value.ToString();
            _rjtbxSoLuongTon.Texts = _dgrvThongTinSanPham.Rows[index].Cells[10].Value.ToString();
            ChiTietGiay? chitietgiay = _ChiTietGiay.GetAll().FirstOrDefault(c => c.Id == Idwhenclick);
            if (chitietgiay.Anh != null)
            {
                pictureBox1.Image = Image.FromStream(new MemoryStream(chitietgiay.Anh));
            }

            dTheLoai();
        }

        private Image cellanh(byte[] obj)
        {
            return (Image)new ImageConverter().ConvertFrom(obj);

        }
        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Rectangle destRect = new(0, 0, width, height);
            Bitmap destImage = new(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (Graphics graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using ImageAttributes wrapMode = new();
                wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
            }

            return destImage;
        }
        private void _rjbtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    float giamGia = Convert.ToSingle(_rjtbxGiaNhap.Texts.Trim());
                    float tienKhachDua = Convert.ToSingle(_rjtbxGiaBan.Texts.Trim());
                    float thanhToanOnline = Convert.ToSingle(_rjtbxSoLuongTon.Texts.Trim());

                }
                catch (Exception)
                {
                    _ = MessageBox.Show("KHông Nhập chữ hoặc Ký tự đặc Biêt");
                    return;
                }
                if (check()==false)
                {
                    return;
                }
                byte[] anh = converterDemo(anhsp);
                MauSac? mausac = _MauSac.GetAll().FirstOrDefault(c => c.TenMauSac == cmb_mausac.Texts);
                Nsx? nsx = _Nsx.GetAll().FirstOrDefault(c => c.TenNsx == _rjcmbNSX.Texts);
                HangGiay? hanggiay = _hangGiay.GetAll().FirstOrDefault(c => c.TenHangGiay == _rjcmbHangGiay.Texts);
                A_DAL.Entities.Size? size = _Size.GetAll().FirstOrDefault(c => c.TenSize == _rjcmbSize.Texts);
                Giay? giay = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == _rjcmbTenGiay.Texts);
                ChieuCaoDeGiay? ccDeGiay = _ChieuCaoDeGiay.GetAll().FirstOrDefault(c => c.KichCo == int.Parse(_rjcmbCCDeGiay.Texts));
                bool thongbao = _ChiTietGiay.Update(new ChiTietGiay()
                {
                    Id = Idwhenclick,
                    IdMauSac = mausac.Id,
                    IdNsx = nsx.Id,
                    IdSize = size.Id,
                    IdHangGiay = hanggiay.Id,
                    IdChieuCaoDeGiay = ccDeGiay.Id,
                    IdGiay = giay.Id,
                    MoTa = _rtbxMota.Text,
                    GiaBan = int.Parse(_rjtbxGiaBan.Texts),
                    GiaNhap = int.Parse(_rjtbxGiaNhap.Texts),
                    SoLuongTon = int.Parse(_rjtbxSoLuongTon.Texts),
                    Anh = anh,
                    TrangThai = 1
                });

                DialogResult hoi = MessageBox.Show(" Thông Báo", "Bạn có Muốn Sửa ko", MessageBoxButtons.YesNo);
                if (hoi == DialogResult.Yes)
                {
                    if (thongbao)
                    {
                        _ = MessageBox.Show("Sửa Thành Công");
                        LoadData(_ChiTietGiay.GetAllView());
                    }
                    else
                    {
                        _ = MessageBox.Show("Sửa Thất Bại");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Lỗi rồi");
            }
           
        }

        private void btn_link_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormImport vn = new();
            this.Hide();
            _ = vn.ShowDialog();

            #region MyRegion




            //    var a = MessageBox.Show("Bạn có muốn chọn Nguồn Excel Ko", "Thông Báo", MessageBoxButtons.YesNo);
            //    if (a ==DialogResult.Yes)
            //    {


            //        OpenFileDialog openFileDialog = new OpenFileDialog();
            //        openFileDialog.FileName = btn_link.Text;
            //        openFileDialog.Filter = "Excel Spreadsheet (*.XLSX;*.XLSM)|*.XLSX;*.XLSM";
            //        if (openFileDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            btn_link.Text = openFileDialog.FileName;
            //        }

            //        DataTable dt = new DataTable();

            //        dt.Columns.Add("Tên Màu Sắc");
            //        dt.Columns.Add("Tên NSX");
            //        dt.Columns.Add("Tên Size");
            //        dt.Columns.Add("Hãng Giày");
            //        dt.Columns.Add("Kích Cỡ");
            //        dt.Columns.Add("Tên Giày");
            //        dt.Columns.Add("Mô Tả");
            //        dt.Columns.Add("Giá Nhập");
            //        dt.Columns.Add("Giá bán");
            //        dt.Columns.Add("Số Lượng tồn");
            //        dt.Rows.Clear();
            //        try
            //        {
            //            // mo file excel
            //            var package = new ExcelPackage(new FileInfo(btn_link.Text));
            //            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            //            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            //            for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
            //            {
            //                try
            //                {
            //                    int j = 1;
            //                    var tenmausac = worksheet.Cells[i, j++].Value;
            //                    var tennsx = worksheet.Cells[i, j++].Value;
            //                    var namsize = worksheet.Cells[i, j++].Value;
            //                    var hanggiay = worksheet.Cells[i, j++].Value;
            //                    var kichco = worksheet.Cells[i, j++].Value;
            //                    var tengiay = worksheet.Cells[i, j++].Value;
            //                    var mota = worksheet.Cells[i, j++].Value;
            //                    var gianhap = worksheet.Cells[i, j++].Value;
            //                    var giaban = worksheet.Cells[i, j++].Value;
            //                    var soluongton = worksheet.Cells[i, j++].Value;

            //                    dt.Rows.Add(tenmausac, tennsx, namsize, hanggiay, kichco, tengiay, mota, gianhap, giaban,
            //                        soluongton);
            //                }
            //                catch (Exception)
            //                {
            //                    MessageBox.Show("Error");
            //                    throw;
            //                }
            //            }
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Error");
            //            throw;
            //        }

            //        _dgrvThongTinSanPham.DataSource = dt.DefaultView;
            //    }
            //}
            //private void btn_excel_Click(object sender, EventArgs e)
            //{

            //    DataTable dataTable = new DataTable();
            //    DataColumn col1= new DataColumn("Tên Màu Sắc");
            //    DataColumn col2 = new DataColumn("Tên Nhà Sản Xuất");
            //    DataColumn col3 = new DataColumn("Tên Size");
            //    DataColumn col4 = new DataColumn("Tên Hãng Giày");
            //    DataColumn col5 = new DataColumn("Kích Cỡ");
            //    DataColumn col6 = new DataColumn("Tên Giày");
            //    DataColumn col7 = new DataColumn("Mô tả");
            //    DataColumn col8 = new DataColumn("Giá Bán");
            //    DataColumn col9 = new DataColumn("Giá Nhập");
            //    DataColumn col10 = new DataColumn("Số Lượng Tồn");
            //   dataTable.Columns.Add(col1);
            //   dataTable.Columns.Add(col2);
            //   dataTable.Columns.Add(col3);
            //   dataTable.Columns.Add(col4);
            //   dataTable.Columns.Add(col5);
            //   dataTable.Columns.Add(col6);
            //   dataTable.Columns.Add(col7);
            //   dataTable.Columns.Add(col8);
            //   dataTable.Columns.Add(col9);
            //   dataTable.Columns.Add(col10);
            //   foreach (DataGridViewRow dataGridViewRow in _dgrvThongTinSanPham.Rows)
            //   {
            //       DataRow dtrow = dataTable.NewRow();
            //       dtrow[0] = dataGridViewRow.Cells[0].Value;
            //        dtrow[1] = dataGridViewRow.Cells[1].Value;
            //       dtrow[2] = dataGridViewRow.Cells[2].Value;
            //       dtrow[3] = dataGridViewRow.Cells[3].Value;
            //       dtrow[4] = dataGridViewRow.Cells[4].Value;
            //       dtrow[5] = dataGridViewRow.Cells[5].Value;
            //       dtrow[6] = dataGridViewRow.Cells[6].Value;
            //       dtrow[7] = dataGridViewRow.Cells[7].Value;
            //       dtrow[8] = dataGridViewRow.Cells[8].Value;
            //       dtrow[9] = dataGridViewRow.Cells[9].Value;
            //       dataTable.Rows.Add(dtrow);
            //   }
            //   Export(dataTable,"Danh Sách","Danh Sách Sản Phẩm");  
            //}

            //private void Export(DataTable dataTable, string sheetName, string title)
            //{
            ////Tạo các đối tượng Excel

            //Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            //Microsoft.Office.Interop.Excel.Workbooks oBooks;

            //Microsoft.Office.Interop.Excel.Sheets oSheets;

            //Microsoft.Office.Interop.Excel.Workbook oBook;

            //Microsoft.Office.Interop.Excel.Worksheet oSheet;

            ////Tạo mới một Excel WorkBook 

            //oExcel.Visible = true;

            //oExcel.DisplayAlerts = false;

            //oExcel.Application.SheetsInNewWorkbook = 1;

            //oBooks = oExcel.Workbooks;

            //oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            //oSheets = oBook.Worksheets;

            //oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            //oSheet.Name = sheetName;

            //// Tạo phần Tiêu đề
            //Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            //head.MergeCells = true;

            //head.Value2 = title;

            //head.Font.Bold = true;

            //head.Font.Name = "Times New Roman";

            //head.Font.Size = "20";

            //head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //// Tạo tiêu đề cột 

            //Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            //cl1.Value2 = "Tên Màu Sắc";

            //cl1.ColumnWidth = 12;

            //Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            //cl2.Value2 = "Tên Nhà Sản Xuất";

            //cl2.ColumnWidth = 25.0;

            //Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            //cl3.Value2 = "Tên Size";
            //cl3.ColumnWidth = 12.0;

            //Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            //cl4.Value2 = "Tên Hãng giày";

            //cl4.ColumnWidth = 10.5;

            //Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            //cl5.Value2 = "Kích Cỡ";

            //cl5.ColumnWidth = 20.5;

            //Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            //cl6.Value2 = "Tên Giày";

            //cl6.ColumnWidth = 18.5;

            //Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            //cl7.Value2 = "Mô tả";

            //cl7.ColumnWidth = 13.5;
            //Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");
            //cl8.Value2 = "Giá Bán";

            //cl8.ColumnWidth = 13.5;
            //Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");
            //cl9.Value2 = "Giá Nhập";

            //cl9.ColumnWidth = 13.5;
            //Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");
            //cl10.Value2 = "Số Lượng Tồn";

            //cl10.ColumnWidth = 13.5;

            //Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");

            //rowHead.Font.Bold = true;

            //// Kẻ viền

            //rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //// Thiết lập màu nền

            //rowHead.Interior.ColorIndex = 6;

            //rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //// Tạo mảng theo datatable

            //object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            ////Chuyển dữ liệu từ DataTable vào mảng đối tượng

            //for (int row = 0; row < dataTable.Rows.Count; row++)
            //{
            //    DataRow dataRow = dataTable.Rows[row];

            //    for (int col = 0; col < dataTable.Columns.Count; col++)
            //    {
            //        arr[row, col] = dataRow[col];
            //    }
            //}

            ////Thiết lập vùng điền dữ liệu

            //int rowStart = 4;

            //int columnStart = 1;

            //int rowEnd = rowStart + dataTable.Rows.Count - 2;

            //int columnEnd = dataTable.Columns.Count;

            //// Ô bắt đầu điền dữ liệu

            //Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            //// Ô kết thúc điền dữ liệu

            //Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            //// Lấy về vùng điền dữ liệu

            //Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            ////Điền dữ liệu vào vùng đã thiết lập

            //range.Value2 = arr;

            //// Kẻ viền

            //range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            //// Căn giữa cột mã nhân viên

            ////Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            ////Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            ////Căn giữa cả bảng 
            //oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //}
            #endregion Region

        }

        private void btn_save_Click(object sender, EventArgs e)
        {


            DialogResult thongbao = MessageBox.Show("bạn có muốn lưu Không ", "thông báo", MessageBoxButtons.YesNo);
            if (thongbao == DialogResult.Yes)
            {
                for (int i = 0; i < _dgrvThongTinSanPham.Rows.Count; i++)
                {
                    TenMausac = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[0].Value);
                    TenNSX = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[1].Value);
                    TenSize = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[2].Value);
                    TenHangGiay = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[3].Value);
                    KichCo = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[4].Value);
                    TenGiay = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[5].Value);
                    Mota = Convert.ToString(_dgrvThongTinSanPham.Rows[i].Cells[6].Value);
                    GiaNhap = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[7].Value);
                    GiaBan = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[8].Value);
                    SoluongTon = Convert.ToInt32(_dgrvThongTinSanPham.Rows[i].Cells[9].Value);
                    ;
                }



            }
            MauSac? idmausac = _MauSac.GetAll().FirstOrDefault(c => c.TenMauSac == TenMausac);
            Nsx? idnsx = _Nsx.GetAll().FirstOrDefault(c => c.TenNsx == TenNSX);
            A_DAL.Entities.Size? idsize = _Size.GetAll().FirstOrDefault(c => c.TenSize == TenSize);
            HangGiay? idhanggiay = _hangGiay.GetAll().FirstOrDefault(c => c.TenHangGiay == TenHangGiay);
            ChieuCaoDeGiay? idkichco = _ChieuCaoDeGiay.GetAll().FirstOrDefault(c => c.KichCo == KichCo);
            Giay? idTenGiay = _Giay.GetAll().FirstOrDefault(c => c.TenGiay == TenGiay);
            ChiTietGiay chitsanpham = new()
            {
                Id = Guid.NewGuid(),
                IdMauSac = Guid.NewGuid(),
                IdNsx = Guid.NewGuid(),
                IdSize = Guid.NewGuid(),
                IdHangGiay = Guid.NewGuid(),
                IdChieuCaoDeGiay = Guid.NewGuid(),
                IdGiay = Guid.NewGuid(),
                MoTa = Mota,
                GiaNhap = GiaNhap,
                GiaBan = GiaBan,
                SoLuongTon = SoluongTon
            };
            _ = _ChiTietGiay.Add(chitsanpham);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private bool checkeds()
        {
            if (string.IsNullOrEmpty(cmb_theloai.Texts))
            {
                 MessageBox.Show("Vui Lòng Chọn Thể Loại");
                return false;
            }

          

            return true;
        }
        private void btn_themtheloai_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkeds() == false)
                {
                    return;
                }

                DialogResult thongbao =
                    MessageBox.Show("Thông Báo", "Bạn có Muốn Thêm Thể Loại", MessageBoxButtons.YesNo);
                if (thongbao == DialogResult.Yes)
                {

                    TheLoai? idtheloais = _theloai.GetAll().FirstOrDefault(c => c.MaTheLoai == cmb_theloai.Texts);
                    Guid Idchitietgiay = Idwhenclick;
                    Guid idtheloai = idtheloais.Id;
                    //var idchitietthloai = _ChiTietTheLoai.GetAllView().FirstOrDefault(c => c.ChiTietTheLoai.IdTheLoai == idtheloai);
                    //var idchitt = idchitietthloai.ChiTietTheLoai.IdTheLoai;
                    //if (_Ichotiett.checkma(idchitt)==false)
                    //{
                    //    MessageBox.Show("Mã Trùng");
                    //    return;
                    //}
                    if (_Ichotiett.Add(new ChiTietTheLoai()
                        {
                            IdChiTietGiay = Idwhenclick,
                            IdTheLoai = idtheloai,
                        }))
                    {
                        MessageBox.Show("THêm thành công");
                        return;
                    }

                    _Ichotiett.Add(new ChiTietTheLoai()
                    {
                        IdChiTietGiay = Idwhenclick,
                        IdTheLoai = idtheloai,
                    });
                }
            }
            catch (Exception es)
            {
                MessageBox.Show("Không đc trùng");
            }



        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            //SaveFileDialog saveFileDialog = new()
            //{
            //    Title = "Export Excel",
            //    Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003(*.xls)|*.xls"
            //};
            //if (saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        xuatExcel(saveFileDialog.FileName, _dgrvThongTinSanPham);
            //        _ = MessageBox.Show("Xuất file thành công");
            //    }
            //    catch (Exception ex)
            //    {
            //        _ = MessageBox.Show("Xuất file không thành công \n " + ex.Message);
            //    }
            //}
        }
        public void xuatExcel(string path, DataGridView _dgrvthongtin)
        {

            try
            {
                if (_dgrvthongtin.Rows.Count > 0)
                {
                    Excel.Application application = new();
                    _ = application.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < _dgrvthongtin.Columns.Count + 1; i++)
                    {
                        application.Cells[1, i] = _dgrvthongtin.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < _dgrvthongtin.Rows.Count; i++)
                    {
                        for (int j = 0; j < _dgrvthongtin.Columns.Count; j++)
                        {
                            application.Cells[i + 2, j + 1] = _dgrvthongtin.Rows[i].Cells[j].Value;
                        }
                    }

                    _ = application.Columns.AutoFit();
                    application.Visible = true;
                    application.ActiveWorkbook.SaveCopyAs(path);
                    application.ActiveWorkbook.Saved = true;
                }
            }
            catch (Exception x)
            {

                _ = MessageBox.Show(x.Message);
            }

        }

        private void _rjtbxGiaNhap__TextChanged(object sender, EventArgs e)
        {
            if (_rjtbxGiaNhap == null)
            {
                _ = MessageBox.Show("Không Được Để Trống");
            }
        }

        private Image anhsp;
        private void btn_linkanh_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new();
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap image = ResizeImage(Image.FromFile(open.FileName), pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = image;
                    anhsp = image;
                }
            }
            catch (Exception ex)
            {

                _ = MessageBox.Show(Convert.ToString(ex.Message), "Liên hệ với Phong để khắc phục");
            }
        }
        public static byte[] converterDemo(Image x)
        {
            ImageConverter _imageConverter = new();
            byte[] xByte = (byte[])_imageConverter.ConvertTo(x, typeof(byte[]));
            return xByte;
        }

      
    }
}
