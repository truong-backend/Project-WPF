using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using waMonhoc.Models;

namespace buoi3.MyModels
{
    public class CLop
    {
        public string Malop { get; set; }
        public string Tenlop { get; set; }
        public static CLop chuyendoi(Lop x)
        {
            return new CLop()
            {  Malop = x.Malop, 
               Tenlop = x.Tenlop
            };

        }
    }
}
