using System;
using System.Collections.Generic;

#nullable disable

namespace SınavProje.Models
{
    public partial class SınavTbl
    {
        public SınavTbl()
        {
            SoruTbls = new HashSet<SoruTbl>();
        }

        public int Id { get; set; }
        public string SınavAdı { get; set; }
        public int? SınavSuresi { get; set; }
        public string SınavAcıklaması { get; set; }
        public int? BasarıPuanı { get; set; }

        public virtual ICollection<SoruTbl> SoruTbls { get; set; }
    }
}
