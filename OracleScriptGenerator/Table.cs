/*
 * 
 * Date: 2006/05/26
 * @author: Hassen Ben Tanfous
 */

using System;
using OracleScriptGenerator.Tables.Contraintes;
using OracleScriptGenerator.Tables;
using System.Collections;

namespace OracleScriptGenerator.Tables
{
	/// <summary>
	/// Description of Table.
	/// </summary>
	public class Table
	{
		private PrimaryKey pk;
		private ArrayList arrayFK;
		private ArrayList arrayNN;
		private ArrayList arrayCK;
		private ArrayList arrayUQ;
		
		private string nom; //nom de la table
		private ArrayList arrayAttributs;
		
		private bool boolCompleteCode = true;
		private string autoCode;
		
		public Table(string nomTable)
		{
			this.nom = nomTable;
			arrayAttributs = new ArrayList();
			
		}
		
		#region propriétés
		public PrimaryKey PK {
			get { return pk; }
			set { pk = value; }
		}
		
		public ArrayList FK {
			get { return arrayFK; }
			set { arrayFK = value; }
		}
		
		public ArrayList NN {
			get { return arrayNN; }
			set { arrayNN = value; }
		}
		
		public ArrayList CK {
			get { return arrayCK; }
			set { arrayCK = value; }
		}
		
		public ArrayList UQ {
			get { return arrayUQ; }
			set { arrayUQ = value; }
		}
		
		public ArrayList attributs {
			get { return arrayAttributs; }
			set { arrayAttributs = value; }
		}
		
		public string propNom {
			get { return nom; }
			set { nom = value; }
		}
		
		public bool CompleteCode {
			get { return boolCompleteCode; }
			set { boolCompleteCode = value; }
		}
		
		public string AutoCode {
			get { return autoCode; }
			set { autoCode = value; }
		}
		#endregion
		
		public override string ToString() {
			if (boolCompleteCode) {
			string contenu = "\nCREATE TABLE " + this.nom + "\n(";
			for (int i = 0; i < arrayAttributs.Count; i++) {
				contenu += "\n\t";
				Attribut att = (Attribut) arrayAttributs[i];
				contenu += att.ToString();
				contenu += ", ";
			}
			
			if (!pk.propCode.Equals("")) {
				contenu += "\n\t";
				
				contenu += pk.propCode;
				contenu += ", ";
			}
			
			
			for (int i =0 ;i < arrayFK.Count; i++) {
				contenu += "\n\t";
				ForeignKey fktemp = (ForeignKey) arrayFK[i];
				contenu += fktemp.propCode;
				contenu += ", ";
			}
			
			for (int i = 0; i < arrayCK.Count; i++) {
				contenu += "\n\t";
				Check cktemp = (Check) arrayCK[i];
				contenu += cktemp.propCode;
				contenu += ", ";
			}
			
			for (int i =0 ;i < arrayUQ.Count; i++) {
				contenu += "\n\t";
				Unique uqtemp = (Unique) arrayUQ[i];
				contenu += uqtemp.propCode;
				contenu += ", ";
			}
			
			contenu = contenu.Substring(0, contenu.Length-2);
			contenu += "\n);";
			return contenu;
//
//			if (pk.nom == null && arrayFK.Count == 0 && arrayCK.Count == 0 && arrayUQ.Count == 0) {
//				for (int i = 0; i < arrayAttributs.Count; i++) {
//					contenu += "\n\t";
//					Attribut att = (Attribut) arrayAttributs[i];
//					contenu += att.ToString();
//					contenu += ",";
//				}
//				contenu += "\n);";
//				return contenu;
//			} else {
//				for (int i = 0; i < arrayAttributs.Count; i++) {
//					contenu += "\n\t";
//					Attribut att = (Attribut) arrayAttributs[i];
//					contenu += att.ToString();
//					contenu += ",";
//				}
//
//				if (pk.nom != null) {
//					contenu += code
//				}
//
//				contenu += "\n);";
//				return contenu;
//			}
			
//			return "listing okay";
			} else {
				string contenu = "\nCREATE TABLE " + this.nom + "\n(";
				contenu += autoCode;
				return contenu + ";";
			}
		}
			
	}		
}
