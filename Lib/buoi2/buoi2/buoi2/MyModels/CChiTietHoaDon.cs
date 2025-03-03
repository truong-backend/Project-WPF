using buoi2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi2.MyModels
{
    class CChiTietHoaDon
    {
        public CChiTietHoaDon()
        {
            Mahang = string.Empty;
            Soluong = 1;
        }
        public string Sohd { get; set; }
        public string Mahang { get; set; }
        public double? Dongia { get; set; }
        public int? Soluong { get; set; }


        //cai nay de them vao doi tuong 
        public string Tenhang
        {
            get
            {
                if (MahangNavigation == null)
                    return string.Empty;
                else
                    return MahangNavigation.Tenhang;
            }
        }

        public string Dvt
        {
            get
            {
                if (MahangNavigation == null)
                    return string.Empty;
                else
                    return MahangNavigation.Dvt;
            }
        }

        public double Thanhtien
        {
            get
            {
                if (Soluong.HasValue == false || Dongia.HasValue == false)
                {
                    return 0;
                }
                else
                    return Dongia.Value * Soluong.Value ;
            }
        }


        public  Hanghoa MahangNavigation { get; set; }
       

        //xay dung phuong thuc chuyen doi tu chitiethoadon sang Cchitiethoadon

        public static CChiTietHoaDon chuyendoi(Chitiethoadon x)
        {
            return new CChiTietHoaDon
            {
                Sohd=x.Sohd,
                Mahang=x.Mahang,
                Dongia=x.Dongia,
                Soluong=x.Soluong,
                MahangNavigation=x.MahangNavigation
            };
        }

        public static Chitiethoadon chuyendoi(CChiTietHoaDon x)
        {
            return new Chitiethoadon
            {
                Sohd = x.Sohd,
                Mahang = x.Mahang,
                Dongia = x.Dongia,
                Soluong = x.Soluong,
                
            };
        }
    }
}
