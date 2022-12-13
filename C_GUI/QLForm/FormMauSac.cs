using A_DAL.Entities;
using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;

namespace C_GUI.QLForm
{
    public partial class FormMauSac : Form
    {
        public IQLMauSac _IQlMauSac;
        private Guid _ID;
        public FormMauSac()
        {
            _IQlMauSac = new QLMauSac();
            InitializeComponent();
            LoadData(_IQlMauSac.GetAllView());
        }
        public void LoadData(List<MauSacView> lstMausacView)
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
            foreach (B_BUS.View_Models.MauSacView a in lstMausacView)
            {
                _ = dgrid_show.Rows.Add(stt++, a.MauSac.Id, a.MauSac.MaMauSac, a.MauSac.TenMauSac, a.MauSac.TrangThai == 1 ? "hoat dong" : "khong hoat dong");
            }

        }

        public MauSac GetvaluaContro()
        {
            return new MauSac()
            {
                MaMauSac = txt_ma.Texts,
                TenMauSac = txt_ten.Texts,
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
                _ = _IQlMauSac.Add(GetvaluaContro());
                LoadData(_IQlMauSac.GetAllView());
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQlMauSac.Update(new A_DAL.Entities.MauSac() { Id = _ID, MaMauSac = txt_ma.Texts, TenMauSac = txt_ten.Texts, TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0 });
                if (thongBao)
                {
                    _ = MessageBox.Show("Sửa thành công");
                    LoadData(_IQlMauSac.GetAllView());
                }
            }

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool thongBao = _IQlMauSac.Delete(_IQlMauSac.GetAll().Find(c => c.Id == _ID));
                    if (thongBao)
                    {
                        _ = MessageBox.Show("Xóa thành công");
                        LoadData(_IQlMauSac.GetAllView());
                    }
                }
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message);
            }
        }

        private void _tbxTimKiem__TextChanged(object sender, EventArgs e)
        {
            LoadData(_IQlMauSac.GetAllView().Where(c => c.MauSac.TenMauSac.ToLower().Contains(_tbxTimKiem.Texts.ToLower()) || c.MauSac.MaMauSac.ToLower().Contains(_tbxTimKiem.Texts.ToLower())).ToList());
        }
    }
}
