using System;
using System.Collections.Generic;

#nullable disable

namespace waDienke_Giuaky.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            Sudungdiens = new HashSet<Sudungdien>();
        }

        public string Manv { get; set; }
        public string Tennv { get; set; }
        public string Dienthoai { get; set; }
        public string Diachi { get; set; }

        public virtual ICollection<Sudungdien> Sudungdiens { get; set; }
    }
}
