//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projet_dot_net
{
    using System;
    using System.Collections.Generic;
    
    public partial class EquivalentTD
    {
        public int id { get; set; }
        public double eqtd { get; set; }
        public int typeCoursId { get; set; }
        public int categorieID { get; set; }
    
        public virtual Categorie Categorie { get; set; }
        public virtual TypeCours TypeCours { get; set; }
    }
}
