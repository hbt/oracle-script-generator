/*
 * 
 * Date: 2006/05/22
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Collections;
using System.IO;
using OracleScriptGenerator.Tables;
using OracleScriptGenerator.Tables.Contraintes;

using c = System.Console;

namespace OracleScriptGenerator
{
	/// <summary>
	/// Description of Generator.
	/// </summary>
	public class Generator
	{
		#region constantes
		public  const string CREATE_TABLE_KEYWORD = "create table ";
		public const string CONSTRAINT_KEYWORD = "constraint ";
		#endregion
		
		#region Attributs
		private ArrayList listeTables;
		private string contenuFichier;
		private string pathDefault = "D:\\labo.sql";
		private Table tempTable = null;
		#endregion
		
		#region Constructeurs
		public Generator()
		{
			listeTables = new ArrayList();
			contenuFichier = "";
			
			//à retirer
			//ChargerFichier(pathDefault);
			//ConstruireIndex();
		}
		#endregion
		
		#region Méthodes r/w
		public void ChargerFichier (string path) {
			try {
				
				StreamReader lecteur = new StreamReader (path);
				
				contenuFichier = lecteur.ReadToEnd();
				lecteur.Close();
			} catch (Exception ex) {
				Console.Out.WriteLine(ex.StackTrace);
			}
		}
		
		public void ChargerFichierDefault () {
			ChargerFichier (pathDefault);
		}
		#endregion
		
		#region indexage des tables, séquences etc.
		public void ConstruireIndex () {
			string contenu = contenuFichier;
			contenu = contenu.ToLower();
			
			int posi = contenu.IndexOf(CREATE_TABLE_KEYWORD);
			posi += CREATE_TABLE_KEYWORD.Length;
			int posi2 = contenu.IndexOf('(', posi);
			string nomTable;
			
			
			while (posi != -1) {
				nomTable = 	contenu.Substring(posi, posi2-posi);
				nomTable = nomTable.Trim();
				nomTable = nomTable.Trim('\n');
				nomTable = nomTable.ToUpper();
				
				//indexation des attributs de la table
				int posi3 = contenu.IndexOf(");", posi2);
				string contenuTable = contenu.Substring(posi2+1, posi3-posi2);
				
//				Console.Out.WriteLine("attributs");
//				Console.Out.WriteLine(contenu.Substring(posi2, posi3-posi2));

				//ajout des table à la arraylist
				 tempTable = new Table(nomTable);
				 tempTable.CompleteCode = false;
				 tempTable.AutoCode = contenuTable;
				 etablirAttributs(contenuTable);
				listeTables.Add(tempTable);
				
				posi = contenu.IndexOf(CREATE_TABLE_KEYWORD, posi);
				if (posi == -1) {
					break;
				}
				posi += CREATE_TABLE_KEYWORD.Length;
				posi2 = contenu.IndexOf("(", posi);
			}
		}
		
		private void etablirAttributs (string attr) {
//			Console.Out.WriteLine(attr);
		
			ArrayList tempAttr = new ArrayList();
			
			string str = "\n"; //symbole de fin de ligne pour chaque attribut
			int posi1 = 0; 
			int posi2 = attr.IndexOf(str);
			
			int j = 1; //inutile
			//permet de parcourir la string attr pour parser en liste d'attributs
			while (posi2 != -1) {
				string ligne = attr.Substring(posi1, posi2-posi1);
				ligne = ligne.Trim();
				ligne = ligne.Trim('\t');
				ligne = ligne.Substring(0, ligne.Length); //suppression de la virgule
				
				tempAttr.Add(ligne);
				
//				Console.Out.WriteLine("ligne " + j + ". " + ligne);
				
				posi1 = posi2+1;
				posi2 = attr.IndexOf(str, posi2+1);				
				j++;//inutile
			}
			
			//permet de parcourir la liste des attributs afin d'ajouter les attributs à la table
			for (int i  = 0; i < tempAttr.Count; i++) {
				string ligne = (string) tempAttr[i];
				if (ligne.StartsWith("constraint")) {
					//construire contrainte
					ConstruireContrainte(ligne);
				} else {
					ConstruireAttribut (ligne);
				}
			}
		}
		
		private void ConstruireAttribut (string ligne) {
			Attribut attr = null;
			
//			Console.Out.WriteLine(ligne);
			ligne = ligne.Replace(' ', '\t');
			ligne = ligne.Trim('\t');
			
			int posi = ligne.IndexOf('\t');
			
			//nom
			string nom = ligne.Substring(0, posi);
			
			ligne = ligne.Substring(posi);
			ligne = ligne.Trim('\t');
			
			//type
			string type = "";
			string taille = "";
			
			posi = ligne.IndexOf('(');
			if (posi == -1) {
				//pas de valeur pour le type
				posi = ligne.IndexOf('\t');
				
				if (posi == -1) {
					type = ligne;
				} else {
					type = ligne.Substring(0, posi);
				}
				
				
			} else {
				type = ligne.Substring(0, posi);
				
				
				ligne = ligne.Substring(posi);
				ligne = ligne.Trim('\t');
				
				//taille du type 
				posi = ligne.IndexOf(')');
				taille = ligne.Substring(1, posi-1);
			}
			
			attr = new Attribut(nom, type);
			attr.propTaille = taille;
			
			tempTable.attributs.Add(attr);
			
			
//			//s'il reste encore des trucs à lire sur la ligne
//			string nomnn = ""; //nom contrainte not null
//			string defval = ""; //valeur par défault
//			if (posi != -1) {
//				ligne = ligne.Substring(posi);
//				ligne = ligne.Trim('\t');
//				
//				
//				
//				//vérifier nom contrainte not null
//				posi = ligne.IndexOf("constraint");
//				if (posi == -1) {
//					//verifier not null
//					posi = ligne.IndexOf("null");
//					if (posi != -1) {
//						attr.notNull = true;
//					}
//				} else {
//					int posi2 = ligne.IndexOf("not");
//					nomnn = ligne.Substring(posi + "constraint".Length, posi2);
//					nomnn = nomnn.Trim('\t');
//				}
//			}
			
			
//			Console.Out.WriteLine("Nom: " + nom);
//			Console.Out.WriteLine("Type: " + type);
//			Console.Out.WriteLine("Taille: " + taille);
//			Console.Out.WriteLine("Nomnn: " + nomnn);
			
		}
		
		private void ConstruireContrainte (string ligne)  {
			//check for primary key
			int posi =  ligne.IndexOf("primary");
			if (posi != -1) {
				PrimaryKey pk = new PrimaryKey("whateverXxX"); //penser a parser le nom de la contrainte
				
				ligne = ligne.Substring(posi);
				posi = ligne.IndexOf('(');
				ligne = ligne.Substring(posi);
				int posi2 = ligne.IndexOf(')');
//				Console.Out.WriteLine(posi2);
				ligne = ligne.Substring(1, posi2-1);
//				Console.Out.WriteLine(ligne);	
				
				//parser les attributs entre parenthèses
				posi = ligne.IndexOf(',');
				if (posi == -1) {
					ligne = ligne.Trim();
					ligne = ligne.Trim('\t');
					
					Attribut attr = new Attribut(ligne);
					ArrayList arr = new ArrayList();
					arr.Add(attr);
					pk.attributs = arr;
					tempTable.PK = pk;

				} else {
					ArrayList arr = new ArrayList();
					while (posi != -1) {
						string nomattr = ligne.Substring(0, posi);
						nomattr = nomattr.Trim();
						nomattr = nomattr.Trim('\t');
						nomattr = nomattr.Trim(',');
						
						
						Attribut attr = new Attribut(nomattr);
						arr.Add(attr);
						
						ligne = ligne.Substring(++posi);
						posi = ligne.IndexOf(',');
						
						Console.Out.WriteLine(posi);
						ligne = ligne.Trim();
						ligne = ligne.Trim('\t');
						ligne = ligne.Trim(',');
						Console.Out.WriteLine(ligne);
					}
					Attribut attr2 = new Attribut (ligne);
					arr.Add(attr2);
					
					for (int i= 0 ; i < arr.Count; i++) {
						Attribut temp  = (Attribut) arr[i];
						Console.Out.WriteLine("name: " + temp.propNom + " das");
					}
					
					pk.attributs = arr;
					tempTable.PK = pk;
					
				}
			}
			
			
			
			
		}
		
		
		#endregion
		
		
		
		#region Propriétés
		public ArrayList tables {
			get  { return listeTables; }
			set { listeTables = value; }
		}
		
		public string contenuSQL {
			get { return contenuFichier; }
		}
		#endregion
	}
}
