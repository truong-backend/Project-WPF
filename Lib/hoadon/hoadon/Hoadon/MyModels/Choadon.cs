using Hoadon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoadon.MyModels
{
    internal class Choadon
    {
        public Choadon()//sua
        {
            Chitiethoadons = new HashSet<Cchitiethoadon>();//sua
        }

        public string Sohd { get; set; }
        public DateTime? Ngaylaphd { get; set; }
        public string Tenkh { get; set; }

        public double Thanhtien
        {
            get
            {
                return Chitiethoadons.Sum(t => t.Thanhtien);
            }
        }
        public virtual ICollection<Cchitiethoadon> Chitiethoadons { get; set; }//sua
        public static Choadon chuyendoi(Hoadon.Models.Hoadon x)
        {
            return new Choadon()
            {
                Sohd = x.Sohd,
                Ngaylaphd = x.Ngaylaphd,
                Tenkh = x.Tenkh,
                Chitiethoadons = x.Chitiethoadons.Select(t => Cchitiethoadon.chuyendoi(t)).ToList()
            };
        }
        public static Hoadon.Models.Hoadon chuyendoi(Choadon x)
        {
            return new Hoadon.Models.Hoadon()
            {
                Sohd = x.Sohd,
                Ngaylaphd = x.Ngaylaphd,
                Tenkh = x.Tenkh,
                Chitiethoadons = x.Chitiethoadons.Select(t => Cchitiethoadon.chuyendoi(t)).ToList()

            };


        }

    }
}
