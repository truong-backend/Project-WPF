using buoi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace buoi2.MyModels
{
    class CHoaDon
    {
        public CHoaDon()
        {
            Chitiethoadons = new HashSet<CChiTietHoaDon>();
        }

        public string Sohd { get; set; }
        public DateTime? Ngaylaphd { get; set; }
        public string Tenkh { get; set; }

        //them
        public double Thanhtien
        {
            get
            {
                //tinh tong lai het thanh tien
                return Chitiethoadons.Sum(t => t.Thanhtien);
            }
        }

        public virtual ICollection<CChiTietHoaDon> Chitiethoadons { get; set; }

        public static CHoaDon chuyendoi(Hoadon x)
        {
            return new CHoaDon
            {
                Sohd = x.Sohd,
                Ngaylaphd=x.Ngaylaphd,
                Tenkh=x.Tenkh,
                Chitiethoadons=x.Chitiethoadons.Select(t=>CChiTietHoaDon.chuyendoi(t)).ToList()
            };
        }


        public static Hoadon chuyendoi(CHoaDon x)
        {
            return new Hoadon
            {
                Sohd = x.Sohd,
                Ngaylaphd = x.Ngaylaphd,
                Tenkh = x.Tenkh,
                Chitiethoadons = x.Chitiethoadons.Select(t => CChiTietHoaDon.chuyendoi(t)).ToList()
            };
        }
        public static CHoaDon saochep(CHoaDon x)
        {
            CHoaDon hd = new CHoaDon();
            hd.Sohd = x.Sohd;
            hd.Ngaylaphd = x.Ngaylaphd;
            hd.Tenkh = x.Tenkh;
            foreach(CChiTietHoaDon c in x.Chitiethoadons)
            {
                hd.Chitiethoadons.Add(c);
            }
            return hd;
        }

    }
}
