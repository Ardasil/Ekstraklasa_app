//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ekstraklasa
{
    using System;
    using System.Collections.Generic;
    
    public partial class SPOTKANIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SPOTKANIA()
        {
            this.BRAMKI = new HashSet<BRAMKI>();
            this.KARTKI = new HashSet<KARTKI>();
            this.SEDZIOWIE = new HashSet<SEDZIOWIE>();
        }
    
        public int Id_gospo { get; set; }
        public int Id_gosc { get; set; }
        public decimal Id_druz { get; set; }
        public decimal DRU_Id_druz { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public Nullable<System.TimeSpan> Godzina { get; set; }
        public string Miejsce { get; set; }
        public Nullable<int> Wynik_gospo { get; set; }
        public Nullable<int> Wynik_gosc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BRAMKI> BRAMKI { get; set; }
        public virtual DRUZYNY DRUZYNY { get; set; }
        public virtual DRUZYNY DRUZYNY1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KARTKI> KARTKI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SEDZIOWIE> SEDZIOWIE { get; set; }
    }
}
