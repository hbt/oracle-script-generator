/*
 * 
 * Date: 2006/05/26
 * @author: Hassen Ben Tanfous
 */

using System;

namespace OracleScriptGenerator.Tables.Contraintes
{
	/// <summary>
	/// Description of Contrainte.
	/// </summary>
	public class Contrainte
	{
		#region Constantes
		public const string PK = "PRIMARY KEY";
		public const string FK = "FOREIGN KEY";
		public const string CK = "CHECK";
		public const string NN = "NOT NULL";
		public const string UQ = "UNIQUE";
		public const int TAILLE_MAX = 30;
		#endregion
		
		#region Attributs
		private string nomContrainte;
		#endregion
		
		public Contrainte(string nomContrainte)
		{
			this.nomContrainte = nomContrainte;
		}
		
		#region Propriétés
		public string nom {
			get { return nomContrainte; }
			set { nomContrainte = value; }
		}
		#endregion
	}
}
