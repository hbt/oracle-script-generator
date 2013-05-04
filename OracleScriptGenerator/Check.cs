/*
 * 
 * Date: 2006/06/03
 * @author: Hassen Ben Tanfous
 */

using System;
using OracleScriptGenerator.Tables.Contraintes;

namespace OracleScriptGenerator
{
	public class Check : Contrainte
	{
		
		#region Attributs
		private string code;
		private string checkValue;
		#endregion
		
		public Check(string nomContrainte) : base (nomContrainte)
		{
			code = "";
		}
		
		#region proprietes
		public string propCode {
			get { return code; }
			set { code = value; }
		}
		
		public string propCheckValue {
			get { return checkValue; }
			set { checkValue = value; }
		}
		
		#endregion
	}
}
