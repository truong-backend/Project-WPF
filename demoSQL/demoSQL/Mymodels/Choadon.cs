using demoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoSQL.Mymodels
{
    class Choadon
    {
        public Choadon()
        {
            Chitiethoadons = new HashSet<Cchitiethoadon>();
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

        public virtual ICollection<Cchitiethoadon> Chitiethoadons { get; set; }

        public static Choadon chuyendoi(Hoadon x)
        {
            return new Choadon
            {
                Sohd = x.Sohd,
                Ngaylaphd = x.Ngaylaphd,
                Tenkh = x.Tenkh,
                Chitiethoadons = x.Chitiethoadons.Select(t => Cchitiethoadon.chuyendoi(t)).ToList()
            };
        }


        public static Hoadon chuyendoi(Choadon x)
        {
            return new Hoadon
            {
                Sohd = x.Sohd,
                Ngaylaphd = x.Ngaylaphd,
                Tenkh = x.Tenkh,
                Chitiethoadons = x.Chitiethoadons.Select(t => Cchitiethoadon.chuyendoi(t)).ToList()
            };
        }
        public static Choadon saochep(Choadon x)
        {
            Choadon hd = new Choadon();
            hd.Sohd = x.Sohd;
            hd.Ngaylaphd = x.Ngaylaphd;
            hd.Tenkh = x.Tenkh;
            foreach (Cchitiethoadon c in x.Chitiethoadons)
            {
                hd.Chitiethoadons.Add(c);
            }
            return hd;
        }
    }
}
