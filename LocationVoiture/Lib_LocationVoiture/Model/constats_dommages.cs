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
    
    public partial class constats_dommages
    {
        public int constantID { get; set; }
        public int reservationID { get; set; }
        public int employeID { get; set; }
        public System.DateTime date_constat { get; set; }
        public string description_dommages { get; set; }
    
        public virtual employe employe { get; set; }
        public virtual reservation reservation { get; set; }
    }
}
