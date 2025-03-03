using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo2.Models;

namespace demo2.MyModels
{
    class CHocVien
    {
        public string Mshv { get; set; }
        public string Tenhv { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public bool? Phai { get; set; }
        public string Malop { get; set; }
        public virtual Lop MalopNavigation { get; set; }

        public string Tenlop
        {
            get
            {
                if (MalopNavigation == null)
                {
                    return string.Empty;
                }
                else
                {
                    return MalopNavigation.Tenlop;
                }
            }
        }
        public string Phaiview
        {
            get
            {
                if (Phai == true)
                {
                    return "Nam";
                }
                else
                {
                    return "Nữ";
                }
            }
        }
        public static CHocVien chuyendoi(Lylich x)
        {
            return new CHocVien
            {
                Mshv = x.Mshv,
                Tenhv = x.Tenhv,
                Ngaysinh = x.Ngaysinh,
                Phai = x.Phai,
                Malop = x.Malop,
                MalopNavigation = x.MalopNavigation
            };
        }

        public static Lylich chuyendoi(CHocVien x)
        {
            return new Lylich
            {
                Mshv = x.Mshv,
                Tenhv = x.Tenhv,
                Ngaysinh = x.Ngaysinh,
                Phai = x.Phai,
                Malop = x.Malop,
                MalopNavigation = x.MalopNavigation
            };
        }
        public string Ngaysinhview
        {
            get
            {
                if (Ngaysinh == null || Ngaysinh.HasValue == false)
                {
                    return string.Empty;
                }
                else
                {
                    return Ngaysinh.Value.ToShortDateString();
                }
            }
        }
    }
}
