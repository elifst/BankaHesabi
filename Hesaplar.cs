//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankaHesaplari.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hesaplar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hesaplar()
        {
            this.HesapHareketleri = new HashSet<HesapHareketleri>();
        }
    
        public int Id { get; set; }
        public string HesapNo { get; set; }
        public System.DateTime AcilisTarihi { get; set; }
        public int MusteriId { get; set; }
        public decimal Bakiye { get; set; }
        public string HesapTuru { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HesapHareketleri> HesapHareketleri { get; set; }
        public virtual Musteriler Musteriler { get; set; }
    }
}
