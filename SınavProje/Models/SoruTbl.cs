using System;
using System.Collections.Generic;

#nullable disable

namespace SınavProje.Models
{
    public partial class SoruTbl
    {
        public int Id { get; set; }
        public int? SınavId { get; set; }
        public int? KategoriId { get; set; }
        public string Soru { get; set; }
        public string Sık { get; set; }
        public bool? Cevap { get; set; }

        public virtual KategoriTbl Kategori { get; set; }
        public virtual SınavTbl Sınav { get; set; }
    }
}
