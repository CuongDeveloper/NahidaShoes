using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormGiay : Form
    {
        public IQLGiay _IQLGiay;
        private Guid _ID;


        public FormGiay()
        {
            _IQLGiay = new QLGiay();
            InitializeComponent();
            LoadData(_IQLGiay.GetAllView());
            cbx_hoatdong.Checked = true;
            txt_ma.Enabled = false;
        }
        public void LoadData(List<GiayView> giayViews)
        {
            int stt = 1;
            dgrid_showGiay.ColumnCount = 5;

            dgrid_showGiay.Columns[0].Name = "stt";
            dgrid_showGiay.Columns[1].Name = "id";
            dgrid_showGiay.Columns[2].Name = "ma";
            dgrid_showGiay.Columns[3].Name = "ten";
            dgrid_showGiay.Columns[4].Name = "trang thai";
            dgrid_showGiay.Rows.Clear();
            dgrid_showGiay.Columns[1].Visible = true;
            dgrid_showGiay.AllowUserToAddRows = false;
            foreach (GiayView a in giayViews)
            {

                _ = dgrid_showGiay.Rows.Add(stt++, a.Giay.Id, a.Giay.MaGiay, a.Giay.TenGiay, a.Giay.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
            }

        }

        public Giay GetvaluaContro()
        {
            return new Giay()
            {
                MaGiay = (_IQLGiay.GetAll().Count + 1).ToString(),
                TenGiay = txt_ten.Texts,
                TrangThai = cbx_hoatdong.Checked == true ? 1 : 0,
            };
        }
        private void dgrid_showGiay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_showGiay.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_showGiay.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_showGiay.Rows[index].Cells[3].Value.ToString();
            if (dgrid_showGiay.Rows[index].Cells[4].Value.ToString() == "hoat dong")
            {
                cbx_hoatdong.Checked = true;
            }
            if (dgrid_showGiay.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
            {
                cbx_khonghoatdong.Checked = true;
            }
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
                    _ = _IQLGiay.Add(GetvaluaContro());
                    LoadData(_IQLGiay.GetAllView());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Đầu Vào");
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
                    bool thongBao = _IQLGiay.Update(new A_DAL.Entities.Giay() { Id = _ID, MaGiay = txt_ma.Texts, TenGiay = txt_ten.Texts, TrangThai = cbx_hoatdong.Checked == true ? 1 : 0 });
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Sửa thành công");
                        LoadData(_IQLGiay.GetAllView());
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Vui Lòng Chọn Lại Đầu vào ");
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQLGiay.Delete(_IQLGiay.GetAll().Find(c => c.Id == _ID));
                if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadData(_IQLGiay.GetAllView());
                }
            }

        }

        private void txt_timkiem__TextChanged(object sender, EventArgs e)
        {
            LoadData(_IQLGiay.GetAllView().Where(c => c.Giay.MaGiay.ToLower().Contains(txt_timkiem.Texts.ToLower()) || c.Giay.TenGiay.ToLower().Contains(txt_timkiem.Texts.ToLower())).ToList());
        }
    }
}
