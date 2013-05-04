/*
 * 
 * Date: 2006/05/26
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
	/// Description of ContrainteCheck.
	/// </summary>
	public partial class ContrainteCheck
	{
		private ArrayList arrayCK;
		private ArrayList arrayAttributs;
		private Check check; //current check constraint
		private DataGridView table;
		
		public ContrainteCheck()
		{
			InitializeComponent();
		}
		
		public ContrainteCheck (Table entite, string nomContrainte) : this () {
			arrayCK = entite.CK;
			arrayAttributs = entite.attributs;
			check = new Check (nomContrainte);
		}
		
		void BoutonAnnulerClick(object sender, System.EventArgs e)
		{
			this.Dispose();
		}
		
		void BoutonAjouterClick(object sender, System.EventArgs e)
		{
			if (txtCheck.Text.Equals("")) {
				MessageBox.Show("Erreur lors de la création de la contrainte CHECK, Code invalide", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				check.propCheckValue = txtCheck.Text;
				check.propCode = txtCode.Text;
				arrayCK.Add(check);
				
				table.Rows.Add(check.nom, Contrainte.CK);
				this.Dispose();
			}
		}
		
		#region proprietes
		public DataGridView propTable {
			get { return table; }
			set { table = value; }
		}
		#endregion
		
		void TxtCheckTextChanged(object sender, System.EventArgs e)
		{
			RafraichirCode ();
		}
		
		private void RafraichirCode () {
			string code = "CONSTRAINT " + check.nom + " " + Contrainte.CK + " (";
			
			if (txtCheck.Text.Equals("")) {
				code += "boolean check value);";
			} else {
				code += txtCheck.Text.ToString() + ")";
			}
			
			txtCode.Text = code;
		}
		
		void ListeSelectedIndexChanged(object sender, System.EventArgs e)
		{
			RafraichirCode ();
		}
		
		void ContrainteCheckLoad(object sender, System.EventArgs e)
		{
			for (int i = 0; i < arrayAttributs.Count; i++) {
				Attribut att = (Attribut) arrayAttributs[i];
				liste.Items.Add(att.propNom);
			}
		}
	}
}
