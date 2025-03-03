using System;
using System.Collections.Generic;

#nullable disable

namespace Demothidecu.Models
{
    public partial class Kysudung
    {
        public Kysudung()
        {
            Sudungdiens = new HashSet<Sudungdien>();
        }

        public string Maky { get; set; }
        public DateTime? Tungay { get; set; }
        public DateTime? Denngay { get; set; }

        public virtual ICollection<Sudungdien> Sudungdiens { get; set; }
    }
}
