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
    
    public partial class DRUZYNY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DRUZYNY()
        {
            this.PILKARZE = new HashSet<PILKARZE>();
            this.SPOTKANIA = new HashSet<SPOTKANIA>();
            this.SPOTKANIA1 = new HashSet<SPOTKANIA>();
            this.TRENERZY = new HashSet<TRENERZY>();
        }
    
        public decimal Id_druz { get; set; }
        public string Nazwa_druz { get; set; }
        public string Wlasciciel { get; set; }
        public string Siedziba { get; set; }
        public Nullable<int> Ilosc_rozegranych_meczy { get; set; }
        public Nullable<int> Punkty { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PILKARZE> PILKARZE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPOTKANIA> SPOTKANIA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SPOTKANIA> SPOTKANIA1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRENERZY> TRENERZY { get; set; }
    }
}
