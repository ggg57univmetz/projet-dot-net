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

    public partial class EnseignantCours
    {
        public int idEnseignant { get; set; }
        public int idCours { get; set; }
        public int nbHeures { get; set; }
        public int groupe { get; set; }

        public virtual Cours Cours { get; set; }
        public virtual Personnel Personnel { get; set; }

        public string detail
        {
            get
            {
                return "Groupe " + groupe + " - " + Personnel.identite;
            }
        }
    }
}
