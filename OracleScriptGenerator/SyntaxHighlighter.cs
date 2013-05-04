/*
 * 
 * Date: 2006/06/04
 * @author: Hassen Ben Tanfous
 */

using System;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;

namespace OracleScriptGenerator.GUI
{
	/// <summary>
	/// Description of SyntaxHighlighter.
	/// </summary>
	public class SyntaxHighlighter
	{
		#region attributs
		private RichTextBox txtCode;
		private String[] tabKeywords = {
			"ACCESS", "ELSE", "MODIFY", "START", "ADD", "EXCLUSIVE", "NOAUDIT",
			"SELECT", "ALL", "EXISTS", "NOCOMPRESS", "SESSION", "ALTER", "FILE",
			"NOT", "SET", "AND", "FLOAT", "NOTFOUND", "SHARE", "ANY", "FOR", "NOWAIT",
			"SIZE", "ARRAYLEN", "FROM", "NULL", "SMALLINT", "AS", "GRANT", "NUMBER",
			"SQLBUF", "ASC", "GROUP", "OF", "SUCCESSFUL", "AUDIT", "HAVING",
			"OFFLINE", "SYNONYM", "BETWEEN", "IDENTIFIED", "ON", "SYSDATE", "BY",
			"IMMEDIATE", "ONLINE", "TABLE", "CHAR", "IN", "OPTION", "THEN", "CHECK",
			"INCREMENT", "OR", "TO", "CLUSTER", "INDEX", "ORDER", "TRIGGER", "COLUMN",
			"INITIAL", "PCTFREE", "UID", "COMMENT", "INSERT", "PRIOR", "UNION",
			"COMPRESS", "INTEGER", "PRIVILEGES", "UNIQUE", "CONNECT", "INTERSECT",
			"PUBLIC", "UPDATE", "CREATE", "INTO", "RAW", "USER", "CURRENT", "IS",
			"RENAME", "VALIDATE", "DATE", "LEVEL", "RESOURCE", "VALUES", "DECIMAL",
			"LIKE", "REVOKE", "VARCHAR", "DEFAULT", "LOCK", "ROW", "VARCHAR2",
			"DELETE", "LONG", "ROWID", "VIEW", "DESC", "MAXEXTENTS", "ROWLABEL",
			"WHENEVER"
				, "DISTINCT", "MINUS", "ROWNUM", "WHERE", "DROP", "MODE", "ROWS", "WITH",
			"ADMIN", "CURSOR", "FOUND", "MOUNT", "AFTER", "CYCLE", "FUNCTION", "NEXT",
			"ALLOCATE", "DATABASE", "GO", "NEW", "ANALYZE", "DATAFILE", "GOTO",
			"NOARCHIVELOG", "ARCHIVE", "DBA", "GROUPS", "NOCACHE", "ARCHIVELOG",
			"DEC", "INCLUDING", "NOCYCLE", "AUTHORIZATION", "DECLARE", "INDICATOR",
			"NOMAXVALUE", "AVG", "DISABLE", "INITRANS", "NOMINVALUE", "BACKUP",
			"DISMOUNT", "INSTANCE", "NONE", "BEGIN", "DOUBLE", "INT", "NOORDER",
			"BECOME", "DUMP", "KEY", "NORESETLOGS", "BEFORE", "EACH", "LANGUAGE",
			"NORMAL", "BLOCK", "ENABLE", "LAYER", "NOSORT", "BODY", "END", "LINK",
			"NUMERIC", "CACHE", "ESCAPE", "LISTS", "OFF", "CANCEL", "EVENTS",
			"LOGFILE", "OLD", "CASCADE", "EXCEPT", "MANAGE", "ONLY", "CHANGE",
			"EXCEPTIONS", "MANUAL", "OPEN", "CHARACTER", "EXEC", "MAX", "OPTIMAL",
			"CHECKPOINT", "EXPLAIN", "MAXDATAFILES", "OWN", "CLOSE", "EXECUTE",
			"MAXINSTANCES", "PACKAGE", "COBOL", "EXTENT", "MAXLOGFILES", "PARALLEL",
			"COMMIT", "EXTERNALLY", "MAXLOGHISTORY"
				, "PCTINCREASE", "COMPILE", "FETCH", "MAXLOGMEMBERS", "PCTUSED",
			"CONSTRAINT", "FLUSH", "MAXTRANS", "PLAN", "CONSTRAINTS", "FREELIST",
			"MAXVALUE", "PLI", "CONTENTS", "FREELISTS", "MIN", "PRECISION",
			"CONTINUE", "FORCE", "MINEXTENTS", "PRIMARY", "CONTROLFILE", "FOREIGN",
			"MINVALUE", "PRIVATE", "COUNT", "FORTRAN", "MODULE", "PROCEDURE",
			"PROFILE", "SAVEPOINT", "SQLSTATE", "TRACING", "QUOTA", "SCHEMA",
			"STATEMENT_ID", "TRANSACTION", "READ", "SCN", "STATISTICS", "TRIGGERS",
			"REAL", "SECTION", "STOP", "TRUNCATE", "RECOVER", "SEGMENT", "STORAGE",
			"UNDER", "REFERENCES", "SEQUENCE", "SUM", "UNLIMITED", "REFERENCING",
			"SHARED", "SWITCH", "UNTIL", "RESETLOGS", "SNAPSHOT", "SYSTEM", "USE",
			"RESTRICTED", "SOME", "TABLES", "USING", "REUSE", "SORT", "TABLESPACE",
			"WHEN", "ROLE", "SQL", "TEMPORARY", "WRITE", "ROLES", "SQLCODE", "THREAD",
			"WORK", "ROLLBACK", "SQLERROR", "TIME", "ABORT", "BETWEEN", "CRASH",
			"DIGITS", "ACCEPT", "BINARY_INTEGER", "CREATE", "DISPOSE", "ACCESS",
			"BODY", "CURRENT", "DISTINCT", "ADD", "BOOLEAN",
			"CURRVAL", "DO", "ALL", "BY", "CURSOR", "DROP", "ALTER", "CASE",
			"DATABASE", "ELSE", "AND", "CHAR", "DATA_BASE", "ELSIF", "ANY",
			"CHAR_BASE", "DATE", "END", "ARRAY", "CHECK", "DBA", "ENTRY", "ARRAYLEN",
			"CLOSE", "DEBUGOFF", "EXCEPTION", "AS", "CLUSTER", "DEBUGON",
			"EXCEPTION_INIT", "ASC", "CLUSTERS", "DECLARE", "EXISTS", "ASSERT",
			"COLAUTH", "DECIMAL", "EXIT", "ASSIGN", "COLUMNS", "DEFAULT", "FALSE",
			"AT", "COMMIT", "DEFINITION", "FETCH", "AUTHORIZATION", "COMPRESS",
			"DELAY", "FLOAT", "AVG", "CONNECT", "DELETE", "FOR", "BASE_TABLE",
			"CONSTANT", "DELTA", "FORM", "BEGIN", "COUNT", "DESC", "FROM", "FUNCTION",
			"NEW", "RELEASE", "SUM", "GENERIC", "NEXTVAL", "REMR", "TABAUTH", "GOTO",
			"NOCOMPRESS", "RENAME", "TABLE", "GRANT", "NOT", "RESOURCE", "TABLES",
			"GROUP", "NULL", "RETURN", "TASK", "HAVING", "NUMBER", "REVERSE",
			"TERMINATE", "IDENTIFIED", "NUMBER_BASE", "REVOKE", "THEN", "IF", "OF",
			"ROLLBACK", "TO", "IN", "ON", "ROWID", "TRUE", "INDEX", "OPEN",
			"ROWLABEL", "TYPE", "INDEXES", "OPTION", "ROWNUM", "UNION", "INDICATOR"
				, "OR", "ROWTYPE", "UNIQUE", "INSERT", "ORDER", "RUN", "UPDATE",
			"INTEGER", "OTHERS", "SAVEPOINT", "USE", "INTERSECT", "OUT", "SCHEMA",
			"VALUES", "INTO", "PACKAGE", "SELECT", "VARCHAR", "IS", "PARTITION",
			"SEPARATE", "VARCHAR2", "LEVEL", "PCTFREE", "SET", "VARIANCE", "LIKE",
			"POSITIVE", "SIZE", "VIEW", "LIMITED", "PRAGMA", "SMALLINT", "VIEWS",
			"LOOP", "PRIOR", "SPACE", "WHEN", "MAX", "PRIVATE", "SQL", "WHERE", "MIN",
			"PROCEDURE", "SQLCODE", "WHILE", "MINUS", "PUBLIC", "SQLERRM", "WITH",
			"MLSLABEL", "RAISE", "START", "WORK", "MOD", "RANGE", "STATEMENT", "XOR",
			"MODE", "REAL", "STDDEV", "", "NATURAL", "RECORD", "SUBTYPE", "VARCHAR",
			"INTEGER", "NUMBER", "NULL", "CONSTRAINT", "CURRENT_DATE", "NULL", "DATE"};
		
		#endregion
		
		public SyntaxHighlighter(RichTextBox txtCode)
		{
			this.txtCode = txtCode;
			Array.Sort(tabKeywords);
		}
		
		public void formater () {
			string text = txtCode.Text;
			
			
			string mot = "";
			int posi1 = 0;
			int posi2 = text.IndexOf(' ');
			int i;
			
			while (posi2 != -1) {
				mot = text.Substring(posi1, posi2-posi1);
				i = Array.BinarySearch(tabKeywords, mot.ToUpper());
				
				if (i > 0) {
					txtCode.Select(posi1, posi2-posi1);
					txtCode.SelectionColor = Color.Blue;
				}
				
				posi1 = posi2;
				posi1++;
				
				posi2 = text.IndexOf(' ', posi1);
				if (posi2 == -1) {
					Console.WriteLine("je rentre");
					posi2 = text.IndexOf('\t', posi1);
					Console.WriteLine(posi2);
				}
			}
		}
	}
}