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
    public partial class Form1 : Form
    {
        private Entities db = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new Entities();

            comboBox1.DataSource = db.Personnel.ToList();
            comboBox1.DisplayMember = "identite";
            comboBox1.ValueMember = "id";
        }
    }
}
