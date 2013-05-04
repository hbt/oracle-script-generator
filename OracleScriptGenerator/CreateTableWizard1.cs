/*
 * 
 * Date: 2006/05/23
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using OracleScriptGenerator.Tables;

namespace OracleScriptGenerator.GUI.Tables
{
	/// <summary>
	/// Description of CreateTableWizard1.
	/// </summary>
	public partial class CreateTableWizard1
	{
		#region Attributs
		private CreateTableWizard2 tableWizard2;
		private ArrayList arrayTables;
		private System.Windows.Forms.ListBox liste;
		#endregion
		
		public CreateTableWizard1()
		{
			InitializeComponent();
		}
		
		
		#region evenements
		void Button1Click(object sender, System.EventArgs e)
		{
			Table temp = new Table(txtNomTable.Text);
			
//			for (int n = 0; n < arrayTables.Count; n++) {
//				Table ttemp = (Table) arrayTables[n];
//				if (ttemp.propNom.ToLower().Equals(temp.propNom.ToLower())) {
//					MessageBox.Show("Erreur, une table existe déjà sous le même nom", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
//					return;
//				}
//			}
			arrayTables.Sort(new TableComparer());
			refreshListe();
			if (arrayTables.BinarySearch(temp, new TableComparer()) < 0) {
				if (tableWizard2 == null) {
					tableWizard2 = new CreateTableWizard2();
					tableWizard2.propTableWizard1 = this;
					tableWizard2.propTables = arrayTables;
					tableWizard2.propListe = liste;
				}
				this.Visible = false;
				tableWizard2.Visible = true;
			} else {
				MessageBox.Show("Erreur, une table existe déjà sous le même nom", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
//				if (tableWizard2 == null) {
//					tableWizard2 = new CreateTableWizard2();
//					tableWizard2.propTableWizard1 = this;
//					tableWizard2.propTables = arrayTables;
//					tableWizard2.propListe = liste;
//				}
//				this.Visible = false;
//				tableWizard2.Visible = true;
			}
		}
		
		void BoutonAnnulerClick(object sender, System.EventArgs e)
		{
			
			if (tableWizard2 != null) {
				if (tableWizard2.propTableWizard3 != null) {
					tableWizard2.propTableWizard3.Dispose();
				}
				tableWizard2.Dispose();
			}
			this.Dispose();
		}
		#endregion
		
		#region proprietes
		public ArrayList propTables {
			get { return arrayTables; }
			set { arrayTables = value; }
		}
		
		public  string nomTable {
			get { return txtNomTable.Text.ToString(); }
		}
		
		public System.Windows.Forms.ListBox propListe 
		{
			get { return liste; }
			set { liste = value; }
		}
		#endregion
		
		private void refreshListe () {
			liste.Items.Clear();
			for (int i = 0 ; i < arrayTables.Count; i++) {
				Table temp = (Table) arrayTables[i];
				liste.Items.Add(temp.propNom);
			}
		}
	}
}
