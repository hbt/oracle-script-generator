/*
 * 
 * Date: 2006/05/25
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using OracleScriptGenerator.Tables;
using OracleScriptGenerator.Tables.Contraintes;

namespace OracleScriptGenerator.GUI.Tables
{
	/// <summary>
	/// Description of ContrainteUnique.
	/// </summary>
	public partial class ContrainteUnique
	{
		#region Attributs
		private ArrayList arrayAttributs;
		private string nom;
		private DataGridView table;
		private Unique unique; //current unique constraint
		private Table entite; 
		#endregion
		
		public ContrainteUnique()
		{
			InitializeComponent();
		}
		
		public ContrainteUnique (Table entite, string nomContrainte) : this () {
			this.entite = entite;
			arrayAttributs = entite.attributs;
			this.nom = nomContrainte;
			unique = new Unique(nom);
		}
		
		#region proprietes
		public DataGridView propTable {
			get { return this.table; }
			set { this.table = value; }
		}
		#endregion
		
		void ListeSelectedIndexChanged(object sender, System.EventArgs e)
		{
			string code = "CONSTRAINT " + nom + " " + Contrainte.UQ + "(";
			for (int i = 0 ; i < liste.SelectedItems.Count; i++) {
				code += liste.SelectedItems[i].ToString() + ", ";
			}
			
			if (liste.SelectedItems.Count != 0) {
				code = code.Substring(0, code.Length-2);
			}
			code += ")";
			txtCode.Text = code;
		}
		
		void ContrainteUniqueLoad(object sender, System.EventArgs e)
		{
			for (int i = 0; i < arrayAttributs.Count; i++) {
				Attribut att = (Attribut) arrayAttributs[i];
				liste.Items.Add(att.propNom);
			}
		}
		
		void BoutonAjouterClick(object sender, System.EventArgs e)
		{
			if (liste.SelectedItem == null) {
				MessageBox.Show("Erreur lors de la création de la contrainte Unique, Code invalide", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				for (int i =0 ; i < liste.SelectedItems.Count; i++) {
					unique.propAttributs.Add(liste.SelectedItems[i].ToString());
				}
				
				unique.propCode = txtCode.Text.ToString();
				entite.UQ.Add(unique);
				table.Rows.Add(new string[] {unique.nom, Contrainte.UQ});
				
				this.Visible = false;
				this.Dispose();
			}
		}
		
		void BoutonAnnulerClick(object sender, System.EventArgs e)
		{
			this.Dispose();
		}
	}
}
