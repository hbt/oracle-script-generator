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
	/// Description of ForeignKey.
	/// </summary>
	public class ForeignKey : Contrainte
	{
		#region Attributs
		private ArrayList arrayNomAttributs;
		private string nomTable;
		private ArrayList arrayAttributsRef;
		private string code;
		#endregion
		
		public ForeignKey(string nomContrainte) : base (nomContrainte)
		{
			arrayNomAttributs = new ArrayList();
			arrayAttributsRef = new ArrayList();
			code = "";
		}
		
		public ArrayList attributsRef {
			get { return arrayAttributsRef; }
			set { arrayAttributsRef = value; }
		}
		
		public string propNomTable {
			get { return nomTable; }
			set { nomTable = value; }
		}
		
		public string propCode {
			get { return code; }
			set { code = value; }
		}
		
		public ArrayList attributs {
			get { return arrayNomAttributs; }
			set { arrayNomAttributs = value; }
		}
	}
}
