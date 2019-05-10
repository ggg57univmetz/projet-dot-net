using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_dot_net
{
    public partial class Form2 : Form
    {
        private Annee annee;
        private ufrEntities db = null;
        private int departementID;

        public Form2(Annee annee, int departementID)
        {
            this.annee = annee;
            this.departementID = departementID;
 
            InitializeComponent();
        }

        private void bUESelection_Click(object sender, EventArgs e)
        {
            UE ue = cbUESelection.SelectedItem as UE;
            if (ue == null)
            {
                return;
            }

            Annee anneeBDD = db.Annee.Find(this.annee.id);
            anneeBDD.UE.Add(ue);

            db.SaveChanges();

            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = new ufrEntities();
            List<UEDepartement> ueDepartement = db.UEDepartement.Where(ued => ued.departementID == this.departementID).ToList();
            List<UE> ues = db.UE.ToList();

            ues = ues.Where(ue => ueDepartement.Any(ued => ued.ueID == ue.id)).ToList();
            cbUESelection.DataSource = ues;
            cbUESelection.ValueMember = "id";
            cbUESelection.DisplayMember = "detail";

        }
    }
}
