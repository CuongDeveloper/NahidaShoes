using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.Views
{
    public partial class FormChucVu : Form
    {
        public IQLChucVu _IQlChucVu;
        private Guid _ID;
        public FormChucVu()
        {
            _IQlChucVu = new QLChucVu();
            InitializeComponent();
            LoadData(_IQlChucVu.GetAllView());
            rbtn_hoatdong.Checked = true;
            txt_ma.Enabled=false;
        }
        public void LoadData(List<ChucVuView> chucVuViews)
        {
            int stt = 1;
            dgrid_show.ColumnCount = 5;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "ma";
            dgrid_show.Columns[3].Name = "ten";
            dgrid_show.Columns[4].Name = "trang thai";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = false;
            dgrid_show.AllowUserToAddRows = false;
            foreach (B_BUS.View_Models.ChucVuView a in chucVuViews)
            {
                _ = dgrid_show.Rows.Add(stt++, a.ChucVu.Id, a.ChucVu.MaChucVu, a.ChucVu.TenChucVu, a.ChucVu.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }

        public ChucVu GetvaluaContro()
        {
            return new ChucVu()
            {
                MaChucVu = txt_ma.Texts,
                TenChucVu = txt_ten.Texts,
                TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0,
            };
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

        private void btn_them_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                _ = _IQlChucVu.Add(GetvaluaContro());
                LoadData(_IQlChucVu.GetAllView());
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQlChucVu.Update(new A_DAL.Entities.ChucVu() { Id = _ID, MaChucVu = txt_ma.Texts, TenChucVu = txt_ten.Texts, TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0 });
                if (thongBao)
                {
                    _ = MessageBox.Show("Sửa thành công");
                    LoadData(_IQlChucVu.GetAllView());
                }
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQlChucVu.Delete(_IQlChucVu.GetAll().Find(c => c.Id == _ID));
                if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadData(_IQlChucVu.GetAllView());
                }
            }

        }

        private void txt_timkiem_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void txt_timkiem__TextChanged(object sender, EventArgs e)
        {
            LoadData(_IQlChucVu.GetAllView().Where(c => c.ChucVu.TenChucVu.ToLower().Contains(txt_timkiem.Texts.ToLower()) || c.ChucVu.MaChucVu.ToLower().Contains(txt_timkiem.Texts.ToLower())).ToList());
        }
    }
}
