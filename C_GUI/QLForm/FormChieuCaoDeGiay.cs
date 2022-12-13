using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormChieuCaoDeGiay : Form
    {
        public IQLChieuCaoDeGiay _iQLChieuCaoDeGiay;
        private Guid _ID;
        public FormChieuCaoDeGiay()
        {
            _iQLChieuCaoDeGiay = new QLChieuCaoDeGiay();
            InitializeComponent();
            LoadData(_iQLChieuCaoDeGiay.GetAllView());
            rbtn_hoatdong.Checked = true;
            txt_ma.Enabled=false;
        }
        public void LoadData(List<ChieuCaoDeGiayView> chieuCaoDeGiayViews)
        {
            int stt = 1;
            dgrid_show.ColumnCount = 5;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "ma";
            dgrid_show.Columns[3].Name = "ten";
            dgrid_show.Columns[4].Name = "trang thai";
            dgrid_show.Rows.Clear();
            dgrid_show.AllowUserToAddRows=false;    
            dgrid_show.Columns[1].Visible = true;
            foreach (B_BUS.View_Models.ChieuCaoDeGiayView a in chieuCaoDeGiayViews)
            {
                _ = dgrid_show.Rows.Add(stt++, a.ChieuCaoDeGiay.Id, a.ChieuCaoDeGiay.MaKichCo, a.ChieuCaoDeGiay.KichCo, a.ChieuCaoDeGiay.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }
        public ChieuCaoDeGiay GetCtrlValues()
        {
            return new ChieuCaoDeGiay()
            {
                MaKichCo = (_iQLChieuCaoDeGiay.GetAll().Count + 1).ToString(),
                KichCo = Convert.ToInt32(txt_ten.Texts),
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
                    _ = _iQLChieuCaoDeGiay.Add(GetCtrlValues());
                    LoadData(_iQLChieuCaoDeGiay.GetAllView());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("vui Lòng điền đúng giá trị đầu vào");
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
                    bool thongBao = _iQLChieuCaoDeGiay.Update(new A_DAL.Entities.ChieuCaoDeGiay() { Id = _ID, MaKichCo = txt_ma.Texts, KichCo = Convert.ToInt32(txt_ten.Texts), TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0 });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Sửa thành công");
                        LoadData(_iQLChieuCaoDeGiay.GetAllView());
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("vui Lòng điền giá trị đầu vào");
            }
  

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _iQLChieuCaoDeGiay.Delete(_iQLChieuCaoDeGiay.GetAll().Find(c => c.Id == _ID));
                if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadData(_iQLChieuCaoDeGiay.GetAllView());
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
            LoadData(_iQLChieuCaoDeGiay.GetAllView().Where(c => c.ChieuCaoDeGiay.MaKichCo.ToLower().Contains(txt_timkiem.Texts.ToLower())).ToList());
        }
    }
}
