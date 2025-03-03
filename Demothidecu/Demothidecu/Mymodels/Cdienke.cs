using Demothidecu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demothidecu.Mymodels
{
    class Cdienke
    {
        public string Madk { get; set; }
        public DateTime? Ngaydk { get; set; }
        public string Makh { get; set; }

        public virtual Khachhang MakhNavigation { get; set; }

        public string Tenkh 
        {
            get
            {
                if (MakhNavigation == null) return string.Empty;
                else return MakhNavigation.Tenkh;
            }
        }
        public string Dienthoai 
        {
            get
            {
                if (MakhNavigation == null) return string.Empty;
                else return MakhNavigation.Dienthoai;
            }
        }
        public string Diachi 
        {
            get
            {
                if (MakhNavigation == null) return string.Empty;
                else return MakhNavigation.Diachi;
            }
        }

        public static Dienke chuyendoi(Cdienke x)
        {
            return new Dienke
            {
                Madk = x.Madk,
                Ngaydk = x.Ngaydk,
                Makh = x.Makh,
                MakhNavigation = x.MakhNavigation
            };

        }
        public static Cdienke chuyendoi(Dienke x)
        {
            return new Cdienke
            {
                Madk = x.Madk,
                Ngaydk = x.Ngaydk,
                Makh = x.Makh,
                
            };

        }
        public static Cdienke saochep(Cdienke x)
        {
            return new Cdienke
            {
                Madk = x.Madk,
                Ngaydk = x.Ngaydk,
                Makh = x.Makh,
                MakhNavigation = x.MakhNavigation
            };

        }

    }
}
