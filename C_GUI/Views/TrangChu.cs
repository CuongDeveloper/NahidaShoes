using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using C_GUI.QLForm;

namespace C_GUI.Views
{
    public partial class TrangChu : Form
    {
        private Button? currentButton;
        private readonly Random random;
        private int tempIndex;
        private Form? activeForm;
        public static NhanVien? NhanVienLogin;
        private readonly IQLChucVu _qlChucVu;

        public TrangChu()
        {
            InitializeComponent();
            random = new Random();
            _rjbtndong.Visible = false;
            Customdesign();
            _qlChucVu = new QLChucVu();
            _lblThongTinNhanVien.Text = NhanVienLogin.MaNhanVien + " - " + NhanVienLogin.TenNhanVien + " - " + _qlChucVu.GetAll().FirstOrDefault(c => c.Id == NhanVienLogin.IdChucVu).TenChucVu;
        }

        private void Customdesign()
        {
            panelplaylizt.Visible = false;
        }

        private void Hidesubmenu()
        {
            if (panelplaylizt.Visible == true)
            {
                panelplaylizt.Visible = false;
            }
        }

        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                Hidesubmenu();
                submenu.Visible = true;

            }
            else
            {
                submenu.Visible = false;
            }
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                    _pnltitleBar.BackColor = color;
                    _rjbtndong.Visible = true;
                }
            }
        }
        private void ActivateButtons(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;

                    currentButton.ForeColor = Color.White;


                    _rjbtndong.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in _pnlmenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            activeForm?.Close();

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            _pnlDesktoppanel.Controls.Add(childForm);
            _pnlDesktoppanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            _lbltitle.Text = childForm.Text;
        }
        private void OpenChildForms(Form childForm, object btnSender)
        {
            activeForm?.Close();

            ActivateButtons(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            _pnlDesktoppanel.Controls.Add(childForm);
            _pnlDesktoppanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            _lbltitle.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            _lbltitle.Text = "HOME";
            _pnltitleBar.BackColor = Color.FromArgb(0, 150, 136);
            _pnllogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            _rjbtndong.Visible = false;
        }



        private void TrangChu_Load(object sender, EventArgs e)
        {
            Refresh();
        }


        private void _rjbtndong_Click_1(object sender, EventArgs e)
        {
            activeForm?.Close();
            Reset();
        }

        private void _btnBanhang_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FormBanHang(), sender);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            showsubmenu(panelplaylizt);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormMauSac(), sender);
            Hidesubmenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormNsx(), sender);
            Hidesubmenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormChieuCaoDeGiay(), sender);
            Hidesubmenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormTheLoai(), sender);
            Hidesubmenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormHangGiay(), sender);
            Hidesubmenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormChiTietGiay(), sender);
            Hidesubmenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormSanPham(), sender);
            Hidesubmenu();
        }

        private void _pnlmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            if (_qlChucVu.GetAll().FirstOrDefault(c => c.Id == NhanVienLogin.IdChucVu).MaChucVu != "QuanLi")
            {
                if (CheckChucVu())
                {
                    Application.Restart();
                }
                else
                {
                    return;
                }
            }
            OpenChildForms(new FormThongKe(), sender);
        }

        private void btn_banHang_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormBanHang(), sender);
        }

        private void btn_sanpham_Click_1(object sender, EventArgs e)
        {
            if (_qlChucVu.GetAll().FirstOrDefault(c => c.Id == NhanVienLogin.IdChucVu).MaChucVu != "QuanLi")
            {
                if (CheckChucVu())
                {
                    Application.Restart();
                }
                else
                {
                    return;
                }
            }
            showsubmenu(panelplaylizt);

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormNsx(), sender);
            Hidesubmenu();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormHangGiay(), sender);
            Hidesubmenu();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormSize(), sender);
            Hidesubmenu();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormChiTietGiay(), sender);
            Hidesubmenu();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormChieuCaoDeGiay(), sender);
            Hidesubmenu();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormTheLoai(), sender);
            Hidesubmenu();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            OpenChildForms(new FormSanPham(), sender);
            Hidesubmenu();
        }

        private void TrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.Login.Close();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            if (_qlChucVu.GetAll().FirstOrDefault(c => c.Id == NhanVienLogin.IdChucVu).MaChucVu != "QuanLi")
            {
                if (CheckChucVu())
                {
                    Application.Restart();
                }
                else
                {
                    return;
                }
            }
            OpenChildForms(new FormSale(), sender);
            Hidesubmenu();
        }

        private void _lblThongTinNhanVien_DoubleClick(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new();
            formNhanVien.Show();
        }

        private bool CheckChucVu()
        {
            DialogResult result = MessageBox.Show("Tài khoản của bạn không có quyền sử dụng tính năng này bấm OK để đăng xuất", "Thông báo", MessageBoxButtons.OKCancel);
            return result == DialogResult.OK;
        }
    }
}
