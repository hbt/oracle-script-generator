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
	/// Description of ContraintePrimaryKey.
	/// </summary>
	public partial class ContraintePrimaryKey
	{
		private ArrayList arrayAttributs;
		private PrimaryKey pk;
		private string nomTable;
		private DataGridView table;
		private Table entite;
		
		public ContraintePrimaryKey()
		{
			InitializeComponent();
		}
		
		public ContraintePrimaryKey (Table entite) : this() {
			arrayAttributs = entite.attributs;
			pk = entite.PK;
			nomTable = entite.propNom;
			this.entite = entite;
		}
		
		#region evenements
		void BoutonAnnulerClick(object sender, System.EventArgs e)
		{
			this.Dispose();
		}
		
		void ContraintePrimaryKeyLoad(object sender, System.EventArgs e)
		{
			for (int i = 0; i < arrayAttributs.Count; i++) {
				Attribut att = (Attribut) arrayAttributs[i];
				liste.Items.Add(att.propNom);
			}
		}
		
		
		void ListeClick(object sender, System.EventArgs e)
		{
			string code = "CONSTRAINT " + pk.nom + " " + Contrainte.PK + "(";
			for (int i = 0 ; i < liste.SelectedItems.Count; i++) {
				code += liste.SelectedItems[i].ToString() + ", ";
			}
			
			if (liste.SelectedItems.Count != 0) {
				code = code.Substring(0, code.Length-2);
			}
			code += ")";
			txtCode.Text = code;
		}
		
		void BoutonAjouterClick(object sender, System.EventArgs e)
		{
			pk.attributs.Clear();
			if (liste.SelectedItem == null) {
				MessageBox.Show("Erreur lors de la création de la Primary Key, Code invalide", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				for (int i =0 ; i < liste.SelectedItems.Count; i++) {
					pk.attributs.Add(liste.SelectedItems[i].ToString());
				}
				
				pk.propCode = txtCode.Text.ToString();
				table.Rows.Add(new string[] {pk.nom, Contrainte.PK});
				
				this.Visible = false;
				this.Dispose();
			}
			
		}
		
		#endregion
		
		
		#region proprietes
		public DataGridView propTable {
			get { return this.table; }
			set { table = value; }
		}
		#endregion
		
		
	}
}
