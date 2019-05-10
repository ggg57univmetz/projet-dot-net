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
    public partial class Home : Form
    {
        private int semestre = 1;
        private ufrEntities db = null;
        private List<Composante> composantes;
        private List<Departement> departements;
        private List<Diplome> diplomes;
        private List<TypeCours> typesCours;
        private List<Categorie> categories;
        private List<Personnel> personnel;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                db = new ufrEntities();

                // Chargement de la composante
                this.updateComposantes();

                // Chargement des types de cours
                this.updateTypesCours();

                // Chargement des catégories
                this.updateCategories();

                // Chargement du personnel
                this.updatePersonnel();

                cbSemestre.SelectedIndex = 0;

                tcMenu.SelectedTab = tpPersonnel;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*
         * Chargement des types de cours
         */
        private void updateTypesCours()
        {
            this.typesCours = db.TypeCours.ToList();
            cbCoursType.DataSource = null;
            cbCoursType.DataSource = new List<TypeCours>(this.typesCours);
            cbCoursType.ValueMember = "id";
            cbCoursType.DisplayMember = "nom";

            cbFormulesTypesCours.DataSource = null;
            cbFormulesTypesCours.DataSource = new List<TypeCours>(this.typesCours);
            cbFormulesTypesCours.ValueMember = "id";
            cbFormulesTypesCours.DisplayMember = "nom";

            cbTypeCoursSupprimer.DataSource = null;
            cbTypeCoursSupprimer.DataSource = new List<TypeCours>(this.typesCours);
            cbTypeCoursSupprimer.ValueMember = "id";
            cbTypeCoursSupprimer.DisplayMember = "nom";

            labelListeTypesCours.Text = "";
            for (int i = 0; i < this.typesCours.Count; i++)
            {
                labelListeTypesCours.Text += this.typesCours[i].nom + ", ";
            }
            labelListeTypesCours.Text = labelListeTypesCours.Text.Remove(labelListeTypesCours.Text.Length - 2);
        }

        /*
         * Chargement des catégories d'enseignants
         */
        private void updateCategories()
        {
            this.categories = db.Categorie.ToList();

            cbAjouterEnsCategorie.DataSource = null;
            cbAjouterEnsCategorie.DataSource = new List<Categorie>(this.categories);
            cbAjouterEnsCategorie.ValueMember = "id";
            cbAjouterEnsCategorie.DisplayMember = "intitule";

            cbFormulesCategories.DataSource = null;
            cbFormulesCategories.DataSource = new List<Categorie>(this.categories);
            cbFormulesCategories.ValueMember = "id";
            cbFormulesCategories.DisplayMember = "intitule";

            cbCategorieSupprimer.DataSource = null;
            cbCategorieSupprimer.DataSource = new List<Categorie>(this.categories);
            cbCategorieSupprimer.ValueMember = "id";
            cbCategorieSupprimer.DisplayMember = "intitule";

            cbModifierEnsCategorie.DataSource = null;
            cbModifierEnsCategorie.DataSource = new List<Categorie>(this.categories);
            cbModifierEnsCategorie.ValueMember = "id";
            cbModifierEnsCategorie.DisplayMember = "intitule";
        }

        /*
         * Chargement des du personnel du département
         */
        private void updatePersonnel()
        {
            Departement departement = cbDepartement.SelectedItem as Departement;

            this.personnel = departement == null ? new List<Personnel>() : db.Personnel.Where(p => p.Departement.Any(d => d.id == departement.id)).ToList();

            cbPersonnelModifierEns.DataSource = null;
            cbPersonnelModifierEns.DataSource = new List<Personnel>(this.personnel);
            cbPersonnelModifierEns.ValueMember = "id";
            cbPersonnelModifierEns.DisplayMember = "identite";

            cbEns2.DataSource = null;
            cbEns2.DataSource = new List<Personnel>(this.personnel);
            cbEns2.ValueMember = "id";
            cbEns2.DisplayMember = "identite";
        }

        /*
         * Affiche un message d'erreur pour un champ manquant
         */
        private void missingFieldBox(string field, string title = "Erreur")
        {
            MessageBox.Show("Veuillez préciser " + field + " à créer", title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        /**************************************************************************************
         ********************************** Onglet Diplomes ***********************************
         **************************************************************************************/

        /**********************************************
         *********** Changements comboboxes ***********
         **********************************************/
        private void cbDiplomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Diplome d = cbDiplome.SelectedItem as Diplome;
            if (d != null)
            {
                tbDiplomeIntitule.Text = d.intitule;
                nudDiplomeAnnees.Value = d.nbAnnees;
            }

            // Chargement de l'année
            this.updateAnnee(d);
        }

        private void cbAnnee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Annee a = cbAnnee.SelectedItem as Annee;

            if (a != null)
            {
                tbAnneeIntitule.Text = a.intitule;
                nudAnneeOrdre.Value = a.ordre;
            }

            // Chargement de l'UE
            this.updateUE(a);
        }

        private void cbSemestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.semestre = cbSemestre.SelectedIndex + 1;
            // Chargement de l'UE
            Annee a = cbAnnee.SelectedItem as Annee;
            this.updateUE(a);
        }

        private void cbUE_SelectedIndexChanged(object sender, EventArgs e)
        {
            UE ue = cbUE.SelectedItem as UE;

            if (ue != null)
            {
                tbUERef.Text = ue.abbreviation;
                tbUENomComplet.Text = ue.nomComplet;
                cbUESemestre.SelectedIndex = ue.semestre - 1;

                // Chargement de l'EC
                this.updateEC(ue);

            }
        }

        private void cbEC_SelectedIndexChanged(object sender, EventArgs e)
        {
            EC ec = cbEC.SelectedItem as EC;

            if (ec != null)
            {
                tbECRef.Text = ec.abbreviation;
                tbECNomComplet.Text = ec.nomComplet;
                nudECHeures.Value = ec.nbHeures;

                // Chargement du cours
                this.updateCours(ec);
            }
        }

        private void cbCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cours cours = cbCours.SelectedItem as Cours;

            if (cours != null)
            {
                tbCoursIntitule.Text = cours.intitule;
                nudCoursGroupes.Value = cours.nbGroupes;
                nudCoursHeures.Value = cours.nbHeures;
                cbCoursType.SelectedItem = cours.TypeCours;

                // Chargement des enseignants du cours
                this.updateEnseignants(cours);
            }
        }

        private void cbEns1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnseignantCours ens = cbEns1.SelectedItem as EnseignantCours;
            if (ens != null)
            {
                nudEnsHeures1.Value = ens.nbHeures;
                cbEnsGroupe1.SelectedItem = ens.groupe;
            }            
        }


        /**********************************************
         ************** Boutons d'ajouts **************
         **********************************************/

        private void bDiplomeNouveau_Click(object sender, EventArgs e)
        {
            Departement departement = cbDepartement.SelectedItem as Departement;
            if (departement == null)
            {
                MessageBox.Show("Veuillez sélectionner un département avant de créer un diplôme.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Diplome diplome = new Diplome();
            diplome.departementID = departement.id;
            diplome.intitule = "Nouveau diplôme";
            diplome.nbAnnees = 1;

            db.Diplome.Add(diplome);
            db.SaveChanges();

            updateDiplomes(departement);
            cbDiplome.SelectedItem = diplome;
        }

        private void bAnneeAjouter_Click(object sender, EventArgs e)
        {
            Diplome d = cbDiplome.SelectedItem as Diplome;
            if (d == null)
            {
                MessageBox.Show("Veuillez sélectionner un diplôme pour créer une année d'études.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Annee annee = new Annee();
            annee.intitule = "Nouvelle année";
            annee.ordre = 1;
            annee.Diplome = d;

            db.Annee.Add(annee);
            db.SaveChanges();


            updateAnnee(d);
            cbAnnee.SelectedItem = annee;
        }

        private void bUEAjouter_Click(object sender, EventArgs e)
        {
            Annee a = cbAnnee.SelectedItem as Annee;
            if (a == null)
            {
                MessageBox.Show("Veuillez sélectionner une année pour créer une Unité d'Enseignement.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UE ue = new UE();
            ue.abbreviation = "";
            ue.nomComplet = "Nouvelle UE";
            ue.Annee.Add(a);
            ue.semestre = (short)this.semestre;

            db.UE.Add(ue);
            db.SaveChanges();

            updateUE(a);
            cbUE.SelectedItem = ue;
        }

        private void bUEAjouterExistant_Click(object sender, EventArgs e)
        {
            Annee annee = cbAnnee.SelectedItem as Annee;
            Departement departement = cbDepartement.SelectedItem as Departement;

            if (departement == null || annee == null)
            {
                MessageBox.Show("Veuillez sélectionner un département et une année avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Form2 form2 = new Form2(annee, departement.id);
            DialogResult result = form2.ShowDialog();

            this.updateUE(annee);
        }

        private void bECAjouter_Click(object sender, EventArgs e)
        {
            UE ue = cbUE.SelectedItem as UE;
            if (ue == null)
            {
                MessageBox.Show("Veuillez sélectionner une Unité d'Enseignement (UE) pour créer un EC.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EC ec = new EC();
            ec.nomComplet = "Nouvel EC";
            ec.nbHeures = 0;
            ec.UE = ue;

            db.EC.Add(ec);
            db.SaveChanges();

            updateEC(ue);
            cbEC.SelectedItem = ec;
        }

        private void bCoursAjouter_Click(object sender, EventArgs e)
        {
            EC ec = cbEC.SelectedItem as EC;
            if (ec == null)
            {
                MessageBox.Show("Veuillez sélectionner un Élement Constitutif (EC) pour créer un cours.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cours cours = new Cours();
            cours.intitule = "Nouveau cours";
            cours.nbGroupes = 1;
            cours.nbHeures = 0;
            cours.TypeCours = db.TypeCours.First();
            cours.EC = ec;

            db.Cours.Add(cours);
            db.SaveChanges();

            updateCours(ec);
            cbCours.SelectedItem = cours;
        }

        private void bEnsAffecter_Click(object sender, EventArgs e)
        {
            Cours cours = cbCours.SelectedItem as Cours;
            Personnel enseignant = cbEns2.SelectedItem as Personnel;

            if (cours == null || enseignant == null)
            {
                return;
            }

            // // Vérification du groupe et du nombre d'heures
            int groupe = (int)cbEnsGroupe2.SelectedValue;
            int heures = (int)nudEnsHeures2.Value;
            if (!verifierHeures(cours, heures, groupe))
            {
                return;
            }
            // Vérifications effectuées =>  enregistrement

            EnseignantCours affectation = new EnseignantCours();
            affectation.Personnel = enseignant;
            affectation.Cours = cours;
            affectation.groupe = groupe;
            affectation.nbHeures = heures;

            db.EnseignantCours.Add(affectation);
            db.SaveChanges();
            refreshPersonnelDataGridView();
            updateEnseignants(cours);
            cbEns1.SelectedItem = affectation;
        }

        /**********************************************
         ********** Boutons d'enregistrement **********
         **********************************************/

        private void bDiplomeSave_Click(object sender, EventArgs e)
        {
            Diplome diplome = cbDiplome.SelectedItem as Diplome;

            string intitule = tbDiplomeIntitule.Text;
            int nbAnnees = (int)nudDiplomeAnnees.Value;

            if (intitule.Length == 0)
            {
                MessageBox.Show("Veuillez indiquer l'intitulé du diplôme.", "Intitulé manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nbAnnees <= 0)
            {
                MessageBox.Show("Veuillez indiquer un nombre d'années positif et non nul.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Diplome diplomeBDD = db.Diplome.Find(diplome.id);

                diplomeBDD.intitule = intitule;
                diplomeBDD.nbAnnees = nbAnnees;

                db.SaveChanges();

                Departement departement = cbDepartement.SelectedItem as Departement;
                updateDiplomes(departement);
                cbDiplome.SelectedItem = diplomeBDD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de l'enregistrement du diplôme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bAnneeSave_Click(object sender, EventArgs e)
        {
            Annee annee = cbAnnee.SelectedItem as Annee;

            if (annee == null)
            {
                return;
            }

            string intitule = tbAnneeIntitule.Text;
            int ordre = (int)nudAnneeOrdre.Value;

            Diplome diplome = cbDiplome.SelectedItem as Diplome;

            if (intitule.Length == 0)
            {
                MessageBox.Show("Veuillez indiquer l'intitulé de l'année.", "Intitulé manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ordre <= 0 || ordre > diplome.nbAnnees)
            {
                MessageBox.Show("L'ordre de l'année doit être compris entre 1 et le nombre d'années du diplôme. Il s'agit de l'ordre de l'année dans le diplôme. Par exemple une année de L2 aura un ordre égal à 2 car il s'agit de la deuxième année du diplôme \"Licence\".", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Annee anneeBDD = db.Annee.Find(annee.id);

                anneeBDD.intitule = intitule;
                anneeBDD.ordre = ordre;

                db.SaveChanges();

                updateAnnee(diplome);
                cbAnnee.SelectedItem = anneeBDD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de l'enregistrement de l'année", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUESave_Click(object sender, EventArgs e)
        {
            UE ue = cbUE.SelectedItem as UE;
            if (ue == null)
            {
                return;
            }

            string reference = tbUERef.Text;
            string intitule = tbUENomComplet.Text;
            int semestre = cbUESemestre.SelectedIndex + 1;

            if (reference.Length == 0)
            {
                MessageBox.Show("Veuillez indiquer la référence de l'UE.", "Référence manquante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (intitule.Length == 0)
            {
                MessageBox.Show("Veuillez indiquer le nom complet de l'UE.", "Nom complet manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UE ueBDD = db.UE.Find(ue.id);

                ueBDD.abbreviation = reference;
                ueBDD.nomComplet = intitule;
                ueBDD.semestre = (short)semestre;

                db.SaveChanges();

                Annee a = cbAnnee.SelectedItem as Annee;
                updateUE(a);
                cbSemestre.SelectedIndex = semestre - 1;
                cbUE.SelectedItem = ueBDD;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de l'enregistrement de l'UE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bECSave_Click(object sender, EventArgs e)
        {
            EC ec = cbEC.SelectedItem as EC;
            if (ec == null)
            {
                return;
            }

            string reference = tbECRef.Text;
            string intitule = tbECNomComplet.Text;
            int nbHeures = (int)nudECHeures.Value;

            if (reference.Length == 0)
            {
                MessageBox.Show("Veuillez indiquer la référence de l'EC.", "Référence manquante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (intitule.Length == 0)
            {
                MessageBox.Show("Veuillez indiquer le nom complet de l'EC.", "Nom complet manquant", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nbHeures <= 0)
            {
                MessageBox.Show("Veuillez indiquer un nombre d'heures positif et non nul.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!verifierHeuresEC(ec, nbHeures))
            {
                return;
            }

            try
            {
                EC ecBDD = db.EC.Find(ec.id);

                ecBDD.abbreviation = reference;
                ecBDD.nomComplet = intitule;
                ecBDD.nbHeures = nbHeures;

                db.SaveChanges();

                UE ue = cbUE.SelectedItem as UE;
                updateEC(ue);
                cbEC.SelectedItem = ecBDD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bCoursSave_Click(object sender, EventArgs e)
        {
            if (!verifierChampsCours())
            {
                return;
            }

            Cours cours = cbCours.SelectedItem as Cours;
            TypeCours type = cbCoursType.SelectedItem as TypeCours;
            EC ec = cbEC.SelectedItem as EC;

            string intitule = tbCoursIntitule.Text;
            int heures = (int)nudCoursHeures.Value;
            int groupes = (int)nudCoursGroupes.Value;

            if (!verifierHeuresCours(ec, cours, heures) || !verfierHeuresAffectees(cours, heures))
            {
                return;
            }

            bool supprimerGroupes = groupes < cours.nbGroupes;
            int nbGroupesASupprimer = cours.nbGroupes - groupes;
            int nbGroupesInitial = cours.nbGroupes;

            try
            {
                Cours coursBDD = db.Cours.Find(cours.id);

                coursBDD.intitule = intitule;
                coursBDD.nbGroupes = (short)groupes;
                coursBDD.nbHeures = heures;
                coursBDD.TypeCours = type;

                db.SaveChanges();

                if (supprimerGroupes)
                {
                    supprimerGroupesEnTrop(cours, nbGroupesInitial, nbGroupesASupprimer);
                }

                updateCours(ec);
                refreshPersonnelDataGridView();
                cbCours.SelectedItem = coursBDD;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bEnseignantSave_Click(object sender, EventArgs e)
        {
            Cours cours = cbCours.SelectedItem as Cours;
            EnseignantCours enseignantCours = cbEns1.SelectedItem as EnseignantCours;

            if (cours == null || enseignantCours == null)
            {
                return;
            }

            Personnel enseignant = enseignantCours.Personnel;

            // Vérification du groupe et du nombre d'heures
            int groupe = (int)cbEnsGroupe1.SelectedValue;
            int heures = (int)nudEnsHeures1.Value;
            int heuresAjoutees = heures - enseignantCours.nbHeures;

            if (heures <= 0)
            {
                MessageBox.Show("Merci d'entrer un nombre d'heures positif et non nul.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (heuresAjoutees > 0 && !verifierHeures(cours, heuresAjoutees, groupe))
            {
                return;
            }
            // Vérifications effectuées => enregistrement

            try
            {
                EnseignantCours affectation = db.EnseignantCours.Where(ec => ec.idEnseignant == enseignant.id && ec.idCours == cours.id && ec.groupe == groupe).Single();
                affectation.groupe = groupe;
                affectation.nbHeures = heures;

                db.SaveChanges();

                refreshPersonnelDataGridView();
                updateEnseignants(cours);
                cbEns1.SelectedItem = enseignantCours;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /**********************************************
         *********** Boutons de suppression ***********
         **********************************************/
        private void bDiplomeSupprimer_Click(object sender, EventArgs e)
        {
            Diplome diplome = cbDiplome.SelectedItem as Diplome;
            if (diplome == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Vous êtes sur le point de supprimer le diplôme " + diplome.intitule + ", cela supprimera aussi toutes les années, les UE, les EC ainsi que tous les cours qui y sont attachés. Voulez-vous continuer ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                supprimerDiplome(diplome);
            }
        }

        private void bAnneeSupprimer_Click(object sender, EventArgs e)
        {
            Annee annee = cbAnnee.SelectedItem as Annee;
            if (annee == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Vous êtes sur le point de supprimer l'année " + annee.intitule + ", cela supprimera aussi toutes les UE, les EC ainsi que tous les cours qui y sont attachés. Voulez-vous continuer ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                supprimerAnnee(annee);
            }
        }

        private void bUEDissocier_Click(object sender, EventArgs e)
        {
            UE ue = cbUE.SelectedItem as UE;
            if (ue == null)
            {
                return;
            }

            try
            {
                Annee a = cbAnnee.SelectedItem as Annee;
                Annee anneeBDD = db.Annee.Find(a.id);
                anneeBDD.UE.Remove(ue);
                db.SaveChanges();
                updateUE(a); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bUESupprimer_Click(object sender, EventArgs e)
        {
            UE ue = cbUE.SelectedItem as UE;
            if (ue == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Vous êtes sur le point de supprimer l'UE " + ue.nomComplet + ", cela supprimera aussi tous les EC ainsi que tous les cours qui y sont attachés. Voulez-vous continuer ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                supprimerUE(ue);
            }
        }

        private void bECSupprimer_Click(object sender, EventArgs e)
        {
            EC ec = cbEC.SelectedItem as EC;
            if (ec == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Vous êtes sur le point de supprimer l'EC " + ec.nomComplet + ", cela supprimera aussi tous les cours qui y sont attachés. Voulez-vous continuer ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                supprimerEC(ec);
            }
        }

        private void bCoursSuppr_Click(object sender, EventArgs e)
        {
            Cours cours = cbCours.SelectedItem as Cours;
            if (cours == null)
            {
                return;
            }
            supprimerCours(cours);
        }

        private void bEnseignantRemove_Click(object sender, EventArgs e)
        {
            Cours cours = cbCours.SelectedItem as Cours;
            EnseignantCours enseignantCours = cbEns1.SelectedItem as EnseignantCours;

            if (cours == null || enseignantCours == null)
            {
                return;
            }

            Personnel enseignant = enseignantCours.Personnel;
            int groupe = (int)cbEnsGroupe1.SelectedValue;

            desaffecter(cours, enseignant, groupe);
        }

        /**********************************************
         *********** Méthodes de suppression **********
         **********************************************/

        private void supprimerDiplome(Diplome diplome)
        {
            try
            {
                List<Annee> annees = db.Annee.Where(a => a.diplomeID == diplome.id).ToList();

                for (int i = 0; i < annees.Count; i++)
                {
                    supprimerAnnee(annees[i]);
                }

                db.Diplome.Remove(diplome);
                db.SaveChanges();
                Departement departement = cbDepartement.SelectedItem as Departement;
                updateDiplomes(departement);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de suppression du diplôme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimerAnnee(Annee annee)
        {
            try
            {
                List<UE> ues = db.UE.Where(ue => ue.Annee.Any(a => a.id == annee.id)).ToList();

                for (int i = 0; i < ues.Count; i++)
                {
                    supprimerUE(ues[i]);
                }

                db.Annee.Remove(annee);
                db.SaveChanges();

                Diplome diplome = cbDiplome.SelectedItem as Diplome;
                updateAnnee(diplome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de suppression de l'année", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimerUE(UE ue)
        {
            try
            {
                List<EC> ecs = db.EC.Where(ec => ec.ueID == ue.id).ToList();
                for (int i = 0; i < ecs.Count; i++)
                {
                    supprimerEC(ecs[i]);
                }

                Annee a = cbAnnee.SelectedItem as Annee;
                Annee anneeBDD = db.Annee.Find(a.id);
                anneeBDD.UE.Remove(ue);
                db.SaveChanges();

                db.UE.Remove(ue);
                db.SaveChanges();


                updateUE(a); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimerEC(EC ec)
        {
            try
            {
                List<Cours> cours = db.Cours.Where(c => c.idEC == ec.id).ToList();
                for (int i = 0; i < cours.Count; i++)
                {
                    supprimerCours(cours[i]);
                }

                db.EC.Remove(ec);
                db.SaveChanges();

                UE ue = cbUE.SelectedItem as UE;
                updateEC(ue);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimerCours(Cours cours)
        {
            try
            {
                supprimerGroupesEnTrop(cours, cours.nbGroupes, cours.nbGroupes);

                db.Cours.Remove(cours);

                db.SaveChanges();

                EC ec = cbEC.SelectedItem as EC;
                updateCours(ec);
                refreshPersonnelDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimerGroupesEnTrop(Cours cours, int nbGroupesInitial, int nbGroupesASupprimer)
        {
            int groupeCourant = nbGroupesInitial;

            try
            {
                List<EnseignantCours> enseignantsCours = null;
                for (int i = 0; i < nbGroupesASupprimer; i++)
                {
                    enseignantsCours = db.EnseignantCours.Where(ec => ec.idCours == cours.id && ec.groupe == groupeCourant).ToList();

                    for (int j = 0; j < enseignantsCours.Count; j++)
                    {
                        desaffecter(cours, enseignantsCours[j].Personnel, groupeCourant);
                    }

                    groupeCourant--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void desaffecter(Cours cours, Personnel enseignant, int groupe)
        {
            try
            {
                EnseignantCours affectation = db.EnseignantCours.Where(ec => ec.idEnseignant == enseignant.id && ec.idCours == cours.id && ec.groupe == groupe).Single();
                db.EnseignantCours.Remove(affectation);
                db.SaveChanges();

                updateEnseignants(cours);
                refreshPersonnelDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**********************************************
         ******** Vérification des contraintes ********
         **********************************************/
        /**
         * Renvoie true si le nombre d'heures saisies ne dépasse pas le total autorisé, false sinon.
         */
        bool verifierHeures(Cours cours, int heures, int groupe)
        {
            // Positivité et non nullité
            if (heures <= 0)
            {
                MessageBox.Show("Merci d'entrer un nombre d'heures positif et non nul.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Total global
            int totalAutorise = cours.nbHeures * cours.nbGroupes;
            int totalEffectue = 0;

            List<EnseignantCours> enseignantsCours = db.EnseignantCours.Where(ec => ec.idCours == cours.id).ToList();

            for (int i = 0; i < enseignantsCours.Count; i++)
            {
                totalEffectue += enseignantsCours[i].nbHeures;
            }

            int heuresRestantes = totalAutorise - totalEffectue;

            if (heuresRestantes < heures)
            {
                string heuresStr = heuresRestantes > 1 ? " heures" : " heure";
                MessageBox.Show("Vous avez saisi trop d'heures pour cet enseignant. Seules " + totalAutorise + " heures sont autorisées pour le cours " + cours.intitule + ", or " + totalEffectue + " ont déjà été affectées. Il reste donc " + heuresRestantes + heuresStr + " à affecter.", "Dépassement des heures", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Total par groupe
            totalAutorise = cours.nbHeures;
            totalEffectue = 0;
            enseignantsCours = db.EnseignantCours.Where(ec => ec.idCours == cours.id && ec.groupe == groupe).ToList();
            for (int i = 0; i < enseignantsCours.Count; i++)
            {
                totalEffectue += enseignantsCours[i].nbHeures;
            }
            heuresRestantes = totalAutorise - totalEffectue;
            if (heuresRestantes < heures)
            {
                string heuresStr = heuresRestantes > 1 ? " heures" : " heure";
                MessageBox.Show("Vous avez saisi trop d'heures dans ce groupe pour cet enseignant. Seules " + totalAutorise + " heures sont autorisées pour le groupe " + groupe + " du cours " + cours.intitule + ", or " + totalEffectue + " ont déjà été affectées. Il reste donc " + heuresRestantes + heuresStr + " à affecter.", "Dépassement des heures", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool verifierHeuresCours(EC ec, Cours cours, int heures)
        {
            int heuresMaxEC = ec.nbHeures;
            int heuresCoursExistants = 0;

            List<Cours> listeCours = db.Cours.Where(c => c.idEC == ec.id && c.id != cours.id).ToList();

            for (int i = 0; i < listeCours.Count; i++)
            {
                heuresCoursExistants += listeCours[i].nbHeures;
            }

            if (heuresCoursExistants + heures > heuresMaxEC)
            {
                int heuresRestantes = heuresMaxEC - heuresCoursExistants;
                MessageBox.Show("Veuillez respecter le nombre d'heures disponibles dans l'EC (" + heuresMaxEC + " heures disponibles, dont " + heuresCoursExistants + " affectées à d'autres cours : " + heuresRestantes + " heures restantes.)", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool verfierHeuresAffectees(Cours cours, int heures)
        {
            List<EnseignantCours> ensCours = db.EnseignantCours.Where(ec => ec.idCours == cours.id).ToList();
            int anciennesHeures = cours.nbHeures * cours.nbGroupes;
            int nouvellesHeures = heures * cours.nbGroupes;

            int heuresAffectees = 0;
            for (int i = 0; i < ensCours.Count; i++)
            {
                heuresAffectees += ensCours[i].nbHeures;
            }

            if (nouvellesHeures < heuresAffectees)
            {
                MessageBox.Show("Impossible de diminuer le nombres d'heures de ce cours car " + heuresAffectees + " heures ont déjà été affectées à des enseignants.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            int heuresGroupes = 0;
            for (int i = 1; i <= cours.nbGroupes; i++)
            {
                ensCours = db.EnseignantCours.Where(ec => ec.idCours == cours.id && ec.groupe == i).ToList();
                for (int j = 0; j < ensCours.Count; j++)
                {
                    heuresGroupes += ensCours[j].nbHeures;
                }
                if (heuresGroupes > heures)
                {
                    MessageBox.Show("Impossible de diminuer le nombres d'heures de ce cours car un ou plusieurs groupes ont un nombre d'heures supérieur à la nouvelle valeur pour ce cours.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private bool verifierChampsCours()
        {
            Cours cours = cbCours.SelectedItem as Cours;
            TypeCours type = cbCoursType.SelectedItem as TypeCours;

            if (cours == null || type == null)
            {
                return false;
            }

            if (tbCoursIntitule.TextLength == 0)
            {
                MessageBox.Show("Veuillez préciser l'intitulé du cours", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nudCoursHeures.Value <= 0)
            {
                MessageBox.Show("Merci d'entrer un nombre d'heures positif et non nul.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nudCoursGroupes.Value <= 0)
            {
                MessageBox.Show("Merci d'entrer un nombre de groupes positif et non nul.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool verifierHeuresEC(EC ec, int heures)
        {
            List<Cours> cours = db.Cours.Where(c => c.idEC == ec.id).ToList();
            int heuresAffectees = 0;

            for (int i = 0; i < cours.Count; i++)
            {
                heuresAffectees += cours[i].nbHeures;
            }

            if (heures < heuresAffectees)
            {
                MessageBox.Show("Impossible de diminuer le nombre d'heures de l'EC car " + heuresAffectees + " heures ont déjà été affectées à des cours.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /**********************************************
         ************* Updates en chaine **************
         **********************************************/

        private void updateComposantes()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.composantes = db.Composante.ToList();

                cbComposante.DataSource = null;
                cbComposante.DataSource = this.composantes;
                cbComposante.ValueMember = "id";
                cbComposante.DisplayMember = "nom";

                Composante composante = null;
                if (this.composantes.Count == 0)
                {
                    tbComposanteNom.Text = "";
                }
                else
                {
                    composante = cbComposante.SelectedItem as Composante;
                    tbComposanteNom.Text = composante.nom;
                }
                this.updateDepartements(composante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de chargement des composantes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void updateDepartements(Composante composante)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.departements = composante == null ? new List<Departement>() : db.Departement.Where(d => d.composanteID == composante.id).ToList();

                cbDepartement.DataSource = null;
                cbDepartement.DataSource = this.departements;
                cbDepartement.ValueMember = "id";
                cbDepartement.DisplayMember = "nom";

                Departement departement = null;
                if (this.departements.Count == 0)
                {
                    tbDepartementNom.Text = "";
                }
                else
                {
                    departement = cbDepartement.SelectedItem as Departement;
                    tbDepartementNom.Text = departement.nom;
                }
                this.updateDiplomes(departement);
                this.refreshPersonnelDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de chargement des départements", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Arrow;
        }

        private void updateDiplomes(Departement departement)
        {
            try
            {
                this.diplomes = departement == null ? new List<Diplome>() : db.Diplome.Where(d => d.departementID == departement.id).ToList();
                cbDiplome.DataSource = null;
                cbDiplome.DataSource = this.diplomes;
                cbDiplome.ValueMember = "id";
                cbDiplome.DisplayMember = "intitule";

                Diplome diplome = null;
                if (this.diplomes.Count == 0)
                {
                    tbDiplomeIntitule.Text = "";
                    nudDiplomeAnnees.Value = 0;
                }
                else
                {
                    diplome = cbDiplome.SelectedItem as Diplome;
                }
                this.updateAnnee(diplome);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de chargement des diplômes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateAnnee(Diplome d)
        {
            try
            {
                List<Annee> annees = d == null ? new List<Annee>() : db.Annee.Where(a => a.diplomeID == d.id).ToList();
                cbAnnee.DataSource = annees;
                cbAnnee.ValueMember = "id";
                cbAnnee.DisplayMember = "intitule";

                Annee anneeSelect = null;

                if (annees.Count == 0)
                {
                    tbAnneeIntitule.Text = "";
                    nudAnneeOrdre.Value = 0;
                }
                else
                {
                    anneeSelect = cbAnnee.SelectedItem as Annee;
                }
                this.updateUE(anneeSelect);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de chargement des années", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateUE(Annee a)
        {
            try
            {
                List<UE> ues = a == null ? new List<UE>() : db.UE.Where(ue => ue.Annee.Any(annee => annee.id == a.id) && ue.semestre == this.semestre).ToList();
                cbUE.DataSource = ues;

                cbUE.ValueMember = "id";
                cbUE.DisplayMember = "nomComplet";

                UE u = null;

                if (ues.Count == 0)
                {
                    tbUERef.Text = "";
                    tbUENomComplet.Text = "";
                    cbUESemestre.SelectedIndex = -1;
                }
                else
                {
                    u = cbUE.SelectedItem as UE;
                    cbUESemestre.SelectedIndex = u.semestre - 1;
                }
                this.updateEC(u);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de chargement des UE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateEC(UE ue)
        {
            try
            {
                List<EC> ucs = ue == null ? new List<EC>() : db.EC.Where(ec => ec.ueID == ue.id).ToList();
                cbEC.DataSource = ucs;

                cbEC.ValueMember = "id";
                cbEC.DisplayMember = "nomComplet";

                EC e = null;

                if (ucs.Count == 0)
                {
                    tbECRef.Text = "";
                    tbECNomComplet.Text = "";
                }
                else
                {
                    e = cbEC.SelectedItem as EC;
                }
                this.updateCours(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de chargement des EC", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void updateCours(EC ec)
        {
            try
            {
                List<Cours> cours = ec == null ? new List<Cours>() : db.Cours.Where(c => c.idEC == ec.id).ToList();
                cbCours.DataSource = cours;

                cbCours.ValueMember = "id";
                cbCours.DisplayMember = "intitule";

                Cours coursSelect = null;

                if (cours.Count == 0)
                {
                    tbCoursIntitule.Text = "";
                    nudCoursGroupes.Value = 0;
                    nudCoursHeures.Value = 0;
                }
                else
                {
                    coursSelect = cbCours.SelectedItem as Cours;
                }

                updateEnseignants(coursSelect);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de chargement des cours", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateEnseignants(Cours cours)
        {
            try
            {
                List<EnseignantCours> enscours = cours == null ? new List<EnseignantCours>() : db.EnseignantCours.Where(ec => ec.idCours == cours.id).ToList();
                cbEns1.DataSource = enscours;

                cbEns1.ValueMember = "idEnseignant";
                cbEns1.DisplayMember = "detail";

                List<int> groupes = new List<int>();

                if (cours != null)
                {
                    for (int i = 1; i <= cours.nbGroupes; i++)
                    {
                        groupes.Add(i);
                    }
                    cbEnsGroupe2.DataSource = new List<int>(groupes);
                }
                else
                {
                    cbEnsGroupe2.DataSource = null;
                    nudEnsHeures2.Value = 0;
                }

                if (enscours.Count == 0)
                {
                    cbEnsGroupe1.DataSource = null;
                    nudEnsHeures1.Value = 0;
                }
                else
                {
                    cbEnsGroupe1.DataSource = new List<int>(groupes);

                    EnseignantCours ens = cbEns1.SelectedItem as EnseignantCours;
                    nudEnsHeures1.Value = ens.nbHeures;

                    cbEnsGroupe1.SelectedItem = ens.groupe;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de chargement des enseignants", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**************************************************************************************
         ********************************** Onglet Personnel **********************************
         **************************************************************************************/

        /**********************************************
         ********** Actualisation dashboard ***********
         **********************************************/
        public void refreshPersonnelDataGridView()
        {
            Departement departement = cbDepartement.SelectedItem as Departement;
            if (departement == null)
            {
                return;
            }

            this.personnel_dashboardTableAdapter = new projet_dot_net.ufrDataSetTableAdapters.personnel_dashboardTableAdapter(departement.id);
            this.personnel_dashboardTableAdapter.Fill(this.ufrDataSet.personnel_dashboard);
        }

        /**********************************************
         *********** Changements comboboxes ***********
         **********************************************/

        private void cbPersonnelModifierEns_SelectedIndexChanged(object sender, EventArgs e)
        {
            Personnel selected = cbPersonnelModifierEns.SelectedItem as Personnel;
            if (selected != null)
            {
                cbModifierEnsCategorie.SelectedItem = selected.Categorie;
            }
        }

        /**********************************************
         ************** Boutons d'ajout ***************
         **********************************************/

        private void bAjouterEns_Click(object sender, EventArgs e)
        {
            Departement departement = cbDepartement.SelectedItem as Departement;
            if (departement == null)
            {
                MessageBox.Show("Veuillez sélectionner un département avant de créer un enseignant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbAjouterEnsNom.TextLength == 0)
            {
                missingFieldBox("le nom de l'enseignant", "Nom manquant");
                return;
            } else if (tbAjouterEnsPrenom.TextLength == 0)
            {
                missingFieldBox("le prénom de l'enseignant", "Prénom manquant");
                return;
            }

            Personnel enseignant = new Personnel(tbAjouterEnsNom.Text, tbAjouterEnsPrenom.Text);
            enseignant.Categorie = cbAjouterEnsCategorie.SelectedItem as Categorie;

            db.Personnel.Add(enseignant);
            db.SaveChanges();

            Departement departementBDD = db.Departement.Find(departement.id);
            departementBDD.Personnel.Add(enseignant);
            db.SaveChanges();

            this.refreshPersonnelDataGridView();
            this.updatePersonnel();

            tbAjouterEnsNom.Text = "";
            tbAjouterEnsPrenom.Text = "";
        }

        private void bSelectEnsExistant_Click(object sender, EventArgs e)
        {
            Departement departement = cbDepartement.SelectedItem as Departement;
            if (departement == null)
            {
                MessageBox.Show("Veuillez sélectionner la département auquel vous souhaitez ajouter l'enseignant avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form3 form3 = new Form3(departement.id);
            DialogResult result = form3.ShowDialog();

            this.updatePersonnel();
            this.refreshPersonnelDataGridView();
        }

        /**********************************************
         ********** Bouton d'enregistrement ***********
         **********************************************/
        private void bModifierEnsSave_Click(object sender, EventArgs e)
        {
            Personnel selected = cbPersonnelModifierEns.SelectedItem as Personnel;
            Personnel p = db.Personnel.Find(selected.id);

            Categorie c = cbModifierEnsCategorie.SelectedItem as Categorie;

            p.Categorie = c;
            db.SaveChanges();

            this.refreshPersonnelDataGridView();

        }

        /**********************************************
         ********** Boutons de suppression ************
         **********************************************/

        private void bSupprimerEns_Click(object sender, EventArgs e)
        {
            Personnel selected = cbPersonnelModifierEns.SelectedItem as Personnel;
            Personnel p = db.Personnel.Find(selected.id);

            List<Cours> cours = db.Cours.Where(c => c.EnseignantCours.Any(ec => ec.idEnseignant == p.id)).ToList();

            if (cours.Count > 0) {
                MessageBox.Show("Impossible de supprimer l'enseignant " + p.identite + " car il est affecté à un ou plusieurs cours.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("L'enseignant " + p.identite + " sera supprimé de la base de donnée. Voulez-vous continuer ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                List<Departement> deps = p.Departement.ToList();
                Departement departement = null;
                for (int i = 0; i < deps.Count; i++)
                {
                    departement = db.Departement.Find(deps[i].id);
                    departement.Personnel.Remove(p);
                    db.SaveChanges();
                }

                db.Personnel.Remove(p);
                db.SaveChanges();
                this.refreshPersonnelDataGridView();
                this.updatePersonnel();
            }

        }

        private void bDissocierEnseignant_Click(object sender, EventArgs e)
        {
            Personnel selected = cbPersonnelModifierEns.SelectedItem as Personnel;
            Personnel p = db.Personnel.Find(selected.id);
            Departement dep = cbDepartement.SelectedItem as Departement;
            if (dep == null || selected == null)
            {
                MessageBox.Show("Veuillez sélectionner un enseignant et un département avant de continuer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<CoursDepartement> coursDepartement = db.CoursDepartement.Where(cd => cd.departementID == dep.id).ToList();
            List<Cours> cours = db.Cours.Where(c => c.EnseignantCours.Any(ec => ec.idEnseignant == p.id)).ToList();

            cours = cours.Where(c => coursDepartement.Any(cd => cd.coursID == c.id)).ToList();

            if (cours.Count > 0)
            {
                MessageBox.Show("Impossible de dissocier l'enseignant " + p.identite + " car il est affecté à un ou plusieurs cours dans ce département.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Departement departement = db.Departement.Find(dep.id);
            departement.Personnel.Remove(p);
            db.SaveChanges();
            this.updatePersonnel();
            this.refreshPersonnelDataGridView();
        }

        /**************************************************************************************
         ********************************** Onglet Formules ***********************************
         **************************************************************************************/

        /**********************************************
         ************** Boutons d'ajout ***************
         **********************************************/
        private void bCategorieSave_Click(object sender, EventArgs e)
        {
            if (tbCategorieIntitule.TextLength == 0)
            {
                missingFieldBox("l'intitulé de la catégorie", "Intitulé manquant");
                return;
            }

            Categorie categorie = new Categorie();
            categorie.intitule = tbCategorieIntitule.Text;
            categorie.nbEQTD = (int)nudCategorieNbEQTD.Value;

            EquivalentTD eqtd = null;
            for (int i = 0; i < this.typesCours.Count; i++)
            {
                eqtd = new EquivalentTD();
                eqtd.TypeCours = this.typesCours[i];
                eqtd.Categorie = categorie;
                eqtd.eqtd = 1.0;

                db.EquivalentTD.Add(eqtd);
            }

            db.Categorie.Add(categorie);
            db.SaveChanges();

            updateCategories();

            tbCategorieIntitule.Text = "";

            MessageBox.Show("La catégorie " + categorie.intitule + " a bien été ajoutée. Veuillez à présent définir les formules d'équivalents TD associées à chaque type de cours.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bTypeCoursSave_Click(object sender, EventArgs e)
        {
            if (tbTypeCoursIntitule.TextLength == 0)
            {
                missingFieldBox("l'intitulé du type de cours", "Intitulé manquant");
                return;
            }

            TypeCours type = new TypeCours();
            type.nom = tbTypeCoursIntitule.Text;

            EquivalentTD eqtd = null;
            for (int i = 0; i < this.categories.Count; i++)
            {
                eqtd = new EquivalentTD();
                eqtd.TypeCours = type;
                eqtd.Categorie = this.categories[i];
                eqtd.eqtd = 1.0;

                db.EquivalentTD.Add(eqtd);
            }

            db.TypeCours.Add(type);
            db.SaveChanges();

            updateTypesCours();

            tbTypeCoursIntitule.Text = "";

            MessageBox.Show("Le type de cours \"" + type.nom + "\" a bien été ajouté. Veuillez à présent définir les formules d'équivalents TD qui y sont associées pour chaque catégorie.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bEQTDSave_Click(object sender, EventArgs e)
        {
            Categorie c = cbFormulesCategories.SelectedItem as Categorie;
            TypeCours t = cbFormulesTypesCours.SelectedItem as TypeCours;

            if (c == null || t == null)
            {
                return;
            }

            EquivalentTD eqtd = db.EquivalentTD.Where(eq => eq.categorieID == c.id && eq.typeCoursId == t.id).Single();

            eqtd.eqtd = (double)nudFormulesEQTD.Value;
            db.SaveChanges();
            this.refreshPersonnelDataGridView();
        }

        /**********************************************
         *********** Boutons de suppression ***********
         **********************************************/

        private void bTypeCoursSupprimer_Click(object sender, EventArgs e)
        {
            TypeCours t = cbTypeCoursSupprimer.SelectedItem as TypeCours;

            List<EquivalentTD> eqtds = db.EquivalentTD.Where(eq => eq.typeCoursId == t.id).ToList();

            EquivalentTD eqtd = null;
            for (int i = 0; i < eqtds.Count; i++)
            {
                eqtd = eqtds[i];
                db.EquivalentTD.Remove(eqtd);
            }
            db.SaveChanges();

            db.TypeCours.Remove(t);
            db.SaveChanges();

            updateTypesCours();
        }

        private void bCategorieSupprimer_Click(object sender, EventArgs e)
        {
            Categorie c = cbCategorieSupprimer.SelectedItem as Categorie;

            List<Personnel> personnel = db.Personnel.Where(p => p.categorieID == c.id).ToList();

            if (personnel.Count > 0)
            {
                MessageBox.Show("Impossible de supprimer la catégorie \"" + c.intitule + "\" car des enseignants y sont rattachés.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<EquivalentTD> eqtds = db.EquivalentTD.Where(eq => eq.categorieID == c.id).ToList();

            EquivalentTD eqtd = null;
            for (int i = 0; i < eqtds.Count; i++)
            {
                eqtd = eqtds[i];
                db.EquivalentTD.Remove(eqtd);
            }
            db.SaveChanges();

            db.Categorie.Remove(c);
            db.SaveChanges();

            updateCategories();
        }

        /**********************************************
         *************** Actualisations ***************
         **********************************************/
        private void cbFormulesCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFormuleEQTD();
            updateFormuleSignification();
        }

        private void cbFormulesTypesCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFormuleEQTD();
            updateFormuleSignification();
        }

        private void updateFormuleEQTD()
        {
            Categorie c = cbFormulesCategories.SelectedItem as Categorie;
            TypeCours t = cbFormulesTypesCours.SelectedItem as TypeCours;

            if (c == null || t == null)
            {
                return;
            }

            EquivalentTD eqtd = db.EquivalentTD.Where(eq => eq.categorieID == c.id && eq.typeCoursId == t.id).Single();

            nudFormulesEQTD.Value = (decimal) eqtd.eqtd;
        }

        private void updateFormuleSignification()
        {
            Categorie c = cbFormulesCategories.SelectedItem as Categorie;
            TypeCours t = cbFormulesTypesCours.SelectedItem as TypeCours;

            if (c == null || t == null || formulesSignification == null)
            {
                return;
            }

            formulesSignification.Text = "pour un " + c.intitule + ", une heure de " + t.nom + " équivaut à " + nudFormulesEQTD.Value + " heures de TD.";
        }

        private void nudFormulesEQTD_ValueChanged(object sender, EventArgs e)
        {
            updateFormuleSignification();
        }


        /**************************************************************************************
         ********************************* Onglet Composante **********************************
         **************************************************************************************/

        /**********************************************
         ************** Boutons d'ajout ***************
         **********************************************/
        private void bComposanteAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                Composante composante = new Composante();
                composante.nom = "Nouvelle composante";
                db.Composante.Add(composante);
                db.SaveChanges();
                updateComposantes();
                cbComposante.SelectedItem = composante;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de création de la composante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bDepartementAjouter_Click(object sender, EventArgs e)
        {
            Composante composante = cbComposante.SelectedItem as Composante;

            if (composante == null)
            {
                MessageBox.Show("Veuillez sélectionner une composante avant de créer un département.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Departement departement = new Departement();
            departement.composanteID = composante.id;
            departement.nom = "Nouveau département";


            db.Departement.Add(departement);
            db.SaveChanges();

            updateDepartements(composante);
            cbDepartement.SelectedItem = departement;
        }

        /**********************************************
         ********* Boutons d'enregistrement ***********
         **********************************************/
        private void bComposanteSave_Click(object sender, EventArgs e)
        {
            Composante composante = cbComposante.SelectedItem as Composante;
            if (composante == null)
            {
                return;
            }

            string nouveauNom = tbComposanteNom.Text;
            if (nouveauNom.Length == 0)
            {
                MessageBox.Show("Veuillez entrer un nom pour la composante.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Composante composanteBDD = db.Composante.Find(composante.id);
            composanteBDD.nom = nouveauNom;

            db.SaveChanges();

            updateComposantes();
            cbComposante.SelectedItem = composanteBDD;
        }

        private void bDepartementSave_Click(object sender, EventArgs e)
        {
            Departement departement = cbDepartement.SelectedItem as Departement;
            if (departement == null)
            {
                return;
            }

            string nouveauNom = tbDepartementNom.Text;
            if (nouveauNom.Length == 0)
            {
                MessageBox.Show("Veuillez entrer un nom pour le département.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Departement departementBDD = db.Departement.Find(departement.id);
            departementBDD.nom = nouveauNom;

            db.SaveChanges();

            Composante composante = cbComposante.SelectedItem as Composante;
            updateDepartements(composante);
            cbDepartement.SelectedItem = departementBDD;
        }

        /**********************************************
         *********** Boutons de suppression ***********
         **********************************************/

        private void bComposanteDelete_Click(object sender, EventArgs e)
        {
            Composante composante = cbComposante.SelectedItem as Composante;
            if (composante == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Vous êtes sur le point de supprimer la composante " + composante.nom + ". Voulez-vous continuer ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                supprimerComposante(composante);
            }
        }

        private void bDepartementDelete_Click(object sender, EventArgs e)
        {
            Departement departement = cbDepartement.SelectedItem as Departement;
            Composante composante = cbComposante.SelectedItem as Composante;
            if (departement == null || composante == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show("Vous êtes sur le point de supprimer le département " + departement.nom + " de la composante " + composante.nom + ". Voulez-vous continuer ?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                supprimerDepartement(departement);
            }
        }

        /**********************************************
         ********** Méthodes de suppression ***********
         **********************************************/
        private void supprimerDepartement(Departement departement)
        {
            try
            {
                Departement departementBDD = db.Departement.Find(departement.id);

                List<Diplome> diplome = db.Diplome.Where(d => d.departementID == departement.id).ToList();
                for (int i = 0; i < diplome.Count; i++)
                {
                    supprimerDiplome(diplome[i]);
                }

                List<Personnel> enseignants = departement.Personnel.ToList();
                for (int i = 0; i < enseignants.Count; i++)
                {
                    departementBDD.Personnel.Remove(enseignants[i]);
                    db.SaveChanges();
                }

                db.Departement.Remove(departement);
                db.SaveChanges();
                Composante composante = cbComposante.SelectedItem as Composante;
                updateDepartements(composante);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de suppression du département", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supprimerComposante(Composante composante)
        {
            try
            {
                List<Departement> departement = db.Departement.Where(dep => dep.composanteID == composante.id).ToList();

                for (int i = 0; i < departement.Count; i++)
                {
                    supprimerDepartement(departement[i]);
                }

                db.Composante.Remove(composante);
                db.SaveChanges();
                updateComposantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de suppression de la composante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**********************************************
         ************** Actualisations ****************
         **********************************************/

        private void cbComposante_SelectedIndexChanged(object sender, EventArgs e)
        {
            Composante composante = cbComposante.SelectedItem as Composante;
            if (composante != null)
            {
                tbComposanteNom.Text = composante.nom;
            }
            else
            {
                tbComposanteNom.Text = "";
            }
            this.updateDepartements(composante);
        }

        private void cbDepartement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departement departement = cbDepartement.SelectedItem as Departement;

            if (departement == null)
            {
                tbDepartementNom.Text = "";
            }
            else
            {
                tbDepartementNom.Text = departement.nom;
            }

            this.updatePersonnel();
            this.updateDiplomes(departement);
            this.refreshPersonnelDataGridView();
        }

    }
}