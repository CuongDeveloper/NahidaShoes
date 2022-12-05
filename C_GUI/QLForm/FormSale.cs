﻿using B_BUS.View_Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using B_BUS.IServices;
using B_BUS.Services;
using A_DAL.Entities;

namespace C_GUI.QLForm
{
    public partial class FormSale : Form
    {
        public IQLSale _IQlSale;
        public IQLChiTietSale _IQlChiTietSale;
        public IQLGiay _IQlGiay;
        public IQLChiTietGiay _IQlChiTietGiay;
        Guid _ID;
        public FormSale()
        {
            InitializeComponent();
            _IQlSale = new QLSale();
            _IQlChiTietSale = new QLChiTietSale();
            _IQlChiTietGiay = new QLChiTietGiay();
            _IQlGiay= new QLGiay();
            LoadData(_IQlSale.GetAllView());
            Loadcmb();
            LoadDataSale(_IQlChiTietSale.GetAllView());
            LoadDataSP();
            txt_ptgiam.Texts = "0";
            txt_sotiengiam.Texts = "0";
            txt_timkiemsale.Texts = "";

        }
        public void Loadcmb()
        {
            foreach (var a in _IQlSale.GetAll())
            {
                _ = cbb_sale.Items.Add(a.TenChuongTrinh);
            }
            foreach (var a in _IQlSale.GetAll())
            {
                _ = cmb_sale.Items.Add(a.TenChuongTrinh);
            }
            foreach (var a in _IQlGiay.GetAll())
            {
                _ = cbb_giay.Items.Add(a.TenGiay);
            }
            foreach (var a in _IQlGiay.GetAll())
            {
                _ = cmb_giay.Items.Add(a.TenGiay);
            }
            _ = cbb_trangthai.Items.Add("hoat dong");
                _ = cbb_trangthai.Items.Add("khong hoat dong");

        }
        public void LoadData(List<SaleView> saleViews)
        {
            int stt = 1;
            dgrid_show.ColumnCount = 9;
            dgrid_show.Columns[0].Name = "stt";
            dgrid_show.Columns[1].Name = "id";
            dgrid_show.Columns[2].Name = "mã giảm giá";
            dgrid_show.Columns[3].Name = "tên chương trình ";
            dgrid_show.Columns[4].Name = "% giảm giá";
            dgrid_show.Columns[5].Name = "số tiền giảm";
            dgrid_show.Columns[6].Name = "ngày bắt đầu";
            dgrid_show.Columns[7].Name = "ngày kết thúc";
            dgrid_show.Columns[8].Name = "trạng thái";
            dgrid_show.Rows.Clear();
            dgrid_show.Columns[1].Visible = false;
            foreach (var a in saleViews)
            {
                _ = dgrid_show.Rows.Add(stt++,a.Sale.Id,a.Sale.MaGiamGia,a.Sale.TenChuongTrinh,a.Sale.PhanTramGiamGia,a.Sale.SoTiemGiamGia,a.Sale.NgayBatDau,a.Sale.NgayKetThuc, (a.Sale.NgayBatDau<=DateTime.Now&&a.Sale.NgayKetThuc>=DateTime.Now)? "hoat dong" : "khong hoat dong");
            }
        }
        public void LoadDataSale(List<ChiTietSaleView> chiTietSaleViews)
        {
            int stt = 1;
            dgrid_SALE.ColumnCount =5;
            dgrid_SALE.Columns[0].Name = "stt";
            dgrid_SALE.Columns[1].Name = "id";
            dgrid_SALE.Columns[2].Name = "tên chương trình ";
            dgrid_SALE.Columns[3].Name = "Tên giày";
            dgrid_SALE.Columns[4].Name = "trạng thái";
            dgrid_SALE.Rows.Clear();
            dgrid_SALE.Columns[1].Visible = false;
            foreach (var a in chiTietSaleViews)
            {
                _ = dgrid_SALE.Rows.Add(stt++,a.ChiTietSale.Id, a.Sale.TenChuongTrinh,a.Giay.TenGiay, (a.Sale.NgayBatDau <= DateTime.Now && a.Sale.NgayKetThuc >= DateTime.Now) ? "hoat dong" : "khong hoat dong");
            }
        }
        public void LoadDataSP()
        {
            int stt = 1;
            dgrid_showsanpham.ColumnCount = 10;
            dgrid_showsanpham.Columns[0].Name = "Giá Nhập";
            dgrid_showsanpham.Columns[1].Name = "Giá bán";
            dgrid_showsanpham.Columns[2].Name = "Giá KM";
            dgrid_showsanpham.Columns[3].Name = "Giày";
            dgrid_showsanpham.Columns[4].Name = "Nsx";
            dgrid_showsanpham.Columns[5].Name = "Size";
            dgrid_showsanpham.Columns[6].Name = "Hãng Giày";
            dgrid_showsanpham.Columns[7].Name = "Chiều cao đế giày";
            dgrid_showsanpham.Columns[8].Name = "Màu sắc";
            dgrid_showsanpham.Columns[9].Name = "Số lượng tồn";

            dgrid_SALE.Rows.Clear();
            //foreach (var a in _IQlChiTietGiay.GetAllView())
            //{
            //    var b = _IQlChiTietSale.GetAllView().Find(c => c.ChiTietSale.IdChiTietGiay == a.ChiTietGiay.Id);
            //    var c = _IQlChiTietSale.GetAllView().Find(c => c.ChiTietSale.IdSale == b.Sale.Id);
            //    _ = dgrid_showsanpham.Rows.Add(stt++, a.ChiTietGiay.GiaNhap, b.ChiTietGiay.GiaBan, (((a.ChiTietGiay.GiaBan)) * ((c.Sale.PhanTramGiamGia) / 100) - (c.Sale.SoTiemGiamGia)), a.Giay.TenGiay, a.Nsx.TenNsx, a.Size.TenSize, a.HangGiay.TenHangGiay, a.ChieuCaoDeGiay.KichCo, a.MauSac.TenMauSac, a.ChiTietGiay.SoLuongTon);
            //}
        }
        public Sale GetvaluaContro()
        {
            return new Sale()
            {
                MaGiamGia = txt_ma.Texts,
                TenChuongTrinh = txt_ten.Texts,
                PhanTramGiamGia = float.Parse(txt_ptgiam.Texts),
                SoTiemGiamGia = float.Parse(txt_sotiengiam.Texts),
                NgayBatDau = dtp_ngaybatdau.Value,
                NgayKetThuc = dtp_ngayketthuc.Value,
                TrangThai = (dtp_ngaybatdau.Value <= DateTime.Now && dtp_ngayketthuc.Value >= DateTime.Now) ? 0 : 1,
            };
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            try
            {
                float giamGia = Convert.ToSingle(txt_ptgiam.Texts);
                float tienKhachDua = Convert.ToSingle(txt_sotiengiam.Texts);
                ;
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại các giá trị đầu vào");
                return;
            }
            if (dtp_ngaybatdau.Value < (DateTime.Today) || dtp_ngayketthuc.Value < dtp_ngaybatdau.Value)
            {
                _ = MessageBox.Show("Kiểm tra lại lịch");
                return;
            }
            

            if (int.Parse(txt_ptgiam.Texts) < 0 || int.Parse(txt_ptgiam.Texts) > 100)
            {
                _ = MessageBox.Show("Kiểm tra lại số %");
                return;
            }
            try
            {
               
            }
            catch (Exception)
            {
                _ = MessageBox.Show("Kiểm tra lại ngày và hạn sử dụng");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {


                _ = _IQlSale.Add(GetvaluaContro());
                LoadData(_IQlSale.GetAllView());
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dtp_ngaybatdau.Value < DateTime.Now || dtp_ngayketthuc.Value < dtp_ngaybatdau.Value)
            {
                _ = MessageBox.Show("Kiểm tra lại lịch");
                return;
            }
            if (int.Parse(txt_ptgiam.Texts) < 0 || int.Parse(txt_ptgiam.Texts) > 100)
            {
                _ = MessageBox.Show("Kiểm tra lại số %");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQlSale.Update(new A_DAL.Entities.Sale() { Id = _ID, MaGiamGia = txt_ma.Texts, TenChuongTrinh = txt_ten.Texts,PhanTramGiamGia = float.Parse(txt_ptgiam.Texts),SoTiemGiamGia = float.Parse(txt_sotiengiam.Texts),NgayBatDau = dtp_ngaybatdau.Value,NgayKetThuc = dtp_ngayketthuc.Value,TrangThai = (dtp_ngaybatdau.Value <= DateTime.Now && dtp_ngayketthuc.Value >= DateTime.Now) ? 0 : 1 });
                if (thongBao)
                {
                    _ = MessageBox.Show("Sửa thành công");
                    LoadData(_IQlSale.GetAllView());
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQlSale.Delete(_IQlSale.GetAll().Find(c => c.Id == _ID));
                
                    if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadData(_IQlSale.GetAllView());
                }
            }
        }

        private void dgrid_show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_show.Rows[index].Cells[1].Value.ToString());
            txt_ma.Texts = dgrid_show.Rows[index].Cells[2].Value.ToString();
            txt_ten.Texts = dgrid_show.Rows[index].Cells[3].Value.ToString();
            txt_ptgiam.Texts = dgrid_show.Rows[index].Cells[4].Value.ToString();
            txt_sotiengiam.Texts = dgrid_show.Rows[index].Cells[5].Value.ToString();
            dtp_ngaybatdau.Value = DateTime.Parse(dgrid_show.Rows[index].Cells[6].Value.ToString());
            dtp_ngayketthuc.Value = DateTime.Parse(dgrid_show.Rows[index].Cells[7].Value.ToString());
            
        }

        private void txt_timkiem__TextChanged(object sender, EventArgs e)
        {
            LoadData(_IQlSale.GetAllView().Where(c => (c.Sale.TenChuongTrinh.ToLower().Contains(txt_timkiem.Texts.ToLower())  || c.Sale.MaGiamGia.ToLower().Contains(txt_timkiem.Texts.ToLower()) || string.Format(c.Sale.PhanTramGiamGia.ToString()) == (txt_ptgiam.Texts) || string.Format(c.Sale.SoTiemGiamGia.ToString()) == (txt_sotiengiam.Texts))).ToList());
        }
        public ChiTietSale GetvaluaControSALE()
        {
            var x = _IQlSale.GetAllView().FirstOrDefault(c => c.Sale.TenChuongTrinh == cmb_sale.Texts);

            var y = _IQlGiay.GetAllView().FirstOrDefault(c => c.Giay.TenGiay == cmb_giay.Texts);

            var z = _IQlChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.IdGiay == y.Giay.Id);
            return new ChiTietSale()
            {
                IdSale = x.Sale.Id,
                IdChiTietGiay = z.ChiTietGiay.Id,
                TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1,
            };
        }
        

        private void btn_themsale_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn thêm", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _ = _IQlChiTietSale.Add(GetvaluaControSALE());
                LoadDataSale(_IQlChiTietSale.GetAllView());
            }
        }

        private void btn_suasale_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn sửa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                var x = _IQlSale.GetAllView().FirstOrDefault(c => c.Sale.TenChuongTrinh == cmb_sale.Texts);

                var y = _IQlGiay.GetAllView().FirstOrDefault(c => c.Giay.TenGiay == cmb_giay.Texts);

                var z = _IQlChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.IdGiay == y.Giay.Id);

                bool thongBao = _IQlChiTietSale.Update(new A_DAL.Entities.ChiTietSale() { Id = _ID,
                    IdSale = x.Sale.Id,
                    IdChiTietGiay = z.ChiTietGiay.Id,
                    TrangThai = (x.Sale.NgayBatDau <= DateTime.Now && x.Sale.NgayKetThuc >= DateTime.Now) ? 0 : 1,
                });
                if (thongBao)
                {
                    _ = MessageBox.Show("Sửa thành công");
                    LoadDataSale(_IQlChiTietSale.GetAllView());
                }
            }
        }

        private void btn_xoasale_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bool thongBao = _IQlChiTietSale.Delete(_IQlChiTietSale.GetAll().Find(c => c.Id == _ID));

                if (thongBao)
                {
                    _ = MessageBox.Show("Xóa thành công");
                    LoadDataSale(_IQlChiTietSale.GetAllView());
                }
            }
        }

        private void dgrid_SALE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            _ID = Guid.Parse(dgrid_SALE.Rows[index].Cells[1].Value.ToString());
            var a = _IQlChiTietSale.GetAllView().FirstOrDefault(c => c.ChiTietSale.Id == _ID);
            var b = _IQlChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.Id == a.ChiTietGiay.Id);
            cmb_sale.SelectedItem = _IQlChiTietSale.GetAllView().FirstOrDefault(c => c.ChiTietSale.IdSale == a.ChiTietSale.IdSale).Sale.TenChuongTrinh;
            cmb_giay.SelectedItem = _IQlChiTietGiay.GetAllView().FirstOrDefault(c => c.ChiTietGiay.Id==b.ChiTietGiay.Id).Giay.TenGiay;

        }

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataSale(_IQlChiTietSale.GetAllView().Where(c => (c.Sale.TenChuongTrinh.ToLower().Contains(txt_timkiem.Texts.ToLower()) || c.Sale.MaGiamGia.ToLower().Contains(txt_timkiem.Texts.ToLower()) || string.Format(c.Sale.PhanTramGiamGia.ToString()) == (txt_ptgiam.Texts) || string.Format(c.Sale.SoTiemGiamGia.ToString()) == (txt_sotiengiam.Texts))).ToList());
        }

        private void txt_timkiemsale__TextChanged(object sender, EventArgs e)
        {
            
            LoadDataSale(_IQlChiTietSale.GetAllView().Where(c => (c.Sale.TenChuongTrinh.ToLower().Contains(txt_timkiemsale.Texts.ToLower()) || c.Giay.TenGiay.ToLower().Contains(txt_timkiemsale.Texts.ToLower()))).ToList());
        }

        private void dgrid_showsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
