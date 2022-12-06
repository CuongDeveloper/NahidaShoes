using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.View_Models
{
    public class ThongKeSanPhamBanChayView
    {
        public string MaHangHoas { get; set; }
        public string TenHangHoas { get; set; }
        public int? tongsos { get; set; }

        public string NgayLap { get; set; }
        public ThongKeSanPhamBanChayView(string ngaylap, string MaHangHoa, string TenHangHoa, int? tongso)
        {
            MaHangHoas = MaHangHoa;
            TenHangHoas = TenHangHoa;
            tongsos = tongso;

            NgayLap = ngaylap;
        }
    }
}
