/*
 * 
 * Date: ${DATE}
 * @author: Hassen Ben Tanfous
 */
namespace OracleScriptGenerator.GUI.Tables
{
	partial class CreateTableWizard3 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.comboType = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.boutonAjouter = new System.Windows.Forms.Button();
			this.boutonPrev = new System.Windows.Forms.Button();
			this.boutonTerminer = new System.Windows.Forms.Button();
			this.boutonAnnuler = new System.Windows.Forms.Button();
			this.table = new System.Windows.Forms.DataGridView();
			this.colonneNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colonneType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtNomContrainte = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.SuspendLayout();
			// 
			// comboType
			// 
			this.comboType.FormattingEnabled = true;
			this.comboType.Location = new System.Drawing.Point(81, 67);
			this.comboType.Name = "comboType";
			this.comboType.Size = new System.Drawing.Size(121, 21);
			this.comboType.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(81, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(238, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sélectionner le type de contrainte";
			// 
			// boutonAjouter
			// 
			this.boutonAjouter.Location = new System.Drawing.Point(352, 65);
			this.boutonAjouter.Name = "boutonAjouter";
			this.boutonAjouter.Size = new System.Drawing.Size(75, 23);
			this.boutonAjouter.TabIndex = 2;
			this.boutonAjouter.Text = "Ajouter";
			this.boutonAjouter.UseVisualStyleBackColor = true;
			this.boutonAjouter.Click += new System.EventHandler(this.BoutonAjouterClick);
			// 
			// boutonPrev
			// 
			this.boutonPrev.Location = new System.Drawing.Point(244, 314);
			this.boutonPrev.Name = "boutonPrev";
			this.boutonPrev.Size = new System.Drawing.Size(75, 23);
			this.boutonPrev.TabIndex = 3;
			this.boutonPrev.Text = "Précédent";
			this.boutonPrev.UseVisualStyleBackColor = true;
			this.boutonPrev.Click += new System.EventHandler(this.BoutonPrevClick);
			// 
			// boutonTerminer
			// 
			this.boutonTerminer.Location = new System.Drawing.Point(337, 314);
			this.boutonTerminer.Name = "boutonTerminer";
			this.boutonTerminer.Size = new System.Drawing.Size(75, 23);
			this.boutonTerminer.TabIndex = 4;
			this.boutonTerminer.Text = "Terminer";
			this.boutonTerminer.UseVisualStyleBackColor = true;
			this.boutonTerminer.Click += new System.EventHandler(this.BoutonTerminerClick);
			// 
			// boutonAnnuler
			// 
			this.boutonAnnuler.Location = new System.Drawing.Point(453, 314);
			this.boutonAnnuler.Name = "boutonAnnuler";
			this.boutonAnnuler.Size = new System.Drawing.Size(75, 23);
			this.boutonAnnuler.TabIndex = 6;
			this.boutonAnnuler.Text = "Annuler";
			this.boutonAnnuler.UseVisualStyleBackColor = true;
			this.boutonAnnuler.Click += new System.EventHandler(this.BoutonAnnulerClick);
			// 
			// table
			// 
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.colonneNom,
									this.colonneType});
			this.table.Location = new System.Drawing.Point(142, 127);
			this.table.Name = "table";
			this.table.Size = new System.Drawing.Size(245, 170);
			this.table.TabIndex = 7;
			// 
			// colonneNom
			// 
			this.colonneNom.HeaderText = "Nom";
			this.colonneNom.Name = "colonneNom";
			this.colonneNom.ReadOnly = true;
			// 
			// colonneType
			// 
			this.colonneType.HeaderText = "type";
			this.colonneType.Name = "colonneType";
			this.colonneType.ReadOnly = true;
			// 
			// txtNomContrainte
			// 
			this.txtNomContrainte.Location = new System.Drawing.Point(231, 67);
			this.txtNomContrainte.Name = "txtNomContrainte";
			this.txtNomContrainte.Size = new System.Drawing.Size(100, 21);
			this.txtNomContrainte.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(81, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "Type de contraintes";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(231, 38);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Nom de contrainte";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(142, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Liste des contraintes";
			// 
			// CreateTableWizard3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(536, 357);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNomContrainte);
			this.Controls.Add(this.table);
			this.Controls.Add(this.boutonAnnuler);
			this.Controls.Add(this.boutonTerminer);
			this.Controls.Add(this.boutonPrev);
			this.Controls.Add(this.boutonAjouter);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboType);
			this.Name = "CreateTableWizard3";
			this.Text = "Création de la table -- Contraintes";
			this.Load += new System.EventHandler(this.CreateTableWizard3Load);
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNomContrainte;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboType;
		private System.Windows.Forms.Button boutonAjouter;
		private System.Windows.Forms.Button boutonPrev;
		private System.Windows.Forms.Button boutonTerminer;
		private System.Windows.Forms.Button boutonAnnuler;
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.DataGridViewTextBoxColumn colonneType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colonneNom;
		private System.Windows.Forms.Label label1;
	}
}
