namespace projet_dot_net
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tcMenu = new System.Windows.Forms.TabControl();
            this.tbComposante = new System.Windows.Forms.TabPage();
            this.gbDepartement = new System.Windows.Forms.GroupBox();
            this.bDepartementDelete = new System.Windows.Forms.Button();
            this.bDepartementSave = new System.Windows.Forms.Button();
            this.cbDepartement = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDepartementNom = new System.Windows.Forms.TextBox();
            this.bDepartementAjouter = new System.Windows.Forms.Button();
            this.gbComposante = new System.Windows.Forms.GroupBox();
            this.bComposanteDelete = new System.Windows.Forms.Button();
            this.bComposanteSave = new System.Windows.Forms.Button();
            this.cbComposante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbComposanteNom = new System.Windows.Forms.TextBox();
            this.bComposanteAjouter = new System.Windows.Forms.Button();
            this.tpPersonnel = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prénomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catégorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pourcentageDuServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heuresEQTDEffectuéesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heuresEQTDÀEffectuerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personneldashboardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ufrDataSet = new projet_dot_net.ufrDataSet();
            this.gbAjouterEns = new System.Windows.Forms.GroupBox();
            this.bAjouterEns = new System.Windows.Forms.Button();
            this.tbAjouterEnsPrenom = new System.Windows.Forms.TextBox();
            this.bSelectEnsExistant = new System.Windows.Forms.Button();
            this.labelAjouterEnsNom = new System.Windows.Forms.Label();
            this.labelAjouterEnsCategorie = new System.Windows.Forms.Label();
            this.tbAjouterEnsNom = new System.Windows.Forms.TextBox();
            this.cbAjouterEnsCategorie = new System.Windows.Forms.ComboBox();
            this.labelAjouterEnsPrenom = new System.Windows.Forms.Label();
            this.gbModifierEns = new System.Windows.Forms.GroupBox();
            this.bDissocierEnseignant = new System.Windows.Forms.Button();
            this.bSupprimerEns = new System.Windows.Forms.Button();
            this.cbPersonnelModifierEns = new System.Windows.Forms.ComboBox();
            this.labelModifierEns = new System.Windows.Forms.Label();
            this.bModifierEnsSave = new System.Windows.Forms.Button();
            this.cbModifierEnsCategorie = new System.Windows.Forms.ComboBox();
            this.labelModifierEnsCategorie = new System.Windows.Forms.Label();
            this.tpDiplomes = new System.Windows.Forms.TabPage();
            this.gbDiplome = new System.Windows.Forms.GroupBox();
            this.bDiplomeSupprimer = new System.Windows.Forms.Button();
            this.bDiplomeSave = new System.Windows.Forms.Button();
            this.cbDiplome = new System.Windows.Forms.ComboBox();
            this.labelDiplomeIntitule = new System.Windows.Forms.Label();
            this.tbDiplomeIntitule = new System.Windows.Forms.TextBox();
            this.labelDiplomeNbAnnees = new System.Windows.Forms.Label();
            this.nudDiplomeAnnees = new System.Windows.Forms.NumericUpDown();
            this.bDiplomeNouveau = new System.Windows.Forms.Button();
            this.gbAnnee = new System.Windows.Forms.GroupBox();
            this.bAnneeSupprimer = new System.Windows.Forms.Button();
            this.bAnneeSave = new System.Windows.Forms.Button();
            this.cbAnnee = new System.Windows.Forms.ComboBox();
            this.labelAnneeIntitule = new System.Windows.Forms.Label();
            this.tbAnneeIntitule = new System.Windows.Forms.TextBox();
            this.labelAnneeOrdre = new System.Windows.Forms.Label();
            this.nudAnneeOrdre = new System.Windows.Forms.NumericUpDown();
            this.bAnneeAjouter = new System.Windows.Forms.Button();
            this.gbUE = new System.Windows.Forms.GroupBox();
            this.bUEDissocier = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbUESemestre = new System.Windows.Forms.ComboBox();
            this.bUEAjouterExistant = new System.Windows.Forms.Button();
            this.labelSemestre = new System.Windows.Forms.Label();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.bUESupprimer = new System.Windows.Forms.Button();
            this.bUESave = new System.Windows.Forms.Button();
            this.labelUENomComplet = new System.Windows.Forms.Label();
            this.tbUENomComplet = new System.Windows.Forms.TextBox();
            this.labelUERef = new System.Windows.Forms.Label();
            this.bUEAjouter = new System.Windows.Forms.Button();
            this.tbUERef = new System.Windows.Forms.TextBox();
            this.cbUE = new System.Windows.Forms.ComboBox();
            this.gbEC = new System.Windows.Forms.GroupBox();
            this.bECSupprimer = new System.Windows.Forms.Button();
            this.bECSave = new System.Windows.Forms.Button();
            this.labelECNomComplet = new System.Windows.Forms.Label();
            this.tbECNomComplet = new System.Windows.Forms.TextBox();
            this.nudECHeures = new System.Windows.Forms.NumericUpDown();
            this.labelECRef = new System.Windows.Forms.Label();
            this.labelECHeures = new System.Windows.Forms.Label();
            this.tbECRef = new System.Windows.Forms.TextBox();
            this.bECAjouter = new System.Windows.Forms.Button();
            this.cbEC = new System.Windows.Forms.ComboBox();
            this.gbCours = new System.Windows.Forms.GroupBox();
            this.bCoursSuppr = new System.Windows.Forms.Button();
            this.bCoursSave = new System.Windows.Forms.Button();
            this.cbCours = new System.Windows.Forms.ComboBox();
            this.labelCoursType = new System.Windows.Forms.Label();
            this.cbCoursType = new System.Windows.Forms.ComboBox();
            this.tbCoursIntitule = new System.Windows.Forms.TextBox();
            this.nudCoursGroupes = new System.Windows.Forms.NumericUpDown();
            this.bCoursAjouter = new System.Windows.Forms.Button();
            this.labelCoursGroupes = new System.Windows.Forms.Label();
            this.labelCoursHeures = new System.Windows.Forms.Label();
            this.labelCoursIntitule = new System.Windows.Forms.Label();
            this.nudCoursHeures = new System.Windows.Forms.NumericUpDown();
            this.gbEnseignants = new System.Windows.Forms.GroupBox();
            this.bEnseignantRemove = new System.Windows.Forms.Button();
            this.labelEnseignantsNonaffectes = new System.Windows.Forms.Label();
            this.cbEns1 = new System.Windows.Forms.ComboBox();
            this.cbEnsGroupe1 = new System.Windows.Forms.ComboBox();
            this.bEnseignantSave = new System.Windows.Forms.Button();
            this.cbEnsGroupe2 = new System.Windows.Forms.ComboBox();
            this.labelEnseignantsAffectes = new System.Windows.Forms.Label();
            this.labelEnsGroupe1 = new System.Windows.Forms.Label();
            this.labelEnsHeures1 = new System.Windows.Forms.Label();
            this.labelEnsGroupe2 = new System.Windows.Forms.Label();
            this.nudEnsHeures1 = new System.Windows.Forms.NumericUpDown();
            this.bEnsAffecter = new System.Windows.Forms.Button();
            this.cbEns2 = new System.Windows.Forms.ComboBox();
            this.nudEnsHeures2 = new System.Windows.Forms.NumericUpDown();
            this.labelEnsHeures2 = new System.Windows.Forms.Label();
            this.tpFormules = new System.Windows.Forms.TabPage();
            this.gbCategorieSupprimer = new System.Windows.Forms.GroupBox();
            this.bCategorieSupprimer = new System.Windows.Forms.Button();
            this.cbCategorieSupprimer = new System.Windows.Forms.ComboBox();
            this.gbTypeCoursSupprimer = new System.Windows.Forms.GroupBox();
            this.bTypeCoursSupprimer = new System.Windows.Forms.Button();
            this.cbTypeCoursSupprimer = new System.Windows.Forms.ComboBox();
            this.gbFormules = new System.Windows.Forms.GroupBox();
            this.bEQTDSave = new System.Windows.Forms.Button();
            this.formulesSignification = new System.Windows.Forms.Label();
            this.labelFormulesSignification = new System.Windows.Forms.Label();
            this.nudFormulesEQTD = new System.Windows.Forms.NumericUpDown();
            this.labelFormulesEQTD = new System.Windows.Forms.Label();
            this.cbFormulesTypesCours = new System.Windows.Forms.ComboBox();
            this.labelFormulesTypeCours = new System.Windows.Forms.Label();
            this.cbFormulesCategories = new System.Windows.Forms.ComboBox();
            this.labelFormulesCat = new System.Windows.Forms.Label();
            this.gbTypeCours = new System.Windows.Forms.GroupBox();
            this.labelListeTypesCours = new System.Windows.Forms.Label();
            this.labelTypeCoursRappel = new System.Windows.Forms.Label();
            this.bTypeCoursSave = new System.Windows.Forms.Button();
            this.labelTypeCoursIntitule = new System.Windows.Forms.Label();
            this.tbTypeCoursIntitule = new System.Windows.Forms.TextBox();
            this.gbAjouterCategorie = new System.Windows.Forms.GroupBox();
            this.bCategorieSave = new System.Windows.Forms.Button();
            this.nudCategorieNbEQTD = new System.Windows.Forms.NumericUpDown();
            this.labelCategorieNbHeures = new System.Windows.Forms.Label();
            this.tbCategorieIntitule = new System.Windows.Forms.TextBox();
            this.labelAjouterCatIntitule = new System.Windows.Forms.Label();
            this.toolTipHome = new System.Windows.Forms.ToolTip(this.components);
            this.personnel_dashboardTableAdapter = new projet_dot_net.ufrDataSetTableAdapters.personnel_dashboardTableAdapter();
            this.tcMenu.SuspendLayout();
            this.tbComposante.SuspendLayout();
            this.gbDepartement.SuspendLayout();
            this.gbComposante.SuspendLayout();
            this.tpPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneldashboardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufrDataSet)).BeginInit();
            this.gbAjouterEns.SuspendLayout();
            this.gbModifierEns.SuspendLayout();
            this.tpDiplomes.SuspendLayout();
            this.gbDiplome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiplomeAnnees)).BeginInit();
            this.gbAnnee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnneeOrdre)).BeginInit();
            this.gbUE.SuspendLayout();
            this.gbEC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudECHeures)).BeginInit();
            this.gbCours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoursGroupes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoursHeures)).BeginInit();
            this.gbEnseignants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnsHeures1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnsHeures2)).BeginInit();
            this.tpFormules.SuspendLayout();
            this.gbCategorieSupprimer.SuspendLayout();
            this.gbTypeCoursSupprimer.SuspendLayout();
            this.gbFormules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFormulesEQTD)).BeginInit();
            this.gbTypeCours.SuspendLayout();
            this.gbAjouterCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategorieNbEQTD)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMenu
            // 
            this.tcMenu.Controls.Add(this.tbComposante);
            this.tcMenu.Controls.Add(this.tpPersonnel);
            this.tcMenu.Controls.Add(this.tpDiplomes);
            this.tcMenu.Controls.Add(this.tpFormules);
            this.tcMenu.Location = new System.Drawing.Point(3, 4);
            this.tcMenu.Name = "tcMenu";
            this.tcMenu.SelectedIndex = 0;
            this.tcMenu.Size = new System.Drawing.Size(797, 457);
            this.tcMenu.TabIndex = 0;
            // 
            // tbComposante
            // 
            this.tbComposante.Controls.Add(this.gbDepartement);
            this.tbComposante.Controls.Add(this.gbComposante);
            this.tbComposante.Location = new System.Drawing.Point(4, 22);
            this.tbComposante.Margin = new System.Windows.Forms.Padding(2);
            this.tbComposante.Name = "tbComposante";
            this.tbComposante.Padding = new System.Windows.Forms.Padding(2);
            this.tbComposante.Size = new System.Drawing.Size(789, 431);
            this.tbComposante.TabIndex = 3;
            this.tbComposante.Text = "Composante";
            this.tbComposante.UseVisualStyleBackColor = true;
            // 
            // gbDepartement
            // 
            this.gbDepartement.Controls.Add(this.bDepartementDelete);
            this.gbDepartement.Controls.Add(this.bDepartementSave);
            this.gbDepartement.Controls.Add(this.cbDepartement);
            this.gbDepartement.Controls.Add(this.label3);
            this.gbDepartement.Controls.Add(this.tbDepartementNom);
            this.gbDepartement.Controls.Add(this.bDepartementAjouter);
            this.gbDepartement.Location = new System.Drawing.Point(5, 104);
            this.gbDepartement.Name = "gbDepartement";
            this.gbDepartement.Size = new System.Drawing.Size(773, 92);
            this.gbDepartement.TabIndex = 88;
            this.gbDepartement.TabStop = false;
            this.gbDepartement.Text = "Département";
            // 
            // bDepartementDelete
            // 
            this.bDepartementDelete.ForeColor = System.Drawing.Color.Maroon;
            this.bDepartementDelete.Location = new System.Drawing.Point(658, 55);
            this.bDepartementDelete.Name = "bDepartementDelete";
            this.bDepartementDelete.Size = new System.Drawing.Size(101, 23);
            this.bDepartementDelete.TabIndex = 17;
            this.bDepartementDelete.Text = "Supprimer";
            this.bDepartementDelete.UseVisualStyleBackColor = true;
            this.bDepartementDelete.Click += new System.EventHandler(this.bDepartementDelete_Click);
            // 
            // bDepartementSave
            // 
            this.bDepartementSave.ForeColor = System.Drawing.Color.Navy;
            this.bDepartementSave.Location = new System.Drawing.Point(551, 55);
            this.bDepartementSave.Name = "bDepartementSave";
            this.bDepartementSave.Size = new System.Drawing.Size(101, 23);
            this.bDepartementSave.TabIndex = 4;
            this.bDepartementSave.Text = "Enregistrer";
            this.bDepartementSave.UseVisualStyleBackColor = true;
            this.bDepartementSave.Click += new System.EventHandler(this.bDepartementSave_Click);
            // 
            // cbDepartement
            // 
            this.cbDepartement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartement.FormattingEnabled = true;
            this.cbDepartement.Location = new System.Drawing.Point(14, 30);
            this.cbDepartement.Name = "cbDepartement";
            this.cbDepartement.Size = new System.Drawing.Size(363, 21);
            this.cbDepartement.TabIndex = 1;
            this.cbDepartement.SelectedIndexChanged += new System.EventHandler(this.cbDepartement_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // tbDepartementNom
            // 
            this.tbDepartementNom.Location = new System.Drawing.Point(416, 31);
            this.tbDepartementNom.Name = "tbDepartementNom";
            this.tbDepartementNom.Size = new System.Drawing.Size(344, 20);
            this.tbDepartementNom.TabIndex = 3;
            // 
            // bDepartementAjouter
            // 
            this.bDepartementAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bDepartementAjouter.Location = new System.Drawing.Point(416, 55);
            this.bDepartementAjouter.Name = "bDepartementAjouter";
            this.bDepartementAjouter.Size = new System.Drawing.Size(129, 23);
            this.bDepartementAjouter.TabIndex = 16;
            this.bDepartementAjouter.Text = "Nouveau Département";
            this.bDepartementAjouter.UseVisualStyleBackColor = true;
            this.bDepartementAjouter.Click += new System.EventHandler(this.bDepartementAjouter_Click);
            // 
            // gbComposante
            // 
            this.gbComposante.Controls.Add(this.bComposanteDelete);
            this.gbComposante.Controls.Add(this.bComposanteSave);
            this.gbComposante.Controls.Add(this.cbComposante);
            this.gbComposante.Controls.Add(this.label2);
            this.gbComposante.Controls.Add(this.tbComposanteNom);
            this.gbComposante.Controls.Add(this.bComposanteAjouter);
            this.gbComposante.Location = new System.Drawing.Point(5, 6);
            this.gbComposante.Name = "gbComposante";
            this.gbComposante.Size = new System.Drawing.Size(773, 92);
            this.gbComposante.TabIndex = 87;
            this.gbComposante.TabStop = false;
            this.gbComposante.Text = "Composante";
            // 
            // bComposanteDelete
            // 
            this.bComposanteDelete.ForeColor = System.Drawing.Color.Maroon;
            this.bComposanteDelete.Location = new System.Drawing.Point(658, 55);
            this.bComposanteDelete.Name = "bComposanteDelete";
            this.bComposanteDelete.Size = new System.Drawing.Size(101, 23);
            this.bComposanteDelete.TabIndex = 17;
            this.bComposanteDelete.Text = "Supprimer";
            this.bComposanteDelete.UseVisualStyleBackColor = true;
            this.bComposanteDelete.Click += new System.EventHandler(this.bComposanteDelete_Click);
            // 
            // bComposanteSave
            // 
            this.bComposanteSave.ForeColor = System.Drawing.Color.Navy;
            this.bComposanteSave.Location = new System.Drawing.Point(551, 55);
            this.bComposanteSave.Name = "bComposanteSave";
            this.bComposanteSave.Size = new System.Drawing.Size(101, 23);
            this.bComposanteSave.TabIndex = 4;
            this.bComposanteSave.Text = "Enregistrer";
            this.bComposanteSave.UseVisualStyleBackColor = true;
            this.bComposanteSave.Click += new System.EventHandler(this.bComposanteSave_Click);
            // 
            // cbComposante
            // 
            this.cbComposante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComposante.FormattingEnabled = true;
            this.cbComposante.Location = new System.Drawing.Point(14, 30);
            this.cbComposante.Name = "cbComposante";
            this.cbComposante.Size = new System.Drawing.Size(363, 21);
            this.cbComposante.TabIndex = 1;
            this.cbComposante.SelectedIndexChanged += new System.EventHandler(this.cbComposante_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            // 
            // tbComposanteNom
            // 
            this.tbComposanteNom.Location = new System.Drawing.Point(416, 31);
            this.tbComposanteNom.Name = "tbComposanteNom";
            this.tbComposanteNom.Size = new System.Drawing.Size(344, 20);
            this.tbComposanteNom.TabIndex = 3;
            // 
            // bComposanteAjouter
            // 
            this.bComposanteAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bComposanteAjouter.Location = new System.Drawing.Point(416, 55);
            this.bComposanteAjouter.Name = "bComposanteAjouter";
            this.bComposanteAjouter.Size = new System.Drawing.Size(129, 23);
            this.bComposanteAjouter.TabIndex = 16;
            this.bComposanteAjouter.Text = "Nouvelle composante";
            this.bComposanteAjouter.UseVisualStyleBackColor = true;
            this.bComposanteAjouter.Click += new System.EventHandler(this.bComposanteAjouter_Click);
            // 
            // tpPersonnel
            // 
            this.tpPersonnel.Controls.Add(this.dataGridView1);
            this.tpPersonnel.Controls.Add(this.gbAjouterEns);
            this.tpPersonnel.Controls.Add(this.gbModifierEns);
            this.tpPersonnel.Location = new System.Drawing.Point(4, 22);
            this.tpPersonnel.Name = "tpPersonnel";
            this.tpPersonnel.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonnel.Size = new System.Drawing.Size(789, 431);
            this.tpPersonnel.TabIndex = 0;
            this.tpPersonnel.Text = "Personnel";
            this.tpPersonnel.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prénomDataGridViewTextBoxColumn,
            this.catégorieDataGridViewTextBoxColumn,
            this.pourcentageDuServiceDataGridViewTextBoxColumn,
            this.heuresEQTDEffectuéesDataGridViewTextBoxColumn,
            this.heuresEQTDÀEffectuerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personneldashboardBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(784, 312);
            this.dataGridView1.TabIndex = 13;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // prénomDataGridViewTextBoxColumn
            // 
            this.prénomDataGridViewTextBoxColumn.DataPropertyName = "Prénom";
            this.prénomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prénomDataGridViewTextBoxColumn.Name = "prénomDataGridViewTextBoxColumn";
            this.prénomDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // catégorieDataGridViewTextBoxColumn
            // 
            this.catégorieDataGridViewTextBoxColumn.DataPropertyName = "Catégorie";
            this.catégorieDataGridViewTextBoxColumn.HeaderText = "Catégorie";
            this.catégorieDataGridViewTextBoxColumn.Name = "catégorieDataGridViewTextBoxColumn";
            this.catégorieDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // pourcentageDuServiceDataGridViewTextBoxColumn
            // 
            this.pourcentageDuServiceDataGridViewTextBoxColumn.DataPropertyName = "Pourcentage du service";
            this.pourcentageDuServiceDataGridViewTextBoxColumn.HeaderText = "Pourcentage du service";
            this.pourcentageDuServiceDataGridViewTextBoxColumn.Name = "pourcentageDuServiceDataGridViewTextBoxColumn";
            this.pourcentageDuServiceDataGridViewTextBoxColumn.ReadOnly = true;
            this.pourcentageDuServiceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // heuresEQTDEffectuéesDataGridViewTextBoxColumn
            // 
            this.heuresEQTDEffectuéesDataGridViewTextBoxColumn.DataPropertyName = "Heures EQTD effectuées";
            this.heuresEQTDEffectuéesDataGridViewTextBoxColumn.HeaderText = "Heures EQTD effectuées";
            this.heuresEQTDEffectuéesDataGridViewTextBoxColumn.Name = "heuresEQTDEffectuéesDataGridViewTextBoxColumn";
            this.heuresEQTDEffectuéesDataGridViewTextBoxColumn.ReadOnly = true;
            this.heuresEQTDEffectuéesDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // heuresEQTDÀEffectuerDataGridViewTextBoxColumn
            // 
            this.heuresEQTDÀEffectuerDataGridViewTextBoxColumn.DataPropertyName = "Heures EQTD à effectuer";
            this.heuresEQTDÀEffectuerDataGridViewTextBoxColumn.HeaderText = "Heures EQTD à effectuer";
            this.heuresEQTDÀEffectuerDataGridViewTextBoxColumn.Name = "heuresEQTDÀEffectuerDataGridViewTextBoxColumn";
            this.heuresEQTDÀEffectuerDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // personneldashboardBindingSource
            // 
            this.personneldashboardBindingSource.DataMember = "personnel_dashboard";
            this.personneldashboardBindingSource.DataSource = this.ufrDataSet;
            // 
            // ufrDataSet
            // 
            this.ufrDataSet.DataSetName = "ufrDataSet";
            this.ufrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbAjouterEns
            // 
            this.gbAjouterEns.Controls.Add(this.bAjouterEns);
            this.gbAjouterEns.Controls.Add(this.tbAjouterEnsPrenom);
            this.gbAjouterEns.Controls.Add(this.bSelectEnsExistant);
            this.gbAjouterEns.Controls.Add(this.labelAjouterEnsNom);
            this.gbAjouterEns.Controls.Add(this.labelAjouterEnsCategorie);
            this.gbAjouterEns.Controls.Add(this.tbAjouterEnsNom);
            this.gbAjouterEns.Controls.Add(this.cbAjouterEnsCategorie);
            this.gbAjouterEns.Controls.Add(this.labelAjouterEnsPrenom);
            this.gbAjouterEns.Location = new System.Drawing.Point(7, 322);
            this.gbAjouterEns.Name = "gbAjouterEns";
            this.gbAjouterEns.Size = new System.Drawing.Size(773, 49);
            this.gbAjouterEns.TabIndex = 12;
            this.gbAjouterEns.TabStop = false;
            this.gbAjouterEns.Text = "Ajouter un enseignant";
            // 
            // bAjouterEns
            // 
            this.bAjouterEns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bAjouterEns.Location = new System.Drawing.Point(665, 18);
            this.bAjouterEns.Name = "bAjouterEns";
            this.bAjouterEns.Size = new System.Drawing.Size(69, 23);
            this.bAjouterEns.TabIndex = 15;
            this.bAjouterEns.Text = "Créer";
            this.bAjouterEns.UseVisualStyleBackColor = true;
            this.bAjouterEns.Click += new System.EventHandler(this.bAjouterEns_Click);
            // 
            // tbAjouterEnsPrenom
            // 
            this.tbAjouterEnsPrenom.Location = new System.Drawing.Point(265, 19);
            this.tbAjouterEnsPrenom.Name = "tbAjouterEnsPrenom";
            this.tbAjouterEnsPrenom.Size = new System.Drawing.Size(174, 20);
            this.tbAjouterEnsPrenom.TabIndex = 5;
            // 
            // bSelectEnsExistant
            // 
            this.bSelectEnsExistant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bSelectEnsExistant.Location = new System.Drawing.Point(739, 18);
            this.bSelectEnsExistant.Name = "bSelectEnsExistant";
            this.bSelectEnsExistant.Size = new System.Drawing.Size(23, 23);
            this.bSelectEnsExistant.TabIndex = 8;
            this.bSelectEnsExistant.Text = "+";
            this.toolTipHome.SetToolTip(this.bSelectEnsExistant, "Ajouter un enseignant existant");
            this.bSelectEnsExistant.UseVisualStyleBackColor = true;
            this.bSelectEnsExistant.Click += new System.EventHandler(this.bSelectEnsExistant_Click);
            // 
            // labelAjouterEnsNom
            // 
            this.labelAjouterEnsNom.AutoSize = true;
            this.labelAjouterEnsNom.Location = new System.Drawing.Point(8, 23);
            this.labelAjouterEnsNom.Name = "labelAjouterEnsNom";
            this.labelAjouterEnsNom.Size = new System.Drawing.Size(29, 13);
            this.labelAjouterEnsNom.TabIndex = 2;
            this.labelAjouterEnsNom.Text = "Nom";
            // 
            // labelAjouterEnsCategorie
            // 
            this.labelAjouterEnsCategorie.AutoSize = true;
            this.labelAjouterEnsCategorie.Location = new System.Drawing.Point(443, 23);
            this.labelAjouterEnsCategorie.Name = "labelAjouterEnsCategorie";
            this.labelAjouterEnsCategorie.Size = new System.Drawing.Size(52, 13);
            this.labelAjouterEnsCategorie.TabIndex = 7;
            this.labelAjouterEnsCategorie.Text = "Catégorie";
            // 
            // tbAjouterEnsNom
            // 
            this.tbAjouterEnsNom.Location = new System.Drawing.Point(41, 19);
            this.tbAjouterEnsNom.Name = "tbAjouterEnsNom";
            this.tbAjouterEnsNom.Size = new System.Drawing.Size(173, 20);
            this.tbAjouterEnsNom.TabIndex = 3;
            // 
            // cbAjouterEnsCategorie
            // 
            this.cbAjouterEnsCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAjouterEnsCategorie.FormattingEnabled = true;
            this.cbAjouterEnsCategorie.Location = new System.Drawing.Point(499, 19);
            this.cbAjouterEnsCategorie.Name = "cbAjouterEnsCategorie";
            this.cbAjouterEnsCategorie.Size = new System.Drawing.Size(158, 21);
            this.cbAjouterEnsCategorie.TabIndex = 6;
            // 
            // labelAjouterEnsPrenom
            // 
            this.labelAjouterEnsPrenom.AutoSize = true;
            this.labelAjouterEnsPrenom.Location = new System.Drawing.Point(218, 23);
            this.labelAjouterEnsPrenom.Name = "labelAjouterEnsPrenom";
            this.labelAjouterEnsPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelAjouterEnsPrenom.TabIndex = 4;
            this.labelAjouterEnsPrenom.Text = "Prénom";
            // 
            // gbModifierEns
            // 
            this.gbModifierEns.Controls.Add(this.bDissocierEnseignant);
            this.gbModifierEns.Controls.Add(this.bSupprimerEns);
            this.gbModifierEns.Controls.Add(this.cbPersonnelModifierEns);
            this.gbModifierEns.Controls.Add(this.labelModifierEns);
            this.gbModifierEns.Controls.Add(this.bModifierEnsSave);
            this.gbModifierEns.Controls.Add(this.cbModifierEnsCategorie);
            this.gbModifierEns.Controls.Add(this.labelModifierEnsCategorie);
            this.gbModifierEns.Location = new System.Drawing.Point(7, 377);
            this.gbModifierEns.Name = "gbModifierEns";
            this.gbModifierEns.Size = new System.Drawing.Size(773, 50);
            this.gbModifierEns.TabIndex = 10;
            this.gbModifierEns.TabStop = false;
            this.gbModifierEns.Text = "Modifier ou supprimer un enseignant";
            // 
            // bDissocierEnseignant
            // 
            this.bDissocierEnseignant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDissocierEnseignant.ForeColor = System.Drawing.Color.Maroon;
            this.bDissocierEnseignant.Location = new System.Drawing.Point(739, 17);
            this.bDissocierEnseignant.Name = "bDissocierEnseignant";
            this.bDissocierEnseignant.Size = new System.Drawing.Size(23, 23);
            this.bDissocierEnseignant.TabIndex = 16;
            this.bDissocierEnseignant.Text = "-";
            this.toolTipHome.SetToolTip(this.bDissocierEnseignant, "Dissocier l\'enseignant sélectionné de la composante courante");
            this.bDissocierEnseignant.UseVisualStyleBackColor = true;
            this.bDissocierEnseignant.Click += new System.EventHandler(this.bDissocierEnseignant_Click);
            // 
            // bSupprimerEns
            // 
            this.bSupprimerEns.ForeColor = System.Drawing.Color.Maroon;
            this.bSupprimerEns.Location = new System.Drawing.Point(658, 17);
            this.bSupprimerEns.Name = "bSupprimerEns";
            this.bSupprimerEns.Size = new System.Drawing.Size(75, 23);
            this.bSupprimerEns.TabIndex = 14;
            this.bSupprimerEns.Text = "Supprimer";
            this.bSupprimerEns.UseVisualStyleBackColor = true;
            this.bSupprimerEns.Click += new System.EventHandler(this.bSupprimerEns_Click);
            // 
            // cbPersonnelModifierEns
            // 
            this.cbPersonnelModifierEns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPersonnelModifierEns.FormattingEnabled = true;
            this.cbPersonnelModifierEns.Location = new System.Drawing.Point(74, 19);
            this.cbPersonnelModifierEns.Name = "cbPersonnelModifierEns";
            this.cbPersonnelModifierEns.Size = new System.Drawing.Size(258, 21);
            this.cbPersonnelModifierEns.TabIndex = 12;
            this.cbPersonnelModifierEns.SelectedIndexChanged += new System.EventHandler(this.cbPersonnelModifierEns_SelectedIndexChanged);
            // 
            // labelModifierEns
            // 
            this.labelModifierEns.AutoSize = true;
            this.labelModifierEns.Location = new System.Drawing.Point(8, 22);
            this.labelModifierEns.Name = "labelModifierEns";
            this.labelModifierEns.Size = new System.Drawing.Size(60, 13);
            this.labelModifierEns.TabIndex = 13;
            this.labelModifierEns.Text = "Enseignant";
            // 
            // bModifierEnsSave
            // 
            this.bModifierEnsSave.ForeColor = System.Drawing.Color.Navy;
            this.bModifierEnsSave.Location = new System.Drawing.Point(577, 17);
            this.bModifierEnsSave.Name = "bModifierEnsSave";
            this.bModifierEnsSave.Size = new System.Drawing.Size(75, 23);
            this.bModifierEnsSave.TabIndex = 11;
            this.bModifierEnsSave.Text = "Enregistrer";
            this.bModifierEnsSave.UseVisualStyleBackColor = true;
            this.bModifierEnsSave.Click += new System.EventHandler(this.bModifierEnsSave_Click);
            // 
            // cbModifierEnsCategorie
            // 
            this.cbModifierEnsCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModifierEnsCategorie.FormattingEnabled = true;
            this.cbModifierEnsCategorie.Location = new System.Drawing.Point(394, 19);
            this.cbModifierEnsCategorie.Name = "cbModifierEnsCategorie";
            this.cbModifierEnsCategorie.Size = new System.Drawing.Size(177, 21);
            this.cbModifierEnsCategorie.TabIndex = 9;
            // 
            // labelModifierEnsCategorie
            // 
            this.labelModifierEnsCategorie.AutoSize = true;
            this.labelModifierEnsCategorie.Location = new System.Drawing.Point(337, 22);
            this.labelModifierEnsCategorie.Name = "labelModifierEnsCategorie";
            this.labelModifierEnsCategorie.Size = new System.Drawing.Size(52, 13);
            this.labelModifierEnsCategorie.TabIndex = 10;
            this.labelModifierEnsCategorie.Text = "Catégorie";
            // 
            // tpDiplomes
            // 
            this.tpDiplomes.Controls.Add(this.gbDiplome);
            this.tpDiplomes.Controls.Add(this.gbAnnee);
            this.tpDiplomes.Controls.Add(this.gbUE);
            this.tpDiplomes.Controls.Add(this.gbEC);
            this.tpDiplomes.Controls.Add(this.gbCours);
            this.tpDiplomes.Controls.Add(this.gbEnseignants);
            this.tpDiplomes.Location = new System.Drawing.Point(4, 22);
            this.tpDiplomes.Name = "tpDiplomes";
            this.tpDiplomes.Padding = new System.Windows.Forms.Padding(3);
            this.tpDiplomes.Size = new System.Drawing.Size(789, 431);
            this.tpDiplomes.TabIndex = 1;
            this.tpDiplomes.Text = "Diplômes";
            this.tpDiplomes.UseVisualStyleBackColor = true;
            // 
            // gbDiplome
            // 
            this.gbDiplome.Controls.Add(this.bDiplomeSupprimer);
            this.gbDiplome.Controls.Add(this.bDiplomeSave);
            this.gbDiplome.Controls.Add(this.cbDiplome);
            this.gbDiplome.Controls.Add(this.labelDiplomeIntitule);
            this.gbDiplome.Controls.Add(this.tbDiplomeIntitule);
            this.gbDiplome.Controls.Add(this.labelDiplomeNbAnnees);
            this.gbDiplome.Controls.Add(this.nudDiplomeAnnees);
            this.gbDiplome.Controls.Add(this.bDiplomeNouveau);
            this.gbDiplome.Location = new System.Drawing.Point(7, 8);
            this.gbDiplome.Name = "gbDiplome";
            this.gbDiplome.Size = new System.Drawing.Size(773, 50);
            this.gbDiplome.TabIndex = 86;
            this.gbDiplome.TabStop = false;
            this.gbDiplome.Text = "Diplôme";
            // 
            // bDiplomeSupprimer
            // 
            this.bDiplomeSupprimer.ForeColor = System.Drawing.Color.Maroon;
            this.bDiplomeSupprimer.Location = new System.Drawing.Point(666, 18);
            this.bDiplomeSupprimer.Name = "bDiplomeSupprimer";
            this.bDiplomeSupprimer.Size = new System.Drawing.Size(101, 23);
            this.bDiplomeSupprimer.TabIndex = 17;
            this.bDiplomeSupprimer.Text = "Supprimer";
            this.bDiplomeSupprimer.UseVisualStyleBackColor = true;
            this.bDiplomeSupprimer.Click += new System.EventHandler(this.bDiplomeSupprimer_Click);
            // 
            // bDiplomeSave
            // 
            this.bDiplomeSave.ForeColor = System.Drawing.Color.Navy;
            this.bDiplomeSave.Location = new System.Drawing.Point(561, 18);
            this.bDiplomeSave.Name = "bDiplomeSave";
            this.bDiplomeSave.Size = new System.Drawing.Size(101, 23);
            this.bDiplomeSave.TabIndex = 4;
            this.bDiplomeSave.Text = "Enregistrer";
            this.bDiplomeSave.UseVisualStyleBackColor = true;
            this.bDiplomeSave.Click += new System.EventHandler(this.bDiplomeSave_Click);
            // 
            // cbDiplome
            // 
            this.cbDiplome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiplome.FormattingEnabled = true;
            this.cbDiplome.Location = new System.Drawing.Point(11, 19);
            this.cbDiplome.Name = "cbDiplome";
            this.cbDiplome.Size = new System.Drawing.Size(158, 21);
            this.cbDiplome.TabIndex = 1;
            this.cbDiplome.SelectedIndexChanged += new System.EventHandler(this.cbDiplomes_SelectedIndexChanged);
            // 
            // labelDiplomeIntitule
            // 
            this.labelDiplomeIntitule.AutoSize = true;
            this.labelDiplomeIntitule.Location = new System.Drawing.Point(281, 23);
            this.labelDiplomeIntitule.Name = "labelDiplomeIntitule";
            this.labelDiplomeIntitule.Size = new System.Drawing.Size(38, 13);
            this.labelDiplomeIntitule.TabIndex = 2;
            this.labelDiplomeIntitule.Text = "Intitulé";
            // 
            // tbDiplomeIntitule
            // 
            this.tbDiplomeIntitule.Location = new System.Drawing.Point(321, 19);
            this.tbDiplomeIntitule.Name = "tbDiplomeIntitule";
            this.tbDiplomeIntitule.Size = new System.Drawing.Size(157, 20);
            this.tbDiplomeIntitule.TabIndex = 3;
            // 
            // labelDiplomeNbAnnees
            // 
            this.labelDiplomeNbAnnees.AutoSize = true;
            this.labelDiplomeNbAnnees.Location = new System.Drawing.Point(483, 23);
            this.labelDiplomeNbAnnees.Name = "labelDiplomeNbAnnees";
            this.labelDiplomeNbAnnees.Size = new System.Drawing.Size(43, 13);
            this.labelDiplomeNbAnnees.TabIndex = 12;
            this.labelDiplomeNbAnnees.Text = "Années";
            this.toolTipHome.SetToolTip(this.labelDiplomeNbAnnees, "Nombre d\'années d\'études dans le diplôme");
            // 
            // nudDiplomeAnnees
            // 
            this.nudDiplomeAnnees.Location = new System.Drawing.Point(526, 19);
            this.nudDiplomeAnnees.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudDiplomeAnnees.Name = "nudDiplomeAnnees";
            this.nudDiplomeAnnees.Size = new System.Drawing.Size(29, 20);
            this.nudDiplomeAnnees.TabIndex = 13;
            // 
            // bDiplomeNouveau
            // 
            this.bDiplomeNouveau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bDiplomeNouveau.Location = new System.Drawing.Point(175, 18);
            this.bDiplomeNouveau.Name = "bDiplomeNouveau";
            this.bDiplomeNouveau.Size = new System.Drawing.Size(101, 23);
            this.bDiplomeNouveau.TabIndex = 16;
            this.bDiplomeNouveau.Text = "Nouveau diplôme";
            this.bDiplomeNouveau.UseVisualStyleBackColor = true;
            this.bDiplomeNouveau.Click += new System.EventHandler(this.bDiplomeNouveau_Click);
            // 
            // gbAnnee
            // 
            this.gbAnnee.Controls.Add(this.bAnneeSupprimer);
            this.gbAnnee.Controls.Add(this.bAnneeSave);
            this.gbAnnee.Controls.Add(this.cbAnnee);
            this.gbAnnee.Controls.Add(this.labelAnneeIntitule);
            this.gbAnnee.Controls.Add(this.tbAnneeIntitule);
            this.gbAnnee.Controls.Add(this.labelAnneeOrdre);
            this.gbAnnee.Controls.Add(this.nudAnneeOrdre);
            this.gbAnnee.Controls.Add(this.bAnneeAjouter);
            this.gbAnnee.Location = new System.Drawing.Point(7, 61);
            this.gbAnnee.Name = "gbAnnee";
            this.gbAnnee.Size = new System.Drawing.Size(773, 50);
            this.gbAnnee.TabIndex = 85;
            this.gbAnnee.TabStop = false;
            this.gbAnnee.Text = "Année";
            // 
            // bAnneeSupprimer
            // 
            this.bAnneeSupprimer.ForeColor = System.Drawing.Color.Maroon;
            this.bAnneeSupprimer.Location = new System.Drawing.Point(666, 17);
            this.bAnneeSupprimer.Name = "bAnneeSupprimer";
            this.bAnneeSupprimer.Size = new System.Drawing.Size(101, 23);
            this.bAnneeSupprimer.TabIndex = 18;
            this.bAnneeSupprimer.Text = "Supprimer";
            this.bAnneeSupprimer.UseVisualStyleBackColor = true;
            this.bAnneeSupprimer.Click += new System.EventHandler(this.bAnneeSupprimer_Click);
            // 
            // bAnneeSave
            // 
            this.bAnneeSave.ForeColor = System.Drawing.Color.Navy;
            this.bAnneeSave.Location = new System.Drawing.Point(561, 17);
            this.bAnneeSave.Name = "bAnneeSave";
            this.bAnneeSave.Size = new System.Drawing.Size(101, 23);
            this.bAnneeSave.TabIndex = 9;
            this.bAnneeSave.Text = "Enregistrer";
            this.bAnneeSave.UseVisualStyleBackColor = true;
            this.bAnneeSave.Click += new System.EventHandler(this.bAnneeSave_Click);
            // 
            // cbAnnee
            // 
            this.cbAnnee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnnee.FormattingEnabled = true;
            this.cbAnnee.Location = new System.Drawing.Point(11, 18);
            this.cbAnnee.Name = "cbAnnee";
            this.cbAnnee.Size = new System.Drawing.Size(158, 21);
            this.cbAnnee.TabIndex = 6;
            this.cbAnnee.SelectedIndexChanged += new System.EventHandler(this.cbAnnee_SelectedIndexChanged);
            // 
            // labelAnneeIntitule
            // 
            this.labelAnneeIntitule.AutoSize = true;
            this.labelAnneeIntitule.Location = new System.Drawing.Point(281, 22);
            this.labelAnneeIntitule.Name = "labelAnneeIntitule";
            this.labelAnneeIntitule.Size = new System.Drawing.Size(38, 13);
            this.labelAnneeIntitule.TabIndex = 7;
            this.labelAnneeIntitule.Text = "Intitulé";
            // 
            // tbAnneeIntitule
            // 
            this.tbAnneeIntitule.Location = new System.Drawing.Point(321, 18);
            this.tbAnneeIntitule.Name = "tbAnneeIntitule";
            this.tbAnneeIntitule.Size = new System.Drawing.Size(157, 20);
            this.tbAnneeIntitule.TabIndex = 8;
            // 
            // labelAnneeOrdre
            // 
            this.labelAnneeOrdre.AutoSize = true;
            this.labelAnneeOrdre.Location = new System.Drawing.Point(487, 21);
            this.labelAnneeOrdre.Name = "labelAnneeOrdre";
            this.labelAnneeOrdre.Size = new System.Drawing.Size(33, 13);
            this.labelAnneeOrdre.TabIndex = 10;
            this.labelAnneeOrdre.Text = "Ordre";
            this.toolTipHome.SetToolTip(this.labelAnneeOrdre, "Ordre de l\'année dans le diplôme");
            // 
            // nudAnneeOrdre
            // 
            this.nudAnneeOrdre.Location = new System.Drawing.Point(526, 18);
            this.nudAnneeOrdre.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudAnneeOrdre.Name = "nudAnneeOrdre";
            this.nudAnneeOrdre.Size = new System.Drawing.Size(29, 20);
            this.nudAnneeOrdre.TabIndex = 11;
            // 
            // bAnneeAjouter
            // 
            this.bAnneeAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bAnneeAjouter.Location = new System.Drawing.Point(176, 17);
            this.bAnneeAjouter.Name = "bAnneeAjouter";
            this.bAnneeAjouter.Size = new System.Drawing.Size(100, 23);
            this.bAnneeAjouter.TabIndex = 17;
            this.bAnneeAjouter.Text = "Nouvelle année";
            this.bAnneeAjouter.UseVisualStyleBackColor = true;
            this.bAnneeAjouter.Click += new System.EventHandler(this.bAnneeAjouter_Click);
            // 
            // gbUE
            // 
            this.gbUE.Controls.Add(this.bUEDissocier);
            this.gbUE.Controls.Add(this.label1);
            this.gbUE.Controls.Add(this.cbUESemestre);
            this.gbUE.Controls.Add(this.bUEAjouterExistant);
            this.gbUE.Controls.Add(this.labelSemestre);
            this.gbUE.Controls.Add(this.cbSemestre);
            this.gbUE.Controls.Add(this.bUESupprimer);
            this.gbUE.Controls.Add(this.bUESave);
            this.gbUE.Controls.Add(this.labelUENomComplet);
            this.gbUE.Controls.Add(this.tbUENomComplet);
            this.gbUE.Controls.Add(this.labelUERef);
            this.gbUE.Controls.Add(this.bUEAjouter);
            this.gbUE.Controls.Add(this.tbUERef);
            this.gbUE.Controls.Add(this.cbUE);
            this.gbUE.Location = new System.Drawing.Point(7, 115);
            this.gbUE.Name = "gbUE";
            this.gbUE.Size = new System.Drawing.Size(773, 75);
            this.gbUE.TabIndex = 83;
            this.gbUE.TabStop = false;
            this.gbUE.Text = "Unités d\'Enseignement (UE)";
            // 
            // bUEDissocier
            // 
            this.bUEDissocier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bUEDissocier.Location = new System.Drawing.Point(613, 18);
            this.bUEDissocier.Name = "bUEDissocier";
            this.bUEDissocier.Size = new System.Drawing.Size(73, 23);
            this.bUEDissocier.TabIndex = 82;
            this.bUEDissocier.Text = "Dissocier";
            this.toolTipHome.SetToolTip(this.bUEDissocier, "Dissocier l\'UE de l\'année sélectionnée, sans la supprimer");
            this.bUEDissocier.UseVisualStyleBackColor = true;
            this.bUEDissocier.Click += new System.EventHandler(this.bUEDissocier_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 87;
            this.label1.Text = "Semestre";
            // 
            // cbUESemestre
            // 
            this.cbUESemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUESemestre.FormattingEnabled = true;
            this.cbUESemestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbUESemestre.Location = new System.Drawing.Point(628, 48);
            this.cbUESemestre.Name = "cbUESemestre";
            this.cbUESemestre.Size = new System.Drawing.Size(33, 21);
            this.cbUESemestre.TabIndex = 88;
            // 
            // bUEAjouterExistant
            // 
            this.bUEAjouterExistant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUEAjouterExistant.ForeColor = System.Drawing.Color.Purple;
            this.bUEAjouterExistant.Location = new System.Drawing.Point(493, 18);
            this.bUEAjouterExistant.Name = "bUEAjouterExistant";
            this.bUEAjouterExistant.Size = new System.Drawing.Size(23, 23);
            this.bUEAjouterExistant.TabIndex = 86;
            this.bUEAjouterExistant.Text = "+";
            this.toolTipHome.SetToolTip(this.bUEAjouterExistant, "Ajouter une UE existante à l\'année sélectionnée");
            this.bUEAjouterExistant.UseVisualStyleBackColor = true;
            this.bUEAjouterExistant.Click += new System.EventHandler(this.bUEAjouterExistant_Click);
            // 
            // labelSemestre
            // 
            this.labelSemestre.AutoSize = true;
            this.labelSemestre.Location = new System.Drawing.Point(9, 23);
            this.labelSemestre.Name = "labelSemestre";
            this.labelSemestre.Size = new System.Drawing.Size(51, 13);
            this.labelSemestre.TabIndex = 14;
            this.labelSemestre.Text = "Semestre";
            // 
            // cbSemestre
            // 
            this.cbSemestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSemestre.Location = new System.Drawing.Point(64, 19);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(33, 21);
            this.cbSemestre.TabIndex = 15;
            this.cbSemestre.SelectedIndexChanged += new System.EventHandler(this.cbSemestre_SelectedIndexChanged);
            // 
            // bUESupprimer
            // 
            this.bUESupprimer.ForeColor = System.Drawing.Color.Maroon;
            this.bUESupprimer.Location = new System.Drawing.Point(689, 18);
            this.bUESupprimer.Name = "bUESupprimer";
            this.bUESupprimer.Size = new System.Drawing.Size(79, 23);
            this.bUESupprimer.TabIndex = 85;
            this.bUESupprimer.Text = "Supprimer";
            this.toolTipHome.SetToolTip(this.bUESupprimer, "Supprimer définitivement l\'UE");
            this.bUESupprimer.UseVisualStyleBackColor = true;
            this.bUESupprimer.Click += new System.EventHandler(this.bUESupprimer_Click);
            // 
            // bUESave
            // 
            this.bUESave.ForeColor = System.Drawing.Color.Navy;
            this.bUESave.Location = new System.Drawing.Point(667, 47);
            this.bUESave.Name = "bUESave";
            this.bUESave.Size = new System.Drawing.Size(101, 23);
            this.bUESave.TabIndex = 22;
            this.bUESave.Text = "Enregistrer";
            this.bUESave.UseVisualStyleBackColor = true;
            this.bUESave.Click += new System.EventHandler(this.bUESave_Click);
            // 
            // labelUENomComplet
            // 
            this.labelUENomComplet.AutoSize = true;
            this.labelUENomComplet.Location = new System.Drawing.Point(173, 52);
            this.labelUENomComplet.Name = "labelUENomComplet";
            this.labelUENomComplet.Size = new System.Drawing.Size(69, 13);
            this.labelUENomComplet.TabIndex = 20;
            this.labelUENomComplet.Text = "Nom complet";
            // 
            // tbUENomComplet
            // 
            this.tbUENomComplet.Location = new System.Drawing.Point(248, 48);
            this.tbUENomComplet.Name = "tbUENomComplet";
            this.tbUENomComplet.Size = new System.Drawing.Size(325, 20);
            this.tbUENomComplet.TabIndex = 21;
            // 
            // labelUERef
            // 
            this.labelUERef.AutoSize = true;
            this.labelUERef.Location = new System.Drawing.Point(9, 52);
            this.labelUERef.Name = "labelUERef";
            this.labelUERef.Size = new System.Drawing.Size(57, 13);
            this.labelUERef.TabIndex = 26;
            this.labelUERef.Text = "Référence";
            // 
            // bUEAjouter
            // 
            this.bUEAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUEAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bUEAjouter.Location = new System.Drawing.Point(519, 18);
            this.bUEAjouter.Name = "bUEAjouter";
            this.bUEAjouter.Size = new System.Drawing.Size(91, 23);
            this.bUEAjouter.TabIndex = 25;
            this.bUEAjouter.Text = "Nouvelle UE";
            this.toolTipHome.SetToolTip(this.bUEAjouter, "Créer une nouvelle UE");
            this.bUEAjouter.UseVisualStyleBackColor = true;
            this.bUEAjouter.Click += new System.EventHandler(this.bUEAjouter_Click);
            // 
            // tbUERef
            // 
            this.tbUERef.Location = new System.Drawing.Point(70, 48);
            this.tbUERef.Name = "tbUERef";
            this.tbUERef.Size = new System.Drawing.Size(97, 20);
            this.tbUERef.TabIndex = 27;
            // 
            // cbUE
            // 
            this.cbUE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUE.FormattingEnabled = true;
            this.cbUE.Location = new System.Drawing.Point(101, 19);
            this.cbUE.Name = "cbUE";
            this.cbUE.Size = new System.Drawing.Size(388, 21);
            this.cbUE.TabIndex = 19;
            this.cbUE.SelectedIndexChanged += new System.EventHandler(this.cbUE_SelectedIndexChanged);
            // 
            // gbEC
            // 
            this.gbEC.Controls.Add(this.bECSupprimer);
            this.gbEC.Controls.Add(this.bECSave);
            this.gbEC.Controls.Add(this.labelECNomComplet);
            this.gbEC.Controls.Add(this.tbECNomComplet);
            this.gbEC.Controls.Add(this.nudECHeures);
            this.gbEC.Controls.Add(this.labelECRef);
            this.gbEC.Controls.Add(this.labelECHeures);
            this.gbEC.Controls.Add(this.tbECRef);
            this.gbEC.Controls.Add(this.bECAjouter);
            this.gbEC.Controls.Add(this.cbEC);
            this.gbEC.Location = new System.Drawing.Point(7, 196);
            this.gbEC.Name = "gbEC";
            this.gbEC.Size = new System.Drawing.Size(773, 75);
            this.gbEC.TabIndex = 82;
            this.gbEC.TabStop = false;
            this.gbEC.Text = "Éléments Constitutifs (EC)";
            // 
            // bECSupprimer
            // 
            this.bECSupprimer.ForeColor = System.Drawing.Color.Maroon;
            this.bECSupprimer.Location = new System.Drawing.Point(589, 18);
            this.bECSupprimer.Name = "bECSupprimer";
            this.bECSupprimer.Size = new System.Drawing.Size(178, 23);
            this.bECSupprimer.TabIndex = 84;
            this.bECSupprimer.Text = "Supprimer l\'EC sélectionné";
            this.bECSupprimer.UseVisualStyleBackColor = true;
            this.bECSupprimer.Click += new System.EventHandler(this.bECSupprimer_Click);
            // 
            // bECSave
            // 
            this.bECSave.ForeColor = System.Drawing.Color.Navy;
            this.bECSave.Location = new System.Drawing.Point(667, 45);
            this.bECSave.Name = "bECSave";
            this.bECSave.Size = new System.Drawing.Size(101, 23);
            this.bECSave.TabIndex = 32;
            this.bECSave.Text = "Enregistrer";
            this.bECSave.UseVisualStyleBackColor = true;
            this.bECSave.Click += new System.EventHandler(this.bECSave_Click);
            // 
            // labelECNomComplet
            // 
            this.labelECNomComplet.AutoSize = true;
            this.labelECNomComplet.Location = new System.Drawing.Point(173, 51);
            this.labelECNomComplet.Name = "labelECNomComplet";
            this.labelECNomComplet.Size = new System.Drawing.Size(69, 13);
            this.labelECNomComplet.TabIndex = 30;
            this.labelECNomComplet.Text = "Nom complet";
            // 
            // tbECNomComplet
            // 
            this.tbECNomComplet.Location = new System.Drawing.Point(248, 47);
            this.tbECNomComplet.Name = "tbECNomComplet";
            this.tbECNomComplet.Size = new System.Drawing.Size(307, 20);
            this.tbECNomComplet.TabIndex = 31;
            // 
            // nudECHeures
            // 
            this.nudECHeures.Location = new System.Drawing.Point(608, 46);
            this.nudECHeures.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudECHeures.Name = "nudECHeures";
            this.nudECHeures.Size = new System.Drawing.Size(53, 20);
            this.nudECHeures.TabIndex = 37;
            // 
            // labelECRef
            // 
            this.labelECRef.AutoSize = true;
            this.labelECRef.Location = new System.Drawing.Point(9, 51);
            this.labelECRef.Name = "labelECRef";
            this.labelECRef.Size = new System.Drawing.Size(57, 13);
            this.labelECRef.TabIndex = 34;
            this.labelECRef.Text = "Référence";
            // 
            // labelECHeures
            // 
            this.labelECHeures.AutoSize = true;
            this.labelECHeures.Location = new System.Drawing.Point(561, 51);
            this.labelECHeures.Name = "labelECHeures";
            this.labelECHeures.Size = new System.Drawing.Size(41, 13);
            this.labelECHeures.TabIndex = 36;
            this.labelECHeures.Text = "Heures";
            this.toolTipHome.SetToolTip(this.labelECHeures, "Heures présentielles des étudiants");
            // 
            // tbECRef
            // 
            this.tbECRef.Location = new System.Drawing.Point(70, 47);
            this.tbECRef.Name = "tbECRef";
            this.tbECRef.Size = new System.Drawing.Size(97, 20);
            this.tbECRef.TabIndex = 35;
            // 
            // bECAjouter
            // 
            this.bECAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bECAjouter.Location = new System.Drawing.Point(468, 18);
            this.bECAjouter.Name = "bECAjouter";
            this.bECAjouter.Size = new System.Drawing.Size(115, 23);
            this.bECAjouter.TabIndex = 33;
            this.bECAjouter.Text = "Nouvel EC";
            this.bECAjouter.UseVisualStyleBackColor = true;
            this.bECAjouter.Click += new System.EventHandler(this.bECAjouter_Click);
            // 
            // cbEC
            // 
            this.cbEC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEC.FormattingEnabled = true;
            this.cbEC.Location = new System.Drawing.Point(11, 19);
            this.cbEC.Name = "cbEC";
            this.cbEC.Size = new System.Drawing.Size(452, 21);
            this.cbEC.TabIndex = 29;
            this.cbEC.SelectedIndexChanged += new System.EventHandler(this.cbEC_SelectedIndexChanged);
            // 
            // gbCours
            // 
            this.gbCours.Controls.Add(this.bCoursSuppr);
            this.gbCours.Controls.Add(this.bCoursSave);
            this.gbCours.Controls.Add(this.cbCours);
            this.gbCours.Controls.Add(this.labelCoursType);
            this.gbCours.Controls.Add(this.cbCoursType);
            this.gbCours.Controls.Add(this.tbCoursIntitule);
            this.gbCours.Controls.Add(this.nudCoursGroupes);
            this.gbCours.Controls.Add(this.bCoursAjouter);
            this.gbCours.Controls.Add(this.labelCoursGroupes);
            this.gbCours.Controls.Add(this.labelCoursHeures);
            this.gbCours.Controls.Add(this.labelCoursIntitule);
            this.gbCours.Controls.Add(this.nudCoursHeures);
            this.gbCours.Location = new System.Drawing.Point(7, 271);
            this.gbCours.Name = "gbCours";
            this.gbCours.Size = new System.Drawing.Size(773, 75);
            this.gbCours.TabIndex = 81;
            this.gbCours.TabStop = false;
            this.gbCours.Text = "Cours";
            // 
            // bCoursSuppr
            // 
            this.bCoursSuppr.ForeColor = System.Drawing.Color.Maroon;
            this.bCoursSuppr.Location = new System.Drawing.Point(590, 19);
            this.bCoursSuppr.Name = "bCoursSuppr";
            this.bCoursSuppr.Size = new System.Drawing.Size(178, 23);
            this.bCoursSuppr.TabIndex = 83;
            this.bCoursSuppr.Text = "Supprimer le cours sélectionné";
            this.bCoursSuppr.UseVisualStyleBackColor = true;
            this.bCoursSuppr.Click += new System.EventHandler(this.bCoursSuppr_Click);
            // 
            // bCoursSave
            // 
            this.bCoursSave.ForeColor = System.Drawing.Color.Navy;
            this.bCoursSave.Location = new System.Drawing.Point(667, 46);
            this.bCoursSave.Name = "bCoursSave";
            this.bCoursSave.Size = new System.Drawing.Size(101, 23);
            this.bCoursSave.TabIndex = 82;
            this.bCoursSave.Text = "Enregistrer";
            this.bCoursSave.UseVisualStyleBackColor = true;
            this.bCoursSave.Click += new System.EventHandler(this.bCoursSave_Click);
            // 
            // cbCours
            // 
            this.cbCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCours.FormattingEnabled = true;
            this.cbCours.Location = new System.Drawing.Point(11, 20);
            this.cbCours.Name = "cbCours";
            this.cbCours.Size = new System.Drawing.Size(452, 21);
            this.cbCours.TabIndex = 39;
            this.cbCours.SelectedIndexChanged += new System.EventHandler(this.cbCours_SelectedIndexChanged);
            // 
            // labelCoursType
            // 
            this.labelCoursType.AutoSize = true;
            this.labelCoursType.Location = new System.Drawing.Point(330, 51);
            this.labelCoursType.Name = "labelCoursType";
            this.labelCoursType.Size = new System.Drawing.Size(31, 13);
            this.labelCoursType.TabIndex = 40;
            this.labelCoursType.Text = "Type";
            // 
            // cbCoursType
            // 
            this.cbCoursType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoursType.FormattingEnabled = true;
            this.cbCoursType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbCoursType.Location = new System.Drawing.Point(367, 47);
            this.cbCoursType.Name = "cbCoursType";
            this.cbCoursType.Size = new System.Drawing.Size(96, 21);
            this.cbCoursType.TabIndex = 51;
            // 
            // tbCoursIntitule
            // 
            this.tbCoursIntitule.Location = new System.Drawing.Point(52, 47);
            this.tbCoursIntitule.Name = "tbCoursIntitule";
            this.tbCoursIntitule.Size = new System.Drawing.Size(272, 20);
            this.tbCoursIntitule.TabIndex = 41;
            // 
            // nudCoursGroupes
            // 
            this.nudCoursGroupes.Location = new System.Drawing.Point(632, 47);
            this.nudCoursGroupes.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.nudCoursGroupes.Name = "nudCoursGroupes";
            this.nudCoursGroupes.Size = new System.Drawing.Size(29, 20);
            this.nudCoursGroupes.TabIndex = 50;
            // 
            // bCoursAjouter
            // 
            this.bCoursAjouter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bCoursAjouter.Location = new System.Drawing.Point(469, 20);
            this.bCoursAjouter.Name = "bCoursAjouter";
            this.bCoursAjouter.Size = new System.Drawing.Size(115, 23);
            this.bCoursAjouter.TabIndex = 43;
            this.bCoursAjouter.Text = "Nouveau cours";
            this.bCoursAjouter.UseVisualStyleBackColor = true;
            this.bCoursAjouter.Click += new System.EventHandler(this.bCoursAjouter_Click);
            // 
            // labelCoursGroupes
            // 
            this.labelCoursGroupes.AutoSize = true;
            this.labelCoursGroupes.Location = new System.Drawing.Point(579, 51);
            this.labelCoursGroupes.Name = "labelCoursGroupes";
            this.labelCoursGroupes.Size = new System.Drawing.Size(47, 13);
            this.labelCoursGroupes.TabIndex = 49;
            this.labelCoursGroupes.Text = "Groupes";
            // 
            // labelCoursHeures
            // 
            this.labelCoursHeures.AutoSize = true;
            this.labelCoursHeures.Location = new System.Drawing.Point(473, 51);
            this.labelCoursHeures.Name = "labelCoursHeures";
            this.labelCoursHeures.Size = new System.Drawing.Size(41, 13);
            this.labelCoursHeures.TabIndex = 46;
            this.labelCoursHeures.Text = "Heures";
            this.toolTipHome.SetToolTip(this.labelCoursHeures, "Heures présentielles des étudiants");
            // 
            // labelCoursIntitule
            // 
            this.labelCoursIntitule.AutoSize = true;
            this.labelCoursIntitule.Location = new System.Drawing.Point(8, 51);
            this.labelCoursIntitule.Name = "labelCoursIntitule";
            this.labelCoursIntitule.Size = new System.Drawing.Size(38, 13);
            this.labelCoursIntitule.TabIndex = 48;
            this.labelCoursIntitule.Text = "Intitulé";
            // 
            // nudCoursHeures
            // 
            this.nudCoursHeures.Location = new System.Drawing.Point(520, 47);
            this.nudCoursHeures.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudCoursHeures.Name = "nudCoursHeures";
            this.nudCoursHeures.Size = new System.Drawing.Size(53, 20);
            this.nudCoursHeures.TabIndex = 47;
            // 
            // gbEnseignants
            // 
            this.gbEnseignants.Controls.Add(this.bEnseignantRemove);
            this.gbEnseignants.Controls.Add(this.labelEnseignantsNonaffectes);
            this.gbEnseignants.Controls.Add(this.cbEns1);
            this.gbEnseignants.Controls.Add(this.cbEnsGroupe1);
            this.gbEnseignants.Controls.Add(this.bEnseignantSave);
            this.gbEnseignants.Controls.Add(this.cbEnsGroupe2);
            this.gbEnseignants.Controls.Add(this.labelEnseignantsAffectes);
            this.gbEnseignants.Controls.Add(this.labelEnsGroupe1);
            this.gbEnseignants.Controls.Add(this.labelEnsHeures1);
            this.gbEnseignants.Controls.Add(this.labelEnsGroupe2);
            this.gbEnseignants.Controls.Add(this.nudEnsHeures1);
            this.gbEnseignants.Controls.Add(this.bEnsAffecter);
            this.gbEnseignants.Controls.Add(this.cbEns2);
            this.gbEnseignants.Controls.Add(this.nudEnsHeures2);
            this.gbEnseignants.Controls.Add(this.labelEnsHeures2);
            this.gbEnseignants.Location = new System.Drawing.Point(7, 346);
            this.gbEnseignants.Name = "gbEnseignants";
            this.gbEnseignants.Size = new System.Drawing.Size(773, 78);
            this.gbEnseignants.TabIndex = 80;
            this.gbEnseignants.TabStop = false;
            this.gbEnseignants.Text = "Enseignants";
            // 
            // bEnseignantRemove
            // 
            this.bEnseignantRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bEnseignantRemove.Location = new System.Drawing.Point(694, 17);
            this.bEnseignantRemove.Name = "bEnseignantRemove";
            this.bEnseignantRemove.Size = new System.Drawing.Size(73, 23);
            this.bEnseignantRemove.TabIndex = 81;
            this.bEnseignantRemove.Text = "Désaffecter";
            this.bEnseignantRemove.UseVisualStyleBackColor = true;
            this.bEnseignantRemove.Click += new System.EventHandler(this.bEnseignantRemove_Click);
            // 
            // labelEnseignantsNonaffectes
            // 
            this.labelEnseignantsNonaffectes.AutoSize = true;
            this.labelEnseignantsNonaffectes.Location = new System.Drawing.Point(9, 51);
            this.labelEnseignantsNonaffectes.Name = "labelEnseignantsNonaffectes";
            this.labelEnseignantsNonaffectes.Size = new System.Drawing.Size(149, 13);
            this.labelEnseignantsNonaffectes.TabIndex = 80;
            this.labelEnseignantsNonaffectes.Text = "Affecter un nouvel enseignant";
            // 
            // cbEns1
            // 
            this.cbEns1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEns1.FormattingEnabled = true;
            this.cbEns1.Location = new System.Drawing.Point(105, 18);
            this.cbEns1.Name = "cbEns1";
            this.cbEns1.Size = new System.Drawing.Size(303, 21);
            this.cbEns1.TabIndex = 53;
            this.cbEns1.SelectedIndexChanged += new System.EventHandler(this.cbEns1_SelectedIndexChanged);
            // 
            // cbEnsGroupe1
            // 
            this.cbEnsGroupe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnsGroupe1.FormattingEnabled = true;
            this.cbEnsGroupe1.Location = new System.Drawing.Point(564, 18);
            this.cbEnsGroupe1.Name = "cbEnsGroupe1";
            this.cbEnsGroupe1.Size = new System.Drawing.Size(37, 21);
            this.cbEnsGroupe1.TabIndex = 79;
            // 
            // bEnseignantSave
            // 
            this.bEnseignantSave.ForeColor = System.Drawing.Color.Navy;
            this.bEnseignantSave.Location = new System.Drawing.Point(608, 17);
            this.bEnseignantSave.Name = "bEnseignantSave";
            this.bEnseignantSave.Size = new System.Drawing.Size(80, 23);
            this.bEnseignantSave.TabIndex = 42;
            this.bEnseignantSave.Text = "Enregistrer";
            this.bEnseignantSave.UseVisualStyleBackColor = true;
            this.bEnseignantSave.Click += new System.EventHandler(this.bEnseignantSave_Click);
            // 
            // cbEnsGroupe2
            // 
            this.cbEnsGroupe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEnsGroupe2.FormattingEnabled = true;
            this.cbEnsGroupe2.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbEnsGroupe2.Location = new System.Drawing.Point(651, 47);
            this.cbEnsGroupe2.Name = "cbEnsGroupe2";
            this.cbEnsGroupe2.Size = new System.Drawing.Size(37, 21);
            this.cbEnsGroupe2.TabIndex = 78;
            // 
            // labelEnseignantsAffectes
            // 
            this.labelEnseignantsAffectes.AutoSize = true;
            this.labelEnseignantsAffectes.Location = new System.Drawing.Point(9, 22);
            this.labelEnseignantsAffectes.Name = "labelEnseignantsAffectes";
            this.labelEnseignantsAffectes.Size = new System.Drawing.Size(90, 13);
            this.labelEnseignantsAffectes.TabIndex = 52;
            this.labelEnseignantsAffectes.Text = "Affectés au cours";
            // 
            // labelEnsGroupe1
            // 
            this.labelEnsGroupe1.AutoSize = true;
            this.labelEnsGroupe1.Location = new System.Drawing.Point(518, 22);
            this.labelEnsGroupe1.Name = "labelEnsGroupe1";
            this.labelEnsGroupe1.Size = new System.Drawing.Size(42, 13);
            this.labelEnsGroupe1.TabIndex = 77;
            this.labelEnsGroupe1.Text = "Groupe";
            // 
            // labelEnsHeures1
            // 
            this.labelEnsHeures1.AutoSize = true;
            this.labelEnsHeures1.Location = new System.Drawing.Point(412, 22);
            this.labelEnsHeures1.Name = "labelEnsHeures1";
            this.labelEnsHeures1.Size = new System.Drawing.Size(41, 13);
            this.labelEnsHeures1.TabIndex = 54;
            this.labelEnsHeures1.Text = "Heures";
            // 
            // labelEnsGroupe2
            // 
            this.labelEnsGroupe2.AutoSize = true;
            this.labelEnsGroupe2.Location = new System.Drawing.Point(604, 51);
            this.labelEnsGroupe2.Name = "labelEnsGroupe2";
            this.labelEnsGroupe2.Size = new System.Drawing.Size(42, 13);
            this.labelEnsGroupe2.TabIndex = 76;
            this.labelEnsGroupe2.Text = "Groupe";
            // 
            // nudEnsHeures1
            // 
            this.nudEnsHeures1.Location = new System.Drawing.Point(459, 18);
            this.nudEnsHeures1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudEnsHeures1.Name = "nudEnsHeures1";
            this.nudEnsHeures1.Size = new System.Drawing.Size(53, 20);
            this.nudEnsHeures1.TabIndex = 55;
            // 
            // bEnsAffecter
            // 
            this.bEnsAffecter.ForeColor = System.Drawing.Color.Green;
            this.bEnsAffecter.Location = new System.Drawing.Point(694, 46);
            this.bEnsAffecter.Name = "bEnsAffecter";
            this.bEnsAffecter.Size = new System.Drawing.Size(73, 23);
            this.bEnsAffecter.TabIndex = 75;
            this.bEnsAffecter.Text = "Affecter";
            this.bEnsAffecter.UseVisualStyleBackColor = true;
            this.bEnsAffecter.Click += new System.EventHandler(this.bEnsAffecter_Click);
            // 
            // cbEns2
            // 
            this.cbEns2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEns2.FormattingEnabled = true;
            this.cbEns2.Location = new System.Drawing.Point(168, 47);
            this.cbEns2.Name = "cbEns2";
            this.cbEns2.Size = new System.Drawing.Size(310, 21);
            this.cbEns2.TabIndex = 56;
            // 
            // nudEnsHeures2
            // 
            this.nudEnsHeures2.Location = new System.Drawing.Point(538, 47);
            this.nudEnsHeures2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudEnsHeures2.Name = "nudEnsHeures2";
            this.nudEnsHeures2.Size = new System.Drawing.Size(53, 20);
            this.nudEnsHeures2.TabIndex = 58;
            // 
            // labelEnsHeures2
            // 
            this.labelEnsHeures2.AutoSize = true;
            this.labelEnsHeures2.Location = new System.Drawing.Point(491, 51);
            this.labelEnsHeures2.Name = "labelEnsHeures2";
            this.labelEnsHeures2.Size = new System.Drawing.Size(41, 13);
            this.labelEnsHeures2.TabIndex = 57;
            this.labelEnsHeures2.Text = "Heures";
            this.toolTipHome.SetToolTip(this.labelEnsHeures2, "Heures présentielles des étudiants");
            // 
            // tpFormules
            // 
            this.tpFormules.Controls.Add(this.gbCategorieSupprimer);
            this.tpFormules.Controls.Add(this.gbTypeCoursSupprimer);
            this.tpFormules.Controls.Add(this.gbFormules);
            this.tpFormules.Controls.Add(this.gbTypeCours);
            this.tpFormules.Controls.Add(this.gbAjouterCategorie);
            this.tpFormules.Location = new System.Drawing.Point(4, 22);
            this.tpFormules.Name = "tpFormules";
            this.tpFormules.Padding = new System.Windows.Forms.Padding(3);
            this.tpFormules.Size = new System.Drawing.Size(789, 431);
            this.tpFormules.TabIndex = 2;
            this.tpFormules.Text = "Formules";
            this.tpFormules.UseVisualStyleBackColor = true;
            // 
            // gbCategorieSupprimer
            // 
            this.gbCategorieSupprimer.Controls.Add(this.bCategorieSupprimer);
            this.gbCategorieSupprimer.Controls.Add(this.cbCategorieSupprimer);
            this.gbCategorieSupprimer.Location = new System.Drawing.Point(400, 155);
            this.gbCategorieSupprimer.Name = "gbCategorieSupprimer";
            this.gbCategorieSupprimer.Size = new System.Drawing.Size(383, 54);
            this.gbCategorieSupprimer.TabIndex = 4;
            this.gbCategorieSupprimer.TabStop = false;
            this.gbCategorieSupprimer.Text = "Supprimer une catégorie";
            // 
            // bCategorieSupprimer
            // 
            this.bCategorieSupprimer.ForeColor = System.Drawing.Color.Maroon;
            this.bCategorieSupprimer.Location = new System.Drawing.Point(283, 21);
            this.bCategorieSupprimer.Name = "bCategorieSupprimer";
            this.bCategorieSupprimer.Size = new System.Drawing.Size(75, 23);
            this.bCategorieSupprimer.TabIndex = 16;
            this.bCategorieSupprimer.Text = "Supprimer";
            this.bCategorieSupprimer.UseVisualStyleBackColor = true;
            this.bCategorieSupprimer.Click += new System.EventHandler(this.bCategorieSupprimer_Click);
            // 
            // cbCategorieSupprimer
            // 
            this.cbCategorieSupprimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorieSupprimer.FormattingEnabled = true;
            this.cbCategorieSupprimer.Location = new System.Drawing.Point(19, 22);
            this.cbCategorieSupprimer.Name = "cbCategorieSupprimer";
            this.cbCategorieSupprimer.Size = new System.Drawing.Size(258, 21);
            this.cbCategorieSupprimer.TabIndex = 18;
            // 
            // gbTypeCoursSupprimer
            // 
            this.gbTypeCoursSupprimer.Controls.Add(this.bTypeCoursSupprimer);
            this.gbTypeCoursSupprimer.Controls.Add(this.cbTypeCoursSupprimer);
            this.gbTypeCoursSupprimer.Location = new System.Drawing.Point(400, 98);
            this.gbTypeCoursSupprimer.Name = "gbTypeCoursSupprimer";
            this.gbTypeCoursSupprimer.Size = new System.Drawing.Size(382, 52);
            this.gbTypeCoursSupprimer.TabIndex = 3;
            this.gbTypeCoursSupprimer.TabStop = false;
            this.gbTypeCoursSupprimer.Text = "Supprimer un type de cours";
            // 
            // bTypeCoursSupprimer
            // 
            this.bTypeCoursSupprimer.ForeColor = System.Drawing.Color.Maroon;
            this.bTypeCoursSupprimer.Location = new System.Drawing.Point(174, 19);
            this.bTypeCoursSupprimer.Name = "bTypeCoursSupprimer";
            this.bTypeCoursSupprimer.Size = new System.Drawing.Size(75, 23);
            this.bTypeCoursSupprimer.TabIndex = 12;
            this.bTypeCoursSupprimer.Text = "Supprimer";
            this.bTypeCoursSupprimer.UseVisualStyleBackColor = true;
            this.bTypeCoursSupprimer.Click += new System.EventHandler(this.bTypeCoursSupprimer_Click);
            // 
            // cbTypeCoursSupprimer
            // 
            this.cbTypeCoursSupprimer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeCoursSupprimer.FormattingEnabled = true;
            this.cbTypeCoursSupprimer.Location = new System.Drawing.Point(19, 19);
            this.cbTypeCoursSupprimer.Name = "cbTypeCoursSupprimer";
            this.cbTypeCoursSupprimer.Size = new System.Drawing.Size(149, 21);
            this.cbTypeCoursSupprimer.TabIndex = 15;
            // 
            // gbFormules
            // 
            this.gbFormules.Controls.Add(this.bEQTDSave);
            this.gbFormules.Controls.Add(this.formulesSignification);
            this.gbFormules.Controls.Add(this.labelFormulesSignification);
            this.gbFormules.Controls.Add(this.nudFormulesEQTD);
            this.gbFormules.Controls.Add(this.labelFormulesEQTD);
            this.gbFormules.Controls.Add(this.cbFormulesTypesCours);
            this.gbFormules.Controls.Add(this.labelFormulesTypeCours);
            this.gbFormules.Controls.Add(this.cbFormulesCategories);
            this.gbFormules.Controls.Add(this.labelFormulesCat);
            this.gbFormules.Location = new System.Drawing.Point(7, 224);
            this.gbFormules.Name = "gbFormules";
            this.gbFormules.Size = new System.Drawing.Size(776, 105);
            this.gbFormules.TabIndex = 2;
            this.gbFormules.TabStop = false;
            this.gbFormules.Text = "Formules";
            // 
            // bEQTDSave
            // 
            this.bEQTDSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bEQTDSave.Location = new System.Drawing.Point(676, 67);
            this.bEQTDSave.Name = "bEQTDSave";
            this.bEQTDSave.Size = new System.Drawing.Size(75, 23);
            this.bEQTDSave.TabIndex = 12;
            this.bEQTDSave.Text = "Enregistrer";
            this.bEQTDSave.UseVisualStyleBackColor = true;
            this.bEQTDSave.Click += new System.EventHandler(this.bEQTDSave_Click);
            // 
            // formulesSignification
            // 
            this.formulesSignification.AutoSize = true;
            this.formulesSignification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulesSignification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formulesSignification.Location = new System.Drawing.Point(84, 72);
            this.formulesSignification.Name = "formulesSignification";
            this.formulesSignification.Size = new System.Drawing.Size(62, 13);
            this.formulesSignification.TabIndex = 13;
            this.formulesSignification.Text = "signification";
            // 
            // labelFormulesSignification
            // 
            this.labelFormulesSignification.AutoSize = true;
            this.labelFormulesSignification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFormulesSignification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFormulesSignification.Location = new System.Drawing.Point(15, 72);
            this.labelFormulesSignification.Name = "labelFormulesSignification";
            this.labelFormulesSignification.Size = new System.Drawing.Size(70, 13);
            this.labelFormulesSignification.TabIndex = 12;
            this.labelFormulesSignification.Text = "Signification :";
            // 
            // nudFormulesEQTD
            // 
            this.nudFormulesEQTD.DecimalPlaces = 2;
            this.nudFormulesEQTD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudFormulesEQTD.Location = new System.Drawing.Point(701, 29);
            this.nudFormulesEQTD.Name = "nudFormulesEQTD";
            this.nudFormulesEQTD.Size = new System.Drawing.Size(50, 20);
            this.nudFormulesEQTD.TabIndex = 5;
            this.nudFormulesEQTD.ValueChanged += new System.EventHandler(this.nudFormulesEQTD_ValueChanged);
            // 
            // labelFormulesEQTD
            // 
            this.labelFormulesEQTD.AutoSize = true;
            this.labelFormulesEQTD.Location = new System.Drawing.Point(620, 33);
            this.labelFormulesEQTD.Name = "labelFormulesEQTD";
            this.labelFormulesEQTD.Size = new System.Drawing.Size(75, 13);
            this.labelFormulesEQTD.TabIndex = 4;
            this.labelFormulesEQTD.Text = "Équivalent TD";
            // 
            // cbFormulesTypesCours
            // 
            this.cbFormulesTypesCours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormulesTypesCours.FormattingEnabled = true;
            this.cbFormulesTypesCours.Location = new System.Drawing.Point(465, 29);
            this.cbFormulesTypesCours.Name = "cbFormulesTypesCours";
            this.cbFormulesTypesCours.Size = new System.Drawing.Size(149, 21);
            this.cbFormulesTypesCours.TabIndex = 3;
            this.cbFormulesTypesCours.SelectedIndexChanged += new System.EventHandler(this.cbFormulesTypesCours_SelectedIndexChanged);
            // 
            // labelFormulesTypeCours
            // 
            this.labelFormulesTypeCours.AutoSize = true;
            this.labelFormulesTypeCours.Location = new System.Drawing.Point(390, 33);
            this.labelFormulesTypeCours.Name = "labelFormulesTypeCours";
            this.labelFormulesTypeCours.Size = new System.Drawing.Size(75, 13);
            this.labelFormulesTypeCours.TabIndex = 2;
            this.labelFormulesTypeCours.Text = "Type de cours";
            // 
            // cbFormulesCategories
            // 
            this.cbFormulesCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormulesCategories.FormattingEnabled = true;
            this.cbFormulesCategories.Location = new System.Drawing.Point(73, 29);
            this.cbFormulesCategories.Name = "cbFormulesCategories";
            this.cbFormulesCategories.Size = new System.Drawing.Size(311, 21);
            this.cbFormulesCategories.TabIndex = 1;
            this.cbFormulesCategories.SelectedIndexChanged += new System.EventHandler(this.cbFormulesCategories_SelectedIndexChanged);
            // 
            // labelFormulesCat
            // 
            this.labelFormulesCat.AutoSize = true;
            this.labelFormulesCat.Location = new System.Drawing.Point(15, 33);
            this.labelFormulesCat.Name = "labelFormulesCat";
            this.labelFormulesCat.Size = new System.Drawing.Size(52, 13);
            this.labelFormulesCat.TabIndex = 0;
            this.labelFormulesCat.Text = "Catégorie";
            // 
            // gbTypeCours
            // 
            this.gbTypeCours.Controls.Add(this.labelListeTypesCours);
            this.gbTypeCours.Controls.Add(this.labelTypeCoursRappel);
            this.gbTypeCours.Controls.Add(this.bTypeCoursSave);
            this.gbTypeCours.Controls.Add(this.labelTypeCoursIntitule);
            this.gbTypeCours.Controls.Add(this.tbTypeCoursIntitule);
            this.gbTypeCours.Location = new System.Drawing.Point(7, 98);
            this.gbTypeCours.Name = "gbTypeCours";
            this.gbTypeCours.Size = new System.Drawing.Size(384, 111);
            this.gbTypeCours.TabIndex = 1;
            this.gbTypeCours.TabStop = false;
            this.gbTypeCours.Text = "Nouveau type de cours";
            // 
            // labelListeTypesCours
            // 
            this.labelListeTypesCours.AutoSize = true;
            this.labelListeTypesCours.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListeTypesCours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelListeTypesCours.Location = new System.Drawing.Point(219, 34);
            this.labelListeTypesCours.Name = "labelListeTypesCours";
            this.labelListeTypesCours.Size = new System.Drawing.Size(25, 13);
            this.labelListeTypesCours.TabIndex = 11;
            this.labelListeTypesCours.Text = "liste";
            // 
            // labelTypeCoursRappel
            // 
            this.labelTypeCoursRappel.AutoSize = true;
            this.labelTypeCoursRappel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTypeCoursRappel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTypeCoursRappel.Location = new System.Drawing.Point(15, 34);
            this.labelTypeCoursRappel.Name = "labelTypeCoursRappel";
            this.labelTypeCoursRappel.Size = new System.Drawing.Size(206, 13);
            this.labelTypeCoursRappel.TabIndex = 10;
            this.labelTypeCoursRappel.Text = "Les types de cours suivants existent déjà :";
            // 
            // bTypeCoursSave
            // 
            this.bTypeCoursSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bTypeCoursSave.Location = new System.Drawing.Point(214, 64);
            this.bTypeCoursSave.Name = "bTypeCoursSave";
            this.bTypeCoursSave.Size = new System.Drawing.Size(75, 23);
            this.bTypeCoursSave.TabIndex = 9;
            this.bTypeCoursSave.Text = "Ajouter";
            this.bTypeCoursSave.UseVisualStyleBackColor = true;
            this.bTypeCoursSave.Click += new System.EventHandler(this.bTypeCoursSave_Click);
            // 
            // labelTypeCoursIntitule
            // 
            this.labelTypeCoursIntitule.AutoSize = true;
            this.labelTypeCoursIntitule.Location = new System.Drawing.Point(15, 69);
            this.labelTypeCoursIntitule.Name = "labelTypeCoursIntitule";
            this.labelTypeCoursIntitule.Size = new System.Drawing.Size(38, 13);
            this.labelTypeCoursIntitule.TabIndex = 5;
            this.labelTypeCoursIntitule.Text = "Intitulé";
            // 
            // tbTypeCoursIntitule
            // 
            this.tbTypeCoursIntitule.Location = new System.Drawing.Point(59, 65);
            this.tbTypeCoursIntitule.Name = "tbTypeCoursIntitule";
            this.tbTypeCoursIntitule.Size = new System.Drawing.Size(149, 20);
            this.tbTypeCoursIntitule.TabIndex = 6;
            // 
            // gbAjouterCategorie
            // 
            this.gbAjouterCategorie.Controls.Add(this.bCategorieSave);
            this.gbAjouterCategorie.Controls.Add(this.nudCategorieNbEQTD);
            this.gbAjouterCategorie.Controls.Add(this.labelCategorieNbHeures);
            this.gbAjouterCategorie.Controls.Add(this.tbCategorieIntitule);
            this.gbAjouterCategorie.Controls.Add(this.labelAjouterCatIntitule);
            this.gbAjouterCategorie.Location = new System.Drawing.Point(7, 12);
            this.gbAjouterCategorie.Name = "gbAjouterCategorie";
            this.gbAjouterCategorie.Size = new System.Drawing.Size(776, 69);
            this.gbAjouterCategorie.TabIndex = 0;
            this.gbAjouterCategorie.TabStop = false;
            this.gbAjouterCategorie.Text = "Nouvelle catégorie d\'enseignant";
            // 
            // bCategorieSave
            // 
            this.bCategorieSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bCategorieSave.Location = new System.Drawing.Point(676, 25);
            this.bCategorieSave.Name = "bCategorieSave";
            this.bCategorieSave.Size = new System.Drawing.Size(75, 23);
            this.bCategorieSave.TabIndex = 4;
            this.bCategorieSave.Text = "Ajouter";
            this.bCategorieSave.UseVisualStyleBackColor = true;
            this.bCategorieSave.Click += new System.EventHandler(this.bCategorieSave_Click);
            // 
            // nudCategorieNbEQTD
            // 
            this.nudCategorieNbEQTD.Location = new System.Drawing.Point(600, 26);
            this.nudCategorieNbEQTD.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudCategorieNbEQTD.Name = "nudCategorieNbEQTD";
            this.nudCategorieNbEQTD.Size = new System.Drawing.Size(70, 20);
            this.nudCategorieNbEQTD.TabIndex = 3;
            // 
            // labelCategorieNbHeures
            // 
            this.labelCategorieNbHeures.AutoSize = true;
            this.labelCategorieNbHeures.Location = new System.Drawing.Point(420, 30);
            this.labelCategorieNbHeures.Name = "labelCategorieNbHeures";
            this.labelCategorieNbHeures.Size = new System.Drawing.Size(174, 13);
            this.labelCategorieNbHeures.TabIndex = 2;
            this.labelCategorieNbHeures.Text = "Nombre d\'heures de TD à effectuer";
            // 
            // tbCategorieIntitule
            // 
            this.tbCategorieIntitule.Location = new System.Drawing.Point(59, 26);
            this.tbCategorieIntitule.Name = "tbCategorieIntitule";
            this.tbCategorieIntitule.Size = new System.Drawing.Size(355, 20);
            this.tbCategorieIntitule.TabIndex = 1;
            // 
            // labelAjouterCatIntitule
            // 
            this.labelAjouterCatIntitule.AutoSize = true;
            this.labelAjouterCatIntitule.Location = new System.Drawing.Point(15, 30);
            this.labelAjouterCatIntitule.Name = "labelAjouterCatIntitule";
            this.labelAjouterCatIntitule.Size = new System.Drawing.Size(38, 13);
            this.labelAjouterCatIntitule.TabIndex = 0;
            this.labelAjouterCatIntitule.Text = "Intitulé";
            // 
            // toolTipHome
            // 
            this.toolTipHome.AutomaticDelay = 100;
            this.toolTipHome.AutoPopDelay = 3000;
            this.toolTipHome.InitialDelay = 50;
            this.toolTipHome.ReshowDelay = 20;
            // 
            // personnel_dashboardTableAdapter
            // 
            this.personnel_dashboardTableAdapter.ClearBeforeFill = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(801, 462);
            this.Controls.Add(this.tcMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Gestionnaire de composante";
            this.Load += new System.EventHandler(this.Home_Load);
            this.tcMenu.ResumeLayout(false);
            this.tbComposante.ResumeLayout(false);
            this.gbDepartement.ResumeLayout(false);
            this.gbDepartement.PerformLayout();
            this.gbComposante.ResumeLayout(false);
            this.gbComposante.PerformLayout();
            this.tpPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneldashboardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufrDataSet)).EndInit();
            this.gbAjouterEns.ResumeLayout(false);
            this.gbAjouterEns.PerformLayout();
            this.gbModifierEns.ResumeLayout(false);
            this.gbModifierEns.PerformLayout();
            this.tpDiplomes.ResumeLayout(false);
            this.gbDiplome.ResumeLayout(false);
            this.gbDiplome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiplomeAnnees)).EndInit();
            this.gbAnnee.ResumeLayout(false);
            this.gbAnnee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnneeOrdre)).EndInit();
            this.gbUE.ResumeLayout(false);
            this.gbUE.PerformLayout();
            this.gbEC.ResumeLayout(false);
            this.gbEC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudECHeures)).EndInit();
            this.gbCours.ResumeLayout(false);
            this.gbCours.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoursGroupes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoursHeures)).EndInit();
            this.gbEnseignants.ResumeLayout(false);
            this.gbEnseignants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnsHeures1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnsHeures2)).EndInit();
            this.tpFormules.ResumeLayout(false);
            this.gbCategorieSupprimer.ResumeLayout(false);
            this.gbTypeCoursSupprimer.ResumeLayout(false);
            this.gbFormules.ResumeLayout(false);
            this.gbFormules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFormulesEQTD)).EndInit();
            this.gbTypeCours.ResumeLayout(false);
            this.gbTypeCours.PerformLayout();
            this.gbAjouterCategorie.ResumeLayout(false);
            this.gbAjouterCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCategorieNbEQTD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMenu;
        private System.Windows.Forms.TabPage tpPersonnel;
        private System.Windows.Forms.TabPage tpDiplomes;
        private System.Windows.Forms.NumericUpDown nudDiplomeAnnees;
        private System.Windows.Forms.Label labelDiplomeNbAnnees;
        private System.Windows.Forms.NumericUpDown nudAnneeOrdre;
        private System.Windows.Forms.Label labelAnneeOrdre;
        private System.Windows.Forms.Button bAnneeSave;
        private System.Windows.Forms.TextBox tbAnneeIntitule;
        private System.Windows.Forms.Label labelAnneeIntitule;
        private System.Windows.Forms.ComboBox cbAnnee;
        private System.Windows.Forms.Button bDiplomeSave;
        private System.Windows.Forms.TextBox tbDiplomeIntitule;
        private System.Windows.Forms.Label labelDiplomeIntitule;
        private System.Windows.Forms.ComboBox cbDiplome;
        private System.Windows.Forms.Button bUEAjouter;
        private System.Windows.Forms.Button bUESave;
        private System.Windows.Forms.TextBox tbUENomComplet;
        private System.Windows.Forms.Label labelUENomComplet;
        private System.Windows.Forms.ComboBox cbUE;
        private System.Windows.Forms.Button bAnneeAjouter;
        private System.Windows.Forms.Button bDiplomeNouveau;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.TextBox tbUERef;
        private System.Windows.Forms.Label labelUERef;
        private System.Windows.Forms.NumericUpDown nudECHeures;
        private System.Windows.Forms.Label labelECHeures;
        private System.Windows.Forms.TextBox tbECRef;
        private System.Windows.Forms.Label labelECRef;
        private System.Windows.Forms.Button bECAjouter;
        private System.Windows.Forms.Button bECSave;
        private System.Windows.Forms.TextBox tbECNomComplet;
        private System.Windows.Forms.Label labelECNomComplet;
        private System.Windows.Forms.ComboBox cbEC;
        private System.Windows.Forms.Button bEnsAffecter;
        private System.Windows.Forms.NumericUpDown nudEnsHeures2;
        private System.Windows.Forms.Label labelEnsHeures2;
        private System.Windows.Forms.ComboBox cbEns2;
        private System.Windows.Forms.NumericUpDown nudEnsHeures1;
        private System.Windows.Forms.Label labelEnsHeures1;
        private System.Windows.Forms.ComboBox cbEns1;
        private System.Windows.Forms.ComboBox cbCoursType;
        private System.Windows.Forms.NumericUpDown nudCoursGroupes;
        private System.Windows.Forms.Label labelCoursGroupes;
        private System.Windows.Forms.Label labelCoursIntitule;
        private System.Windows.Forms.NumericUpDown nudCoursHeures;
        private System.Windows.Forms.Label labelCoursHeures;
        private System.Windows.Forms.Button bCoursAjouter;
        private System.Windows.Forms.Button bEnseignantSave;
        private System.Windows.Forms.TextBox tbCoursIntitule;
        private System.Windows.Forms.Label labelCoursType;
        private System.Windows.Forms.ComboBox cbCours;
        private System.Windows.Forms.TabPage tpFormules;
        private System.Windows.Forms.GroupBox gbFormules;
        private System.Windows.Forms.Label formulesSignification;
        private System.Windows.Forms.Label labelFormulesSignification;
        private System.Windows.Forms.NumericUpDown nudFormulesEQTD;
        private System.Windows.Forms.Label labelFormulesEQTD;
        private System.Windows.Forms.ComboBox cbFormulesTypesCours;
        private System.Windows.Forms.Label labelFormulesTypeCours;
        private System.Windows.Forms.ComboBox cbFormulesCategories;
        private System.Windows.Forms.Label labelFormulesCat;
        private System.Windows.Forms.GroupBox gbTypeCours;
        private System.Windows.Forms.Label labelListeTypesCours;
        private System.Windows.Forms.Label labelTypeCoursRappel;
        private System.Windows.Forms.Button bTypeCoursSave;
        private System.Windows.Forms.Label labelTypeCoursIntitule;
        private System.Windows.Forms.TextBox tbTypeCoursIntitule;
        private System.Windows.Forms.GroupBox gbAjouterCategorie;
        private System.Windows.Forms.Button bCategorieSave;
        private System.Windows.Forms.NumericUpDown nudCategorieNbEQTD;
        private System.Windows.Forms.Label labelCategorieNbHeures;
        private System.Windows.Forms.TextBox tbCategorieIntitule;
        private System.Windows.Forms.Label labelAjouterCatIntitule;
        private System.Windows.Forms.Button bEQTDSave;
        private System.Windows.Forms.GroupBox gbTypeCoursSupprimer;
        private System.Windows.Forms.Button bTypeCoursSupprimer;
        private System.Windows.Forms.ComboBox cbTypeCoursSupprimer;
        private System.Windows.Forms.GroupBox gbCategorieSupprimer;
        private System.Windows.Forms.Button bCategorieSupprimer;
        private System.Windows.Forms.ComboBox cbCategorieSupprimer;
        private System.Windows.Forms.GroupBox gbModifierEns;
        private System.Windows.Forms.ComboBox cbPersonnelModifierEns;
        private System.Windows.Forms.Label labelModifierEns;
        private System.Windows.Forms.Button bModifierEnsSave;
        private System.Windows.Forms.ComboBox cbModifierEnsCategorie;
        private System.Windows.Forms.Label labelModifierEnsCategorie;
        private System.Windows.Forms.Button bSupprimerEns;
        private System.Windows.Forms.GroupBox gbEnseignants;
        private System.Windows.Forms.Label labelEnseignantsNonaffectes;
        private System.Windows.Forms.ComboBox cbEnsGroupe1;
        private System.Windows.Forms.ComboBox cbEnsGroupe2;
        private System.Windows.Forms.Label labelEnseignantsAffectes;
        private System.Windows.Forms.Label labelEnsGroupe1;
        private System.Windows.Forms.Label labelEnsGroupe2;
        private System.Windows.Forms.ToolTip toolTipHome;
        private System.Windows.Forms.GroupBox gbEC;
        private System.Windows.Forms.Button bECSupprimer;
        private System.Windows.Forms.GroupBox gbCours;
        private System.Windows.Forms.Button bCoursSuppr;
        private System.Windows.Forms.Button bCoursSave;
        private System.Windows.Forms.GroupBox gbDiplome;
        private System.Windows.Forms.Button bDiplomeSupprimer;
        private System.Windows.Forms.GroupBox gbAnnee;
        private System.Windows.Forms.GroupBox gbUE;
        private System.Windows.Forms.Label labelSemestre;
        private System.Windows.Forms.Button bUESupprimer;
        private System.Windows.Forms.Button bEnseignantRemove;
        private System.Windows.Forms.Button bAnneeSupprimer;
        private System.Windows.Forms.Button bUEAjouterExistant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbUESemestre;
        private System.Windows.Forms.Button bUEDissocier;
        private System.Windows.Forms.Button bAjouterEns;
        private System.Windows.Forms.GroupBox gbAjouterEns;
        private System.Windows.Forms.TextBox tbAjouterEnsPrenom;
        private System.Windows.Forms.Button bSelectEnsExistant;
        private System.Windows.Forms.Label labelAjouterEnsNom;
        private System.Windows.Forms.Label labelAjouterEnsCategorie;
        private System.Windows.Forms.TextBox tbAjouterEnsNom;
        private System.Windows.Forms.ComboBox cbAjouterEnsCategorie;
        private System.Windows.Forms.Label labelAjouterEnsPrenom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ufrDataSet ufrDataSet;
        private System.Windows.Forms.BindingSource personneldashboardBindingSource;
        private ufrDataSetTableAdapters.personnel_dashboardTableAdapter personnel_dashboardTableAdapter;
        private System.Windows.Forms.Button bDissocierEnseignant;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prénomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catégorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pourcentageDuServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuresEQTDEffectuéesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heuresEQTDÀEffectuerDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabPage tbComposante;
        private System.Windows.Forms.GroupBox gbDepartement;
        private System.Windows.Forms.Button bDepartementDelete;
        private System.Windows.Forms.Button bDepartementSave;
        private System.Windows.Forms.ComboBox cbDepartement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDepartementNom;
        private System.Windows.Forms.Button bDepartementAjouter;
        private System.Windows.Forms.GroupBox gbComposante;
        private System.Windows.Forms.Button bComposanteDelete;
        private System.Windows.Forms.Button bComposanteSave;
        private System.Windows.Forms.ComboBox cbComposante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbComposanteNom;
        private System.Windows.Forms.Button bComposanteAjouter;
    }
}

