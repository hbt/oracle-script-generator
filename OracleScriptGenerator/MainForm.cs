/*
 * 
 * Date: 2006/05/22
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using OracleScriptGenerator.GUI;
using OracleScriptGenerator;
using System.Runtime.InteropServices;
using OracleScriptGenerator.GUI.Tables;
using System.Collections;
using OracleScriptGenerator.Tables;



namespace OracleScriptGenerator.GUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm
	{
		#region Main
		[STAThread]
		public static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		#endregion
		
		#region Attributs
		private Generator gen;
		private CreateTableWizard1 tableWizard1;
		private ArrayList arrayTables;
		private SyntaxHighlighter syntax; 
		#endregion
		public MainForm()
		{
			InitializeComponent();
			
			//AllocConsole();
			gen = new Generator();
			arrayTables = gen.tables;
			
//			
//			
//			gen.ChargerFichierDefault();
//			gen.ConstruireIndex();
//			ArrayList temp = gen.tables;
//			for (int i = 0 ; i  < temp.Count; i++) {
//				Table t = (Table) temp[i];
//				Console.Out.WriteLine(t.propNom);
//			}
			
			//AfficherListeElements();
			
//			txtCode.Text = "public static void asdas CONSTRAINT (int i, int j\n fucker hello world integer describe";
//			txtCode.Text = "CREATE TABLE asd(
//	no	INTEGER	DEFAULT 666,
//	nom	VARCHAR2(55)	CONSTRAINT employee_nom_nn	NOT NULL,
//	prenom	VARCHAR2(55),
//
//);0"
			syntax = new SyntaxHighlighter(txtCode);
			syntax.formater();
		}
		
		#region chargement
		public void AfficherListeElements () {
			
		}
		#endregion
		
		#region API calls
		[DllImport("kernel32.dll")]
		public static extern Boolean AllocConsole();
		[DllImport("kernel32.dll")]
		public static extern Boolean FreeConsole();
		#endregion
		
		void CréerToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			tableWizard1 = new CreateTableWizard1();
			tableWizard1.propTables = arrayTables;
			tableWizard1.propListe = this.liste;
			tableWizard1.Show();
			refreshListe();
		}
		
		private void refreshListe () {
			liste.Items.Clear();
			for (int i = 0 ; i < arrayTables.Count; i++) {
				Table temp = (Table) arrayTables[i];
				liste.Items.Add(temp.propNom);
			}
		}
		
		void ListeClick(object sender, System.EventArgs e)
		{
			try {
				Table temp = new Table(liste.SelectedItem.ToString());
				arrayTables.Sort(new TableComparer());
				refreshListe();
				
				int posi = arrayTables.BinarySearch(temp, new TableComparer());
				
				if (posi != -1) {
				
					temp = (Table) arrayTables[posi];
					txtCode.Text = temp.ToString();
//					syntax = new SyntaxHighlighter(txtCode);
//					this.syntax.formater ();
				}
			} catch (Exception) {
			}
			
			
		}
		
	
		
		void AfficherToolStripMenuItem4Click(object sender, System.EventArgs e)
		{
			OpenFileDialog filedialog = new OpenFileDialog();
			filedialog.ShowDialog();
			
			if (!filedialog.FileName.Equals("")) {
				gen.ChargerFichier(filedialog.FileName);
				gen.ConstruireIndex();
			
				refreshListe();
			}
			
			
			
//			for (int i = 0; i < arrayTables.Count; i++) {
//				liste.Items.Add(arrayTables[i]);
//			}
			
			//liste.Items.Add(arrayTables);
			
//			for (int i = 0 ; i < arrTempTables.Count; i++) {
//				arrayTables.Add(arrTempTables[i]);
//			}
			
//			for (int i = 0; i < gen.tables.Count; i++) {
//				Table tempTable = (Table) gen.tables[i];
//				liste.Items.Add(tempTable);
//			}
			
		}
		
		
	}
}
