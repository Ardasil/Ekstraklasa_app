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
    
    public partial class PILKARZE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PILKARZE()
        {
            this.BRAMKI = new HashSet<BRAMKI>();
            this.BRAMKI1 = new HashSet<BRAMKI>();
            this.KARTKI = new HashSet<KARTKI>();
        }
    
        public decimal Id_pilkarze { get; set; }
        public Nullable<decimal> Id_druz { get; set; }
        public string Imie_pilk { get; set; }
        public string Nazwisko_pilk { get; set; }
        public string Nazwa_druz_pilk { get; set; }
        public Nullable<int> Wiek_pilk { get; set; }
        public Nullable<int> Ilosc_meczy_pilk { get; set; }
        public Nullable<int> Ilosc_strzelonych_goli_pilk { get; set; }
        public Nullable<int> Ilosc_wpuszczonych_goli_pilk { get; set; }
        public string Specjalizacja { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BRAMKI> BRAMKI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BRAMKI> BRAMKI1 { get; set; }
        public virtual DRUZYNY DRUZYNY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KARTKI> KARTKI { get; set; }
    }
}
