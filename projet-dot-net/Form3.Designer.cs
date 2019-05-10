namespace projet_dot_net
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gbSelectEns = new System.Windows.Forms.GroupBox();
            this.bSelectEns = new System.Windows.Forms.Button();
            this.cbSelectEns = new System.Windows.Forms.ComboBox();
            this.gbSelectEns.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSelectEns
            // 
            this.gbSelectEns.Controls.Add(this.bSelectEns);
            this.gbSelectEns.Controls.Add(this.cbSelectEns);
            this.gbSelectEns.Location = new System.Drawing.Point(16, 15);
            this.gbSelectEns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSelectEns.Name = "gbSelectEns";
            this.gbSelectEns.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSelectEns.Size = new System.Drawing.Size(612, 85);
            this.gbSelectEns.TabIndex = 12;
            this.gbSelectEns.TabStop = false;
            this.gbSelectEns.Text = "Sélectionner un enseignant existant";
            // 
            // bSelectEns
            // 
            this.bSelectEns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bSelectEns.Location = new System.Drawing.Point(472, 36);
            this.bSelectEns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSelectEns.Name = "bSelectEns";
            this.bSelectEns.Size = new System.Drawing.Size(121, 28);
            this.bSelectEns.TabIndex = 10;
            this.bSelectEns.Text = "Sélectionner";
            this.bSelectEns.UseVisualStyleBackColor = true;
            this.bSelectEns.Click += new System.EventHandler(this.bSelectEns_Click);
            // 
            // cbSelectEns
            // 
            this.cbSelectEns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSelectEns.FormattingEnabled = true;
            this.cbSelectEns.Location = new System.Drawing.Point(15, 36);
            this.cbSelectEns.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSelectEns.Name = "cbSelectEns";
            this.cbSelectEns.Size = new System.Drawing.Size(448, 24);
            this.cbSelectEns.TabIndex = 9;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 118);
            this.Controls.Add(this.gbSelectEns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form3";
            this.Text = "Ajouter un enseignant";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gbSelectEns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSelectEns;
        private System.Windows.Forms.Button bSelectEns;
        private System.Windows.Forms.ComboBox cbSelectEns;
    }
}