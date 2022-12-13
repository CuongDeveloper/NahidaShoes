using System.Text.RegularExpressions;
using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormKhachHang : Form
    {
        public IQLKhachHang _IQLKhachHang;
        private Guid _ID;


        public FormKhachHang()
        {
            _IQLKhachHang = new QLKhachHang();
            InitializeComponent();
            LoadData();
            cbx_hoatdong.Checked = true;
            txt_ma.Enabled =false;
        }
        public void LoadData()
        {
            int stt = 1;
            dgrid_showKhachHang.ColumnCount = 10;
            dgrid_showKhachHang.Columns[0].Name = "stt";
            dgrid_showKhachHang.Columns[1].Name = "id";
            dgrid_showKhachHang.Columns[2].Name = "ma";
            dgrid_showKhachHang.Columns[3].Name = "ten";
            dgrid_showKhachHang.Columns[4].Name = "email";
            dgrid_showKhachHang.Columns[5].Name = "ngay sinh";
            dgrid_showKhachHang.Columns[6].Name = "sdt";
            dgrid_showKhachHang.Columns[7].Name = "dia chi";
            dgrid_showKhachHang.Columns[8].Name = "Số CCCD";
            dgrid_showKhachHang.Columns[9].Name = "trang thai";
            dgrid_showKhachHang.Rows.Clear();
            dgrid_showKhachHang.Columns[1].Visible = true;
            dgrid_showKhachHang.AllowUserToAddRows = false;
            foreach (KhachHangView a in _IQLKhachHang.GetAllView())
            {

                _ = dgrid_showKhachHang.Rows.Add(stt++, a.Khach.Id, a.Khach.MaKhachHang, a.Khach.TenKhachHang, a.Khach.Email, a.Khach.NgaySinh, a.Khach.Sdt, a.Khach.DiaChi,a.Khach.SoCCCD, a.Khach.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
            }

        }
        public KhachHang GetvaluaContro()
        {
            return new KhachHang()
            {
                MaKhachHang = (_IQLKhachHang.GetAll().Count + 1).ToString(),
                TenKhachHang = txt_ten.Text,
                Email = txt_email.Text,
                NgaySinh = dtt_ngaysinh.Value,
                Sdt = txt_sdt.Text,
                DiaChi = txt_diachi.Texts,
                SoCCCD = tbx_socccd.Texts,
                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,

            };
        }
        private void dgrid_showKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_showKhachHang.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_showKhachHang.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_showKhachHang.Rows[index].Cells[3].Value.ToString();

            dtt_ngaysinh.Value = (DateTime)dgrid_showKhachHang.Rows[index].Cells[5].Value;
            txt_sdt.Text = dgrid_showKhachHang.Rows[index].Cells[6].Value.ToString();
            txt_diachi.Texts = dgrid_showKhachHang.Rows[index].Cells[7].Value.ToString();
            tbx_socccd.Texts = dgrid_showKhachHang.Rows[index].Cells[8].Value.ToString();


            KhachHang a = _IQLKhachHang.GetAllView().FirstOrDefault(c => c.Khach.Id == _ID).Khach;

            ;
            if (dgrid_showKhachHang.Rows[index].Cells[8].Value.ToString() == "hoạt động")
            {
                cbx_hoatdong.Checked = true;
                cbx_khonghoatdong.Checked = false;
            }
            if (dgrid_showKhachHang.Rows[index].Cells[8].Value.ToString() == "không hoạt động")
            {
                cbx_hoatdong.Checked = false;
                cbx_khonghoatdong.Checked = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ten.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Không Để Trống");
                return;
            }

            if (string.IsNullOrEmpty(txt_diachi.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Không Để Trống");
                return;
            }
            if (string.IsNullOrEmpty(txt_email.Texts))
            {
                _ = MessageBox.Show("Vui Lòng Không Để Trống");
                return;
            }
            if (Regex.IsMatch(txt_ten.Texts.Trim(), @"[0-9]+") == true)
            {

                MessageBox.Show("Tên Không chứa Số ", "ERR");
                return;
            }
            if (Regex.IsMatch(txt_email.Texts, (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) == false)
            {

                MessageBox.Show("Email Phải đúng dịnh dạng", "ERR");
                return;
            }
            _ = _IQLKhachHang.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQLKhachHang.Update(new A_DAL.Entities.KhachHang() { Id = _ID, MaKhachHang = txt_ma.Text, TenKhachHang = txt_ten.Text, TrangThai = cbx_hoatdong.Checked == true ? 1 : 0 });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _IQLKhachHang.Delete(_IQLKhachHang.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }


    }
}
