namespace projet_dot_net
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gbSelectionUE = new System.Windows.Forms.GroupBox();
            this.bUESelection = new System.Windows.Forms.Button();
            this.cbUESelection = new System.Windows.Forms.ComboBox();
            this.gbSelectionUE.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelectionUE
            // 
            this.gbSelectionUE.Controls.Add(this.bUESelection);
            this.gbSelectionUE.Controls.Add(this.cbUESelection);
            this.gbSelectionUE.Location = new System.Drawing.Point(10, 11);
            this.gbSelectionUE.Name = "gbSelectionUE";
            this.gbSelectionUE.Size = new System.Drawing.Size(425, 96);
            this.gbSelectionUE.TabIndex = 0;
            this.gbSelectionUE.TabStop = false;
            this.gbSelectionUE.Text = "Unité d\'Enseignement (UE)";
            // 
            // bUESelection
            // 
            this.bUESelection.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bUESelection.Location = new System.Drawing.Point(329, 59);
            this.bUESelection.Name = "bUESelection";
            this.bUESelection.Size = new System.Drawing.Size(75, 23);
            this.bUESelection.TabIndex = 1;
            this.bUESelection.Text = "Sélectionner";
            this.bUESelection.UseVisualStyleBackColor = true;
            this.bUESelection.Click += new System.EventHandler(this.bUESelection_Click);
            // 
            // cbUESelection
            // 
            this.cbUESelection.DisplayMember = "id";
            this.cbUESelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUESelection.FormattingEnabled = true;
            this.cbUESelection.Location = new System.Drawing.Point(20, 32);
            this.cbUESelection.Name = "cbUESelection";
            this.cbUESelection.Size = new System.Drawing.Size(384, 21);
            this.cbUESelection.TabIndex = 0;
            this.cbUESelection.ValueMember = "id";
            // 
            // Form2
            // 
            this.AcceptButton = this.bUESelection;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 114);
            this.Controls.Add(this.gbSelectionUE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sélectionner une UE";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.gbSelectionUE.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectionUE;
        private System.Windows.Forms.Button bUESelection;
        private System.Windows.Forms.ComboBox cbUESelection;
    }
}