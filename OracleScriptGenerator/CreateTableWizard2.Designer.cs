/*
 * 
 * Date: ${DATE}
 * @author: Hassen Ben Tanfous
 */
using OracleScriptGenerator.Tables;

namespace OracleScriptGenerator.GUI.Tables
{
	partial class CreateTableWizard2 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.table = new System.Windows.Forms.DataGridView();
			this.boutonPrev = new System.Windows.Forms.Button();
			this.boutonSuivant = new System.Windows.Forms.Button();
			this.boutonAnnuler = new System.Windows.Forms.Button();
			this.colonneAttribut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colonneType = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.colonneTaille = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colonneDefault = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colonneNN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.colonneNNConstraint = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colonneAutoNN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
			this.SuspendLayout();
			// 
			// table
			// 
			this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.colonneAttribut,
									this.colonneType,
									this.colonneTaille,
									this.colonneDefault,
									this.colonneNN,
									this.colonneNNConstraint,
									this.colonneAutoNN});
			this.table.Location = new System.Drawing.Point(3, 12);
			this.table.Name = "table";
			this.table.Size = new System.Drawing.Size(761, 304);
			this.table.TabIndex = 0;
			this.table.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableRowEnter);
			this.table.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.TableRowsAdded);
			// 
			// boutonPrev
			// 
			this.boutonPrev.Location = new System.Drawing.Point(431, 322);
			this.boutonPrev.Name = "boutonPrev";
			this.boutonPrev.Size = new System.Drawing.Size(75, 23);
			this.boutonPrev.TabIndex = 1;
			this.boutonPrev.Text = "Précédent";
			this.boutonPrev.UseVisualStyleBackColor = true;
			this.boutonPrev.Click += new System.EventHandler(this.BoutonPrevClick);
			// 
			// boutonSuivant
			// 
			this.boutonSuivant.Location = new System.Drawing.Point(526, 322);
			this.boutonSuivant.Name = "boutonSuivant";
			this.boutonSuivant.Size = new System.Drawing.Size(75, 23);
			this.boutonSuivant.TabIndex = 2;
			this.boutonSuivant.Text = "Suivant";
			this.boutonSuivant.UseVisualStyleBackColor = true;
			this.boutonSuivant.Click += new System.EventHandler(this.BoutonSuivantClick);
			// 
			// boutonAnnuler
			// 
			this.boutonAnnuler.Location = new System.Drawing.Point(687, 322);
			this.boutonAnnuler.Name = "boutonAnnuler";
			this.boutonAnnuler.Size = new System.Drawing.Size(75, 23);
			this.boutonAnnuler.TabIndex = 3;
			this.boutonAnnuler.Text = "Annuler";
			this.boutonAnnuler.UseVisualStyleBackColor = true;
			this.boutonAnnuler.Click += new System.EventHandler(this.BoutonAnnulerClick);
			// 
			// colonneAttribut
			// 
			this.colonneAttribut.HeaderText = "Attribut";
			this.colonneAttribut.Name = "colonneAttribut";
			this.colonneAttribut.ToolTipText = "Nom de l\'attribut";
			// 
			// colonneType
			// 
			this.colonneType.HeaderText = "Type";
			this.colonneType.Name = "colonneType";
			this.colonneType.ToolTipText = "Type de l\'attribut";
			// 
			// colonneTaille
			// 
			this.colonneTaille.HeaderText = "Taille";
			this.colonneTaille.Name = "colonneTaille";
			this.colonneTaille.ToolTipText = "Taille de l\'attribut si nécessaire ex: 25";
			// 
			// colonneDefault
			// 
			this.colonneDefault.HeaderText = "Default value";
			this.colonneDefault.Name = "colonneDefault";
			this.colonneDefault.ToolTipText = "valeur par défaut d\'un attribut ex: CURRENT_DATE";
			// 
			// colonneNN
			// 
			this.colonneNN.HeaderText = "NOT NULL";
			this.colonneNN.Name = "colonneNN";
			this.colonneNN.ToolTipText = "contrainte not null";
			// 
			// colonneNNConstraint
			// 
			this.colonneNNConstraint.HeaderText = "Nom contrainte NOT NULL";
			this.colonneNNConstraint.Name = "colonneNNConstraint";
			this.colonneNNConstraint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.colonneNNConstraint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.colonneNNConstraint.ToolTipText = "Le nom de la contrainte not null";
			// 
			// colonneAutoNN
			// 
			this.colonneAutoNN.HeaderText = "Nom contrainte NOT NULL automatic";
			this.colonneAutoNN.Name = "colonneAutoNN";
			this.colonneAutoNN.ToolTipText = "contrainte not null générée ex: nom_table_nom_attribut_nn";
			// 
			// CreateTableWizard2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(774, 357);
			this.Controls.Add(this.boutonAnnuler);
			this.Controls.Add(this.boutonSuivant);
			this.Controls.Add(this.boutonPrev);
			this.Controls.Add(this.table);
			this.Name = "CreateTableWizard2";
			this.Text = "Création de la table -- Attributs";
			this.Load += new System.EventHandler(this.CreateTableWizard2Load);
			((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView table;
		private System.Windows.Forms.Button boutonPrev;
		private System.Windows.Forms.Button boutonSuivant;
		private System.Windows.Forms.Button boutonAnnuler;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colonneAutoNN;
		private System.Windows.Forms.DataGridViewTextBoxColumn colonneNNConstraint;
		private System.Windows.Forms.DataGridViewCheckBoxColumn colonneNN;
		private System.Windows.Forms.DataGridViewTextBoxColumn colonneDefault;
		private System.Windows.Forms.DataGridViewTextBoxColumn colonneTaille;
		private System.Windows.Forms.DataGridViewComboBoxColumn colonneType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colonneAttribut;
		
		
		
		void CreateTableWizard2Load(object sender, System.EventArgs e)
		{
			this.colonneType.Items.AddRange(new string[] { Attribut.BFILE, Attribut.BINARY_INTEGER, Attribut.BLOB, Attribut.CHAR, Attribut.CLOB, Attribut.DATE, Attribut.INTEGER, Attribut.MLSLABEL, Attribut.NCHAR, Attribut.NCLOB, Attribut.NUMBER, Attribut.NVARCHAR2, Attribut.PLS_INTEGER, Attribut.RAW, Attribut.ROWID, Attribut.TIMESTAMP, Attribut.UROWID, Attribut.VARCHAR2, Attribut.XMLTYPE });
			table.Rows[0].Cells[1].Value = Attribut.INTEGER;
//			
//			//a enlever uniquement pour test
//			table.Rows.Add();
//			table.Rows.Add();
//			table.Rows[0].Cells[0].Value = "no";
//			table.Rows[0].Cells[1].Value = Attribut.INTEGER;
//			table.Rows[0].Cells[3].Value = "666"; //default value
////			table.Rows[0].Cells[4].Value = "True"; 
////			table.Rows[0].Cells[6].Value = "True";
//			
//			
//			table.Rows[1].Cells[0].Value = "nom";
//			table.Rows[1].Cells[1].Value = Attribut.VARCHAR2;
//			table.Rows[1].Cells[2].Value = "55";
////			table.Rows[1].Cells[4].Value = "True";
//			table.Rows[1].Cells[5].Value = "employee_nom_nn";
//			
//			
//			table.Rows[2].Cells[0].Value = "prenom";
//			table.Rows[2].Cells[1].Value = Attribut.VARCHAR2;
//			table.Rows[2].Cells[2].Value = "55";
////			table.Rows[2].Cells[4].Value = "True";
				
			
				
			
		}
	}
}
