using Hoadon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoadon.MyModels
{
    internal class Cchitiethoadon
    {
        public string Sohd { get; set; }
        public string Mahang { get; set; }
        public double? Dongia { get; set; }
        public int? Soluong { get; set; }

        public string Tenhang
        {
            get
            {
                if (MahangNavigation == null) return string.Empty;
                else return MahangNavigation.Tenhang;
            }
        }
        public string Dvt 
        {
            get
            {
                if (MahangNavigation == null) return string.Empty;
                else return MahangNavigation.Dvt;
            }
        }
        public double Thanhtien
        {
            get
            {
                if (Soluong.HasValue == true && Dongia.HasValue == true)
                    return Dongia.Value * Soluong.Value;
                else return 0;
            }
        }
        public virtual Hanghoa MahangNavigation { get; set; }
        public static Cchitiethoadon chuyendoi (Chitiethoadon x)
        {
            return new Cchitiethoadon
            {
                Sohd = x.Sohd,
                Mahang = x.Mahang,
                Dongia = x.Dongia,
                Soluong = x.Soluong,
                MahangNavigation = x.MahangNavigation
            };
                                
        }
        public static Chitiethoadon chuyendoi(Cchitiethoadon x)
        {
            return new Chitiethoadon
            {
                Sohd = x.Sohd,
                Mahang = x.Mahang,
                Dongia = x.Dongia,
                Soluong = x.Soluong,
                MahangNavigation = x.MahangNavigation
            };

        }
    }
}
