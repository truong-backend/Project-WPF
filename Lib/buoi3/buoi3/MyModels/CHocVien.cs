using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waMonhoc.Models;

namespace buoi3.MyModels
{
    public class CHocVien
    {
        public CHocVien() { }
        public string Mshv { get; set; }
        public string Tenhv { get; set; }
        public DateTime? Ngaysinh { get; set; }
        public bool? Phai { get; set; }
        public string Malop { get; set; }

        public string NgaySinhView
        {
            get
            {
                if(Ngaysinh == null || Ngaysinh.HasValue == false)
                    return string.Empty;
                else
                    return Ngaysinh.Value.ToShortDateString();
            }
        }
        public string PhaiView
        {
            get
            {
                if (Phai == true)
                {
                    return "Nam";
                }
                else
                    return "Nữ";
            }
        }
        public Lop? MalopNavigation { get; set; }
        public string Tenlop
        {
            get
            {
                if (MalopNavigation == null) return string.Empty;
                else return MalopNavigation.Tenlop.ToString();
            }
        }
        public static CHocVien chuyendoi(Lylich hv)
        {
            return new CHocVien
            {
                Mshv = hv.Mshv,
                Tenhv = hv.Tenhv,
                Ngaysinh = hv.Ngaysinh,
                Phai = hv.Phai,
                Malop = hv.Malop,
                MalopNavigation = hv.MalopNavigation
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
    }
}
