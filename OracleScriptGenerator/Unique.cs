/*
 * 
 * Date: 2006/06/03
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Collections;
using OracleScriptGenerator.Tables.Contraintes;

namespace OracleScriptGenerator.Tables.Contraintes
{
	
	public class Unique : Contrainte
	{
		
		#region Attributs
		private ArrayList attributs;
		private string code;
		
		#endregion
		public Unique(string nomContrainte) : base (nomContrainte)
		{
			attributs = new ArrayList();
			code = "";
		}
		
		#region proprietes
		public ArrayList propAttributs {
			get { return attributs; }
			set { attributs = value; }
		}
		
		public string propCode {
			get { return code; }
			set { code = value; }
		}
		#endregion
	}
}
