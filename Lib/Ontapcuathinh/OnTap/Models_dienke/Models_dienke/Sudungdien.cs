using System;
using System.Collections.Generic;

#nullable disable

namespace waDienke_Giuaky.Models
{
    public partial class Sudungdien
    {
        public string Maky { get; set; }
        public string Madk { get; set; }
        public int? Chisocu { get; set; }
        public int? Chisomoi { get; set; }
        public string Manv { get; set; }

        public virtual Dienke MadkNavigation { get; set; }
        public virtual Kysudung MakyNavigation { get; set; }
        public virtual Nhanvien ManvNavigation { get; set; }
    }
}
