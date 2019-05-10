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
    public partial class Form3 : Form
    {
        private ufrEntities db = null;
        private int departementID;

        public Form3(int departementID)
        {
            this.departementID = departementID;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            db = new ufrEntities();

            List<Personnel> personnel = db.Personnel.Where(p => !p.Departement.Any(d => d.id == this.departementID)).ToList();
            cbSelectEns.DataSource = personnel;
            cbSelectEns.ValueMember = "id";
            cbSelectEns.DisplayMember = "identite";

        }

        private void bSelectEns_Click(object sender, EventArgs e)
        {
            Departement departement = db.Departement.Find(departementID);
            Personnel select = cbSelectEns.SelectedItem as Personnel;
            departement.Personnel.Add(select);
            db.SaveChanges();

            this.Close();
        }
    }
}
