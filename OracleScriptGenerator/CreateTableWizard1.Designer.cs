/*
 * 
 * Date: ${DATE}
 * @author: Hassen Ben Tanfous
 */
namespace OracleScriptGenerator.GUI.Tables
{
	partial class CreateTableWizard1 : System.Windows.Forms.Form
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
			this.boutonSuivant = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.boutonAnnuler = new System.Windows.Forms.Button();
			this.txtNomTable = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// boutonSuivant
			// 
			this.boutonSuivant.Location = new System.Drawing.Point(329, 305);
			this.boutonSuivant.Name = "boutonSuivant";
			this.boutonSuivant.Size = new System.Drawing.Size(75, 23);
			this.boutonSuivant.TabIndex = 0;
			this.boutonSuivant.Text = "Suivant";
			this.boutonSuivant.UseVisualStyleBackColor = true;
			this.boutonSuivant.Click += new System.EventHandler(this.Button1Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 77);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(133, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nom de la table: ";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Blue;
			this.label2.Location = new System.Drawing.Point(31, 136);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(213, 110);
			this.label2.TabIndex = 2;
			this.label2.Text = "Informations:\n Pour créer une table vous devez: \n 1) Entrer le nom de la table \n " +
			"2) Entrer les attributs \n 3) Entrer les contraintes";
			// 
			// boutonAnnuler
			// 
			this.boutonAnnuler.Location = new System.Drawing.Point(480, 305);
			this.boutonAnnuler.Name = "boutonAnnuler";
			this.boutonAnnuler.Size = new System.Drawing.Size(75, 23);
			this.boutonAnnuler.TabIndex = 3;
			this.boutonAnnuler.Text = "Annuler";
			this.boutonAnnuler.UseVisualStyleBackColor = true;
			this.boutonAnnuler.Click += new System.EventHandler(this.BoutonAnnulerClick);
			// 
			// txtNomTable
			// 
			this.txtNomTable.Location = new System.Drawing.Point(187, 74);
			this.txtNomTable.Name = "txtNomTable";
			this.txtNomTable.Size = new System.Drawing.Size(260, 21);
			this.txtNomTable.TabIndex = 4;
			// 
			// CreateTableWizard1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 357);
			this.Controls.Add(this.txtNomTable);
			this.Controls.Add(this.boutonAnnuler);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.boutonSuivant);
			this.Name = "CreateTableWizard1";
			this.Text = "Création de la table -- nom de la table";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button boutonSuivant;
		private System.Windows.Forms.Button boutonAnnuler;
		private System.Windows.Forms.TextBox txtNomTable;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
