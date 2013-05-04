/*
 * 
 * Date: 2006/05/25
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Drawing;
using System.Windows.Forms;
using OracleScriptGenerator.Tables.Contraintes;
using OracleScriptGenerator.Tables;
using System.Collections;

namespace OracleScriptGenerator.GUI.Tables
{
	/// <summary>
	/// Description of ContrainteForeignKey.
	/// </summary>
	public partial class ContrainteForeignKey
	{
		
		
		//-contrainteforeignkey
		//attributs
		//-arrayAttributs
		//-arrayTables
		//-arrayAttributsRef
		//-arrayForeignKey
		//-ForeignKey (current)
		// 
		//ContrainteForeignKey (ArrayList arrayTables, Table entite);

		private Table entite;
		private ArrayList arrayTables,
		arrayAttributs,
		arrayAttributsRef,
		arrayForeignKey;
		private ForeignKey foreignKey; //current foreign key
		private string nom;
		private DataGridView table;
		
		public ContrainteForeignKey()
		{
			InitializeComponent();
		}
		
		public ContrainteForeignKey (Table entite, ArrayList arrayTables, string nomContrainte) : this () {
			this.arrayTables = arrayTables;
			this.entite = entite;
			this.nom = nomContrainte;
			this.arrayForeignKey = entite.FK;
			
			arrayAttributs = new ArrayList();
			arrayAttributsRef = new ArrayList();
		}
		
		#region proprietes
		
		
		public DataGridView propTable {
			get { return this.table; }
			set { table = value; }
		}
		#endregion
		
		
		void ContrainteForeignKeyLoad(object sender, System.EventArgs e)
		{
			for (int i = 0; i < entite.attributs.Count; i++) {
				Attribut att = (Attribut) entite.attributs[i];
				listeAttributs.Items.Add(att.propNom.ToString());
			}
			
			for (int i = 0; i < arrayTables.Count; i++) {
				Table t = (Table) arrayTables[i];
				listeTables.Items.Add(t.propNom.ToString());
			}
			
			//ajout de la table courante
			listeTables.Items.Add(entite.propNom.ToString());
		}
		
		void ListeTablesSelectedIndexChanged(object sender, System.EventArgs e)
		{
			listeAttributsRef.Items.Clear();
			int i = listeTables.SelectedIndex;
			if (i == -1) {
				i = 0;
			}
			Table t; //table temporaire
			Attribut att; //attribut temporaire
			
			if (listeTables.Items[i].ToString().Equals(entite.propNom.ToString())) {
				t = entite;
			} else {
				t = new Table(listeTables.Items[i].ToString());
				//if (arrayTables.BinarySearch(temp, new TableComparer()) != -1)
				int j = arrayTables.BinarySearch(t, new TableComparer());
				if (j != -1) {
					t = (Table) arrayTables[j];
				} else {
					MessageBox.Show("Erreur d'affichage", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
			if (checkAllAttributs.Checked) {
				for (int k = 0; k < t.attributs.Count; k++) {
					att = (Attribut)t.attributs[k];
					listeAttributsRef.Items.Add(att.propNom.ToString());
				}
			} else {
				if (t.PK.attributs.Count != 0) {
					for (int k = 0;  k< t.PK.attributs.Count; k++) {
						listeAttributsRef.Items.Add(t.PK.attributs[k].ToString());
					}
				}
			}
			
			RafraichirAffichage();
		}
		
		void CheckAllAttributsCheckedChanged(object sender, System.EventArgs e)
		{
			ListeTablesSelectedIndexChanged(sender, e);
		}
		
		void ListeAttributsSelectedIndexChanged(object sender, System.EventArgs e)
		{
			RafraichirAffichage();
		}
		
		void ListeAttributsRefSelectedIndexChanged(object sender, System.EventArgs e)
		{
			RafraichirAffichage();
		}
		
		private void RafraichirAffichage () {
			arrayAttributsRef.Clear();
			arrayAttributs.Clear();
			
			string contenu = "CONSTRAINT " + this.nom + " " + Contrainte.FK + " (";
			
			if (listeAttributs.SelectedItem == null) {
				contenu += "attributs) ";
			} else {
				for (int i = 0; i < listeAttributs.SelectedItems.Count; i++) {
					contenu += listeAttributs.SelectedItems[i].ToString() + ", ";
					arrayAttributs.Add(listeAttributs.SelectedItems[i].ToString());
				}
				contenu = contenu.Substring(0, contenu.Length-2);
			}
			contenu += ") REFERENCES ";
			if (listeTables.SelectedItem == null) {
				contenu += "nomTable";
			} else {
				contenu += listeTables.SelectedItem.ToString() + " (";
			}
			
			if (listeAttributsRef == null) {
				contenu += "attributs); ";
			} else {
				for (int i = 0; i < listeAttributsRef.SelectedItems.Count; i++) {
					contenu += listeAttributsRef.SelectedItems[i].ToString() + ", ";
					arrayAttributsRef.Add(listeAttributsRef.SelectedItems[i].ToString());
				}
				
				contenu = contenu.Substring(0, contenu.Length-2);
				contenu += ")";
			}
			
			txtCode.Text = contenu;
		}
		
		
		void BoutonAjouterClick(object sender, System.EventArgs e)
		{
			if (listeTables.SelectedItem == null || listeAttributs.SelectedItem == null || listeAttributsRef.SelectedItem == null) {
				MessageBox.Show("Erreur lors de la création de la Foreign Key, Code Invalide", "OracleScriptGenerator", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} else {
				foreignKey = new ForeignKey(nom);
				foreignKey.attributs = arrayAttributs;
				foreignKey.attributsRef = this.arrayAttributsRef;
				foreignKey.propCode = txtCode.Text.ToString();
				foreignKey.propNomTable = listeTables.SelectedItem.ToString();
				
				arrayForeignKey.Add(foreignKey);
				table.Rows.Add(this.nom, Contrainte.FK);
				
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
