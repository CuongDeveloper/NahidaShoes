using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormHangGiay : Form
    {
        public IQLHangGiay _iQLHangGiay;
        private Guid _ID;
        public FormHangGiay()
        {
            _iQLHangGiay = new QLHangGiay();
            InitializeComponent();
            LoadData(_iQLHangGiay.GetAllView());
            txt_ma.Enabled = false;
            rbtn_hoatdong.Checked = true;

        }
        public void LoadData(List<HangGiayView> hangGiayViews)
        {
            int stt = 1;
            dgrid_show.ColumnCount = 5;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "ma";
            dgrid_show.Columns[3].Name = "ten";
            dgrid_show.Columns[4].Name = "trang thai";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = true;
            dgrid_show.AllowUserToAddRows = false;
            foreach (B_BUS.View_Models.HangGiayView a in hangGiayViews)
            {
                _ = dgrid_show.Rows.Add(stt++, a.HangGiay.Id, a.HangGiay.MaHangGiay, a.HangGiay.TenHangGiay, a.HangGiay.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }
        public HangGiay GetCtrlValues()
        {
            return new HangGiay()
            {
                MaHangGiay = (_iQLHangGiay.GetAll().Count + 1).ToString(),
                TenHangGiay = txt_ten.Texts,
                TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0,
            };
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ten.Texts))
                {
                    _ = MessageBox.Show("Vui Lòng Không Để Trống");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    _ = _iQLHangGiay.Add(GetCtrlValues());
                    LoadData(_iQLHangGiay.GetAllView());
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("vui Lòng Chọn lại Giá Trị Đầu Vào");
            }
           

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_ten.Texts))
                {
                    _ = MessageBox.Show("Vui Lòng Không Để Trống");
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool thongBao = _iQLHangGiay.Update(new A_DAL.Entities.HangGiay() { Id = _ID, MaHangGiay = txt_ma.Texts, TenHangGiay = txt_ten.Texts, TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0 });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Sửa thành công");
                        LoadData(_iQLHangGiay.GetAllView());
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Vui Lòng Nhập Giá Trị Đầu vào");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _iQLHangGiay.Delete(_iQLHangGiay.GetAll().Find(c => c.Id == _ID));
                if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadData(_iQLHangGiay.GetAllView());
                }
            }

        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
            if (dgrid_show.Rows[index].Cells[4].Value.ToString() == "hoat dong")
            {
                rbtn_hoatdong.Checked = true;
            }
            if (dgrid_show.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
            {
                rbtn_khonghoatdong.Checked = true;
            }
        }

        private void txt_timkiem__TextChanged(object sender, EventArgs e)
        {
            LoadData(_iQLHangGiay.GetAllView().Where(c => c.HangGiay.MaHangGiay.ToLower().Contains(txt_timkiem.Texts.ToLower()) || c.HangGiay.TenHangGiay.ToLower().Contains(txt_timkiem.Texts.ToLower())).ToList());
        }
    }
}
