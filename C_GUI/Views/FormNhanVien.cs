using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.Views
{
    public partial class FormNhanVien : Form
    {
        private readonly IQLNhanVien _qlNhanVien;

        public FormNhanVien()
        {
            InitializeComponent();
            LoadThongTinNhanVien();
            _qlNhanVien = new QLNhanVien();
        }

        private void LoadThongTinNhanVien()
        {
            string thongTinNhanVien = "";
            thongTinNhanVien += "Mã nhân viên: " + TrangChu.NhanVienLogin.MaNhanVien;
            thongTinNhanVien += "\nTên nhân viên: " + TrangChu.NhanVienLogin.TenNhanVien;
            thongTinNhanVien += "\nGiới tính: " + (TrangChu.NhanVienLogin.GioiTinh == 0 ? "Nữ" : "Nam");
            thongTinNhanVien += "\nĐịa chỉ: " + TrangChu.NhanVienLogin.DiaChi;
            thongTinNhanVien += "\nEmail: " + (TrangChu.NhanVienLogin.Email ?? "Không xác định");
            thongTinNhanVien += "\nNgày sinh: " + TrangChu.NhanVienLogin.NgaySinh.ToString("dd/MM/yyyy");
            thongTinNhanVien += "\nSố điện thoại: " + TrangChu.NhanVienLogin.Sdt;
            _lblThongTinNhanVien.Text = thongTinNhanVien;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = _qlNhanVien.GetAll().FirstOrDefault(c => c.Id == TrangChu.NhanVienLogin.Id);
            if (nhanVien.MatKhau == _tbxCu.Texts.Trim())
            {
                if (_tbxMoi.Texts.Trim() != "")
                {
                    if (_tbxMoi.Texts.Trim() == _tbxMoi1.Texts.Trim())
                    {
                        nhanVien.MatKhau = _tbxMoi1.Texts.Trim();
                        _ = _qlNhanVien.Update(nhanVien);
                        _ = MessageBox.Show("Đổi mật khẩu thành công");
                    }
                    else
                    {
                        _ = MessageBox.Show("Hai mật khẩu không khớp");
                    }
                }
                else
                {
                    _ = MessageBox.Show("Mật khẩu mới không được để trống");
                }
            }
            else
            {
                _ = MessageBox.Show("Mật khẩu cũ không đúng");
            }
        }
    }
}
