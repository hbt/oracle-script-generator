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
using OracleScriptGenerator.Tables.Contraintes;

namespace OracleScriptGenerator.GUI.Tables
{
	/// <summary>
	/// Description of CreateTableWizard2.
	/// </summary>
	public partial class CreateTableWizard2
	{
		#region Attributs
		private CreateTableWizard1 tableWizard1;
		private CreateTableWizard3 tableWizard3;
		private ArrayList arrayTables;
		private ArrayList arrayAttributs;
		private System.Windows.Forms.ListBox liste;
		#endregion
		
		public CreateTableWizard2()
		{
			InitializeComponent();
		}
		
		
		#region evenements
		void BoutonPrevClick(object sender, System.EventArgs e)
		{
			this.Visible = false;
			tableWizard1.Visible = true;
		}
		
		void BoutonSuivantClick(object sender, System.EventArgs e)
		{			
			arrayAttributs = new ArrayList();
			for (int i = 0 ; i < table.Rows.Count-1; i++) {
				Attribut att = new Attribut(table.Rows[i].Cells[0].FormattedValue.ToString(), table.Rows[i].Cells[1].FormattedValue.ToString());
				att.propTable = tableWizard1.nomTable;
				if (!table.Rows[i].Cells[2].FormattedValue.ToString().Equals("")) {
					att.propTaille = table.Rows[i].Cells[2].FormattedValue.ToString();
				}
				if (!table.Rows[i].Cells[3].FormattedValue.ToString().Equals ("")){
					att.propDefaultValue = table.Rows[i].Cells[3].FormattedValue.ToString();
				}
				if (!table.Rows[i].Cells[4].FormattedValue.ToString().Equals(Boolean.FalseString)) {
					att.notNull = true;
				}
				if (!table.Rows[i].Cells[5].FormattedValue.ToString().Equals(""))  {
					att.nomNotNull = table.Rows[i].Cells[5].FormattedValue.ToString();
				}
				if (!table.Rows[i].Cells[6].FormattedValue.ToString().Equals(Boolean.FalseString)) {
					att.autoNotNull = true;
				}
				arrayAttributs.Add(att);
				Console.WriteLine(att.ToString());
			}
			if (tableWizard3 == null) {
				tableWizard3 = new CreateTableWizard3();
				tableWizard3.propTableWizard2 = this;
				tableWizard3.propTables = arrayTables;
				tableWizard3.propAttributs = arrayAttributs;
				tableWizard3.propListe = liste;
				tableWizard3.initialiser();
			} 
			
			this.Visible = false;
			tableWizard3.Visible = true;
		}
		
		void BoutonAnnulerClick(object sender, System.EventArgs e)
		{
			if (tableWizard3 != null) {
				tableWizard3.Dispose();
			}
			tableWizard1.Dispose();
			this.Dispose();
		}
		#endregion
		
		#region Propriétés
		public CreateTableWizard1 propTableWizard1 {
			get { return tableWizard1 ; }
			set { this.tableWizard1 = value; }
		}
		
		public CreateTableWizard3 propTableWizard3 {
			get { return tableWizard3 ; }
			set { this.tableWizard3 = value; }
		}
		
		public System.Windows.Forms.ListBox propListe 
		{
			get { return liste; }
			set { liste = value; }
		}
		
		
		public ArrayList propTables {
			get { return arrayTables; }
			set { arrayTables = value; }
		}
		
		#endregion
		
		
		
		//important à décommenter
		void TableRowsAdded(object sender, System.Windows.Forms.DataGridViewRowsAddedEventArgs e)
		{
			table.CurrentRow.Cells[1].Value = Attribut.INTEGER;
		}
		
		void TableRowEnter(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			try {
				//vérifier s'il n'existe pas des attributs semblables
				Hashtable hashAttributs = new Hashtable();
				for (int i = 0; i < table.Rows.Count; i++) {
					
					//vérifier la taille des contraintes
					if (table.Rows[i].Cells[5].FormattedValue.ToString().Length > Contrainte.TAILLE_MAX) {
						string constraint = table.Rows[i].Cells[5].FormattedValue.ToString();
						constraint = constraint.Substring(0, Contrainte.TAILLE_MAX);
						table.Rows[i].Cells[5].Value = constraint;
					}
					try {
						hashAttributs.Add(table.Rows[i].Cells[0].FormattedValue.ToString(), table.Rows[i].Cells[0].FormattedValue.ToString().GetHashCode());
					} catch (Exception) {
//						MessageBox.Show("L'attribut " + table.Rows[i].Cells[0].FormattedValue + " est répété", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				
				
				
//				Hashtable hashContraintes = new Hashtable();
//				for (int i = 0; i < table.Rows.Count; i++) {
//					try {
//						if (table.Rows[i].Cells[5].FormattedValue != null) {
//							hashContraintes.Add(table.Rows[i].Cells[5].FormattedValue.ToString(), table.Rows[i].Cells[5].FormattedValue.ToString().GetHashCode());
//						}
//					} catch (Exception) {
//						MessageBox.Show("La contrainte " + table.Rows[i].Cells[5].FormattedValue + " est répétée", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
//					}
//				}
			} catch (Exception ) {
			}
		}
	}
}
