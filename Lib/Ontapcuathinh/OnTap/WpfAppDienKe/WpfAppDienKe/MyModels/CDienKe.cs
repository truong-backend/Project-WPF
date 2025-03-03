using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppDienKe.Models;

namespace WpfAppDienKe.MyModels
{
     class CDienKe
    {
        public string Madk { get; set; }
        public DateTime? Ngaydk { get; set; }
        public string Makh { get; set; }

        public  Khachhang MakhNavigation { get; set; }
        public static Dienke chuyenDoi(CDienKe a)
        {
            return new Dienke
            {
                Madk = a.Madk,
                Ngaydk = a.Ngaydk,
                Makh = a.Makh,
                MakhNavigation = a.MakhNavigation
            };
        }
    }
}
