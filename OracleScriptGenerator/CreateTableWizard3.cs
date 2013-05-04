/*
 * 
 * Date: 2006/05/23
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using OracleScriptGenerator.Tables.Contraintes;
using OracleScriptGenerator.Tables;

namespace OracleScriptGenerator.GUI.Tables
{
	/// <summary>
	/// Description of CreateTableWizard3.
	/// </summary>
	public partial class CreateTableWizard3
	{
		#region Attributs
		private CreateTableWizard2 tableWizard2;
		private ArrayList arrayTables;
		private ArrayList arrayAttributs; //attribut de la table en création
		
		private ContraintePrimaryKey contraintePK;
		private ContrainteForeignKey contrainteFK;
		private ContrainteCheck contrainteCK;
		private ContrainteUnique contrainteUQ;

		private ArrayList arrayFK,
		arrayCK,
		arrayUQ;
		private PrimaryKey pk;
		private Table entite; //table en création
		private System.Windows.Forms.ListBox liste;
		#endregion
		
		public CreateTableWizard3()
		{
			InitializeComponent();
			
		}
		
		public void initialiser () {
			arrayFK = new ArrayList();
			arrayCK = new ArrayList();
			arrayUQ = new ArrayList();
			pk = new PrimaryKey("");
			
			entite = new Table (tableWizard2.propTableWizard1.nomTable.ToString());
			entite.attributs = arrayAttributs;
			entite.PK = pk;
			entite.FK = arrayFK;
			entite.CK = arrayCK;
			entite.UQ = arrayUQ;
		}
		
		#region evenements
		void BoutonPrevClick(object sender, System.EventArgs e)
		{
			this.Visible = false;
			tableWizard2.Visible = true;
		}
		
		void BoutonTerminerClick(object sender, System.EventArgs e)
		{
			//parcourir la table et reconstruire les array pour les clés supprimées
			string nom, //nom de la constraint
			type; //type de constraint
			
			ArrayList temparrayFK = new ArrayList();
			ArrayList temparrayCK = new ArrayList();
			ArrayList temparrayUQ = new ArrayList();
			
			for (int i = 0; i < table.Rows.Count-1; i++) {
				nom = table.Rows[i].Cells[0].FormattedValue.ToString();
				type = table.Rows[i].Cells[1].FormattedValue.ToString();
				if (type.Equals(Contrainte.FK)) {
					for (int k = 0; k < arrayFK.Count; k++) {
						ForeignKey fktemp = (ForeignKey) arrayFK[k];
						if (fktemp.nom.Equals(nom)) {
							temparrayFK.Add(fktemp);
						}
					}
				} else if (type.Equals(Contrainte.UQ)) {
					for (int k = 0 ; k < arrayUQ.Count; k++) {
						Unique uqtemp = (Unique) arrayUQ[k];
						if (uqtemp.nom.Equals(nom)) {
							temparrayUQ.Add(uqtemp);
						}
					}
				} else if (type.Equals(Contrainte.CK)) {
					for (int k = 0; k < arrayCK.Count; k++) {
						Check cktemp = (Check) arrayCK[k];
						if (cktemp.nom.Equals(nom)) {
							temparrayCK.Add(cktemp);
						}
					}
				}
			}
			
			//assignation
			entite.FK = temparrayFK;
			entite.CK = temparrayCK;
			entite.UQ = temparrayUQ;
			
			arrayTables.Add(entite);	
			
			refreshListe();
			
			this.Dispose();
		}
		
		void BoutonAnnulerClick(object sender, System.EventArgs e)
		{
			tableWizard2.propTableWizard1.Dispose();
			tableWizard2.Dispose();
			this.Dispose();
		}
		
		void BoutonAjouterClick(object sender, System.EventArgs e)
		{
			if (!txtNomContrainte.Text.ToString().Equals("")) {
				//vérifier taille de la contrainte
				if (txtNomContrainte.Text.ToString().Length > Contrainte.TAILLE_MAX) {
					txtNomContrainte.Text = txtNomContrainte.Text.ToString().Substring(0, Contrainte.TAILLE_MAX);
				}
				//vérifier contrainte similaire
				if (VerifierExistence (txtNomContrainte.Text)) {
					MessageBox.Show("Nom de contrainte existant", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				//primary key
				if (comboType.SelectedItem.ToString().Equals(Contrainte.PK)) {
					pk.nom = txtNomContrainte.Text.ToString();
					contraintePK = new ContraintePrimaryKey(entite);
					contraintePK.propTable = this.table;
					contraintePK.Show();
				} else if (comboType.SelectedItem.ToString().Equals(Contrainte.FK)) {
					contrainteFK = new ContrainteForeignKey(entite, arrayTables, txtNomContrainte.Text.ToString());
					contrainteFK.propTable = this.table;
					contrainteFK.Show();
				} else if (comboType.SelectedItem.ToString().Equals(Contrainte.CK)) {
					contrainteCK = new ContrainteCheck(entite, txtNomContrainte.Text.ToString());
					contrainteCK.propTable = this.table;
					contrainteCK.Show();
				} else if (comboType.SelectedItem.ToString().Equals(Contrainte.UQ)) {
					contrainteUQ = new ContrainteUnique(entite, txtNomContrainte.Text.ToString());
					contrainteUQ.propTable = this.table;
					contrainteUQ.Show();
				}
			} else {
				MessageBox.Show("Nom de contrainte invalide", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		
		void CreateTableWizard3Load(object sender, System.EventArgs e)
		{
			this.comboType.Items.AddRange(new string[] { Contrainte.PK, Contrainte.FK, Contrainte.CK, Contrainte.UQ});
			this.comboType.SelectedItem = Contrainte.PK;
		}
		#endregion
		
		#region proprietes
		public ArrayList propTables {
			get { return arrayTables; }
			set { arrayTables = value; }
		}
		
		public CreateTableWizard2 propTableWizard2 {
			get { return tableWizard2; }
			set { this.tableWizard2 = value; }
		}
		
		public ArrayList propAttributs {
			get { return arrayAttributs; }
			set { arrayAttributs = value; }
		}
		
		public DataGridView propDataGridView {
			get { return table; }
			set { table = value; }
		}
		
		public System.Windows.Forms.ListBox propListe 
		{
			get { return liste; }
			set { liste = value; }
		}
		#endregion
		
		private bool VerifierExistence (string constraint) {
			try {
				Hashtable hash = new Hashtable();
				for (int i = 0; i < table.Rows.Count; i++) {
					hash.Add(table.Rows[i].Cells[0].FormattedValue.ToString(), table.Rows[i].Cells[0].FormattedValue.ToString().GetHashCode());
				}
				return hash.ContainsKey(constraint);
			} catch (Exception ) {
				MessageBox.Show("Un nom de contrainte semblable existe déjà", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return false;
		}
		
		private void refreshListe () {
			liste.Items.Clear();
			for (int i = 0 ; i < arrayTables.Count; i++) {
				Table temp = (Table) arrayTables[i];
				liste.Items.Add(temp.propNom);
			}
		}
	}
}
