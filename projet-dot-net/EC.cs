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
    
    public partial class EC
    {
        public EC()
        {
            this.Cours = new HashSet<Cours>();
        }
    
        public int id { get; set; }
        public string abbreviation { get; set; }
        public string nomComplet { get; set; }
        public int ueID { get; set; }
        public int nbHeures { get; set; }
    
        public virtual ICollection<Cours> Cours { get; set; }
        public virtual UE UE { get; set; }
    }
}
