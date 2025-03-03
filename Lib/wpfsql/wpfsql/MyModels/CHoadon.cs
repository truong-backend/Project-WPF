using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfsql.Models;

namespace wpfsql.MyModels
{
    class CHoadon
    {
        public CHoadon() {
            Chitiethoadons = new HashSet<CChitiethoadon>();
        }
        public string Sohd { get; set; }
        public DateTime? Ngaylaphd { get; set; }
        public string Tenkh { get; set; }

        public double? ThanhTien {
            get
            {
                return Chitiethoadons.Sum(t => t.ThanhTien);
            }
        }
        public virtual ICollection<CChitiethoadon> Chitiethoadons { get; set; }
    }
}
