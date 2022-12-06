using B_BUS.IServices;
using B_BUS.Services;
using B_BUS.View_Models;
using Size = A_DAL.Entities.Size;

namespace C_GUI.QLForm
{
    public partial class FormSize : Form
    {

        public IQLSize _IQLSize;
        private Guid _ID;



        public FormSize()
        {
            _IQLSize = new QLSize();
            InitializeComponent();
            LoadData(_IQLSize.GetAllView());
        }
        public void LoadData(List<SizeView> sizeViews)
        {
            int stt = 1;
            dgrid_showSize.ColumnCount = 5;
            dgrid_showSize.Columns[0].Name = "stt";
            dgrid_showSize.Columns[1].Name = "id";
            dgrid_showSize.Columns[2].Name = "ma";
            dgrid_showSize.Columns[3].Name = "ten";
            dgrid_showSize.Columns[4].Name = "so sile";
            dgrid_showSize.Rows.Clear();
            dgrid_showSize.Columns[1].Visible = true;
            foreach (SizeView a in sizeViews)
            {

                _ = dgrid_showSize.Rows.Add(stt++,a.Size.Id, a.Size.MaSize, a.Size.TenSize,a.Size.SoSize, a.Size.TrangThai == 1 ? "hoạt động" : "Không hoạt động");
            }

        }

        public Size GetvaluaContro()
        {
            return new Size()
            {
                MaSize = txt_ma.Texts,
                TenSize = txt_ten.Texts,
                SoSize =int.Parse(txt_sosize.Texts),
                TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0,
            };
        }
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _ = _IQLSize.Add(GetvaluaContro());
                LoadData(_IQLSize.GetAllView());
            }

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQLSize.Update(new A_DAL.Entities.Size() { Id = _ID,
                    MaSize = txt_ma.Texts,
                    TenSize = txt_ten.Texts,
                    SoSize = int.Parse(txt_sosize.Texts),
                    TrangThai = rbtn_hoatdong.Checked == true ? 1 : 0});
                if (thongBao)
                {
                    _ = MessageBox.Show("Sửa thành công");
                    LoadData(_IQLSize.GetAllView());
                }
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQLSize.Delete(_IQLSize.GetAll().Find(c => c.Id == _ID));
                if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadData(_IQLSize.GetAllView());
                }
            }
            
        }

       

        private void txt_timkiem__TextChanged(object sender, EventArgs e)
        {
            LoadData(_IQLSize.GetAllView().Where(c => (c.Size.TenSize.ToLower().Contains(txt_timkiem.Texts.ToLower()) || c.Size.MaSize.ToLower().Contains(txt_timkiem.Texts.ToLower()))).ToList());
        }

        private void dgrid_showSize_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_showSize.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts =dgrid_showSize.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_showSize.Rows[index].Cells[3].Value.ToString();
            txt_sosize.Texts = dgrid_showSize.Rows[index].Cells[4].Value.ToString();
            if (dgrid_showSize.Rows[index].Cells[4].Value.ToString() == "hoat dong")
            {
                rbtn_hoatdong.Checked = true;
            }
            if (dgrid_showSize.Rows[index].Cells[4].Value.ToString() == "khong hoat dong")
            {
                rbtn_khonghoatdong.Checked = true;
            }
        }
    }
    }


