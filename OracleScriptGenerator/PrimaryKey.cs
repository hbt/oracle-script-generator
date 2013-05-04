/*
 * 
 * Date: 2006/05/26
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Collections;

namespace OracleScriptGenerator.Tables.Contraintes
{
	/// <summary>
	/// Description of PrimaryKey.
	/// </summary>
	public class PrimaryKey : Contrainte
	{
		#region Attributs
		private ArrayList arrayNomAttributs;
		private string code;
		
		#endregion
		public PrimaryKey(string nomContrainte) : base (nomContrainte)
		{
			arrayNomAttributs = new ArrayList();
			code = "";
		}
		
		public ArrayList attributs {
			get { return arrayNomAttributs; }
			set { arrayNomAttributs = value; }
		}
		
		public string propCode {
			get { return code; }
			set { code = value; }
		}
	}
}

