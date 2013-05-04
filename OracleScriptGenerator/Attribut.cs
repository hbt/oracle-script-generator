/*
 * 
 * Date: 2006/05/26
 * @author: Hassen Ben Tanfous
 */

using System;
using OracleScriptGenerator.Tables.Contraintes;

namespace OracleScriptGenerator.Tables
{
	/// <summary>
	/// Description of Attribut.
	/// </summary>
	public class Attribut
	{
		#region constantes
		public const string VARCHAR2 = "VARCHAR2";
		public const string NVARCHAR2 = "NVARCHAR2";
		public const string CHAR = "CHAR";
		public const string NCHAR = "NCHAR";
		public const string NUMBER = "NUMBER";
		public const string INTEGER = "INTEGER";
		public const string PLS_INTEGER = "PLS_INTEGER";
		public const string BINARY_INTEGER = "BINARY_INTEGER";
		public const string DATE = "DATE";
		public const string TIMESTAMP = "TIMESTAMP";
		public const string RAW = "RAW";
		public const string ROWID = "ROWID";
		public const string UROWID = "UROWID";
		public const string MLSLABEL = "MLSLABEL";
		public const string CLOB = "CLOB";
		public const string NCLOB = "NCLOB";

		public const string BLOB = "BLOB";
		public const string BFILE = "BFILE";
		public const string XMLTYPE = "XMLTYPE";
		
		#endregion
		#region Attributs
		private string nom,
		type,
		defaultValue;
		private string taille;
		
		private bool nnEnabled; //true if enabled
		private string nomConstraintNN;
		private bool autoNNEnabled; //true if enabled
		private string nomTable;
		#endregion
		
		public Attribut(string nom, string type)
		{
			this.nom = nom;
			this.type = type;
			nnEnabled = false;
			autoNotNull = false;
			
		}
		
		public Attribut (string nom) {
			this.nom = nom;
			nnEnabled = false;
			autoNotNull = false;
		}
		
		public Attribut (string nom, string type, string taille) : this (nom, type) {
			this.taille = taille;
		}
		
		public string propNom {
			get { return nom; }
			set { nom = value; }
		}
		
		public string propType {
			get { return type; }
			set { type = value; }
		}
		
		public string propTaille {
			get { return taille; }
			set { taille = value; }
		}
		
		public bool notNull {
			get { return nnEnabled; }
			set { nnEnabled = value; }
		}
		
		public string nomNotNull {
			get { return nomConstraintNN; }
			set { nomConstraintNN = value; }
		}
		
		public bool autoNotNull {
			get { return autoNNEnabled; }
			set { autoNNEnabled  = value; }
		}
		
		public string propDefaultValue {
			get { return defaultValue; }
			set { defaultValue  = value; }
		}
		
		public string propTable {
			get { return nomTable; }
			set { nomTable = value; }
		}
		
		
		public override string ToString () {
			string contenu = "";
			
			contenu += nom + "\t" + type;
			if (taille != null) {
				contenu += "(" + taille + ")";
			}
			if (defaultValue != null) {
				contenu += "\tDEFAULT " + defaultValue;
			}
			
			if (nomConstraintNN != null) {
				contenu += "\tCONSTRAINT " + nomConstraintNN + "\tNOT NULL";
				return contenu;
			}
			
			if (nnEnabled) {
				contenu += "\t" + "NOT NULL";
				return contenu;
			}
			
			if (autoNotNull) {
				string constraint = nomTable + "_" + nom + "_nn";
				if (constraint.Length > 30) {
					constraint = constraint.Substring(0, Contrainte.TAILLE_MAX);
				}
				contenu += "\tCONSTRAINT " + constraint + "\tNOT NULL";
				return contenu;
			}
			
			return contenu;
		}
		
		
	}
}
