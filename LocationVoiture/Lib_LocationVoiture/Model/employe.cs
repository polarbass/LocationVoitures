//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lib_LocationVoiture.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class employe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public employe()
        {
            this.constats_dommages = new HashSet<constats_dommages>();
            this.reservations = new HashSet<reservation>();
            this.locations = new HashSet<location>();
        }
    
        public int employeID { get; set; }
        public string password { get; set; }
        public string nom { get; set; }
        public string fonction { get; set; }
        public System.DateTime date_embauche { get; set; }
        public Nullable<float> salaire_horaire { get; set; }
        public int succursaleID { get; set; }
        public string telephone { get; set; }
        public string adresse { get; set; }
        public string username { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<constats_dommages> constats_dommages { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<reservation> reservations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<location> locations { get; set; }
        public virtual succursale succursale { get; set; }
    }
}
