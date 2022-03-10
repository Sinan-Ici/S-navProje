using System;
using System.Collections.Generic;

#nullable disable

namespace SınavProje.Models
{
    public partial class KategoriTbl
    {
        public KategoriTbl()
        {
            SoruTbls = new HashSet<SoruTbl>();
        }

        public int Id { get; set; }
        public string KategoriAdi { get; set; }

        public virtual ICollection<SoruTbl> SoruTbls { get; set; }
    }
}
