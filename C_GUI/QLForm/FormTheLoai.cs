using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;

namespace C_GUI.QLForm
{
    public partial class FormTheLoai : Form
    {
        public IQLTheLoai _QlTheLoai;
        private Guid _ID;
        public FormTheLoai()
        {
            InitializeComponent();
            _QlTheLoai = new QLTheLoai();
        }
        public void LoadData()
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
            foreach (B_BUS.View_Models.TheLoaiView a in _QlTheLoai.GetAllView())
            {
                _ = dgrid_show.Rows.Add(stt++, a.TheLoai.Id, a.TheLoai.MaTheLoai, a.TheLoai.TenTheLoai, a.TheLoai.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }

        public TheLoai GetvaluaContro()
        {
            return new TheLoai()
            {
                MaTheLoai = txt_ma.Texts,
                TenTheLoai = txt_ten.Texts,
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
            _ = _QlTheLoai.Add(GetvaluaContro());
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool thongBao = _QlTheLoai.Update(new A_DAL.Entities.TheLoai() { Id = _ID, MaTheLoai = txt_ma.Texts, TenTheLoai = txt_ten.Texts, TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0 });
            if (thongBao)
            {
                _ = MessageBox.Show("Sửa thành công");
                LoadData();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            bool thongBao = _QlTheLoai.Delete(_QlTheLoai.GetAll().Find(c => c.Id == _ID));
            if (thongBao)
            {
                _ = MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }

        private void txt_timkiem__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
