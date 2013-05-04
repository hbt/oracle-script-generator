/*
 * 
 * Date: 2006/05/26
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Collections;
using OracleScriptGenerator.Tables;

namespace OracleScriptGenerator.Tables
{
	/// <summart2>
	/// Description of TableComparer.
	/// </summart2>
	public class TableComparer : IComparer
	{
		public  const int TABLE_Et1IST = 0;
		public  const int TABLE_NOT_Et1IST = -1;
		public TableComparer()
		{
		}
		
		public int Compare(object x, object y)
		{
//			Table t1 = (Table) t1;
//			Table t2 = (Table) t2;
//
			////			if (t1.propNom.Equals(t2.propNom)) {
			////				return TABLE_Et1IST;
			////			} else {
			////				return TABLE_NOT_Et1IST;
			////			}
//
//			"".CompareTo(
//			return (t1.propNom.CompareTo(t2.propNom));
			string t1 = ((Table)x).propNom;
			string t2 = ((Table)y).propNom;
//			Table t1 = (Table) x;
//			Table t2 = (Table) y;
//			Console.WriteLine(t1.propNom);
//			Console.WriteLine(t2.propNom);
			
			if (t1 == null)
			{
				if (t2 == null)
				{
					// If t1 is null and t2 is null, thet2're
					// equal.
					return 0;
				}
				else
				{
					// If t1 is null and t2 is not null, t2
					// is greater.
					return -1;
				}
			}
			else
			{
//				 If t1 is not null...
				
				if (t2 == null)
					// ...and t2 is null, t1 is greater.
				{
					return 1;
				}
				else
				{
//					 ...and t2 is not null, compare the
//					 lengths of the two strings.
					
					int retval = t1.Length.CompareTo(t2.Length);
					
//					if (t1.propNom.Equals(t2.propNom)) {
//						return 0;
//					} else {
//						return 1;
//					}

					if (retval != 0)
					{
						// If the strings are not of equal length,
						// the longer string is greater.
						//
						return retval;
					}
					else
					{
						// If the strings are of equal length,
						// sort them with ordinart2 string comparison.
						//
						return t1.CompareTo(t2);
					}
				}
			}
//			return 0;
		}
		
		
	}
}
