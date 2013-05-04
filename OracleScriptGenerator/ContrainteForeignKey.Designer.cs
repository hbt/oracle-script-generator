/*
 * 
 * Date: ${DATE}
 * @author: Hassen Ben Tanfous
 */
namespace OracleScriptGenerator.GUI.Tables
{
	partial class ContrainteForeignKey : System.Windows.Forms.Form
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.listeAttributs = new System.Windows.Forms.ListBox();
			this.listeTables = new System.Windows.Forms.ListBox();
			this.listeAttributsRef = new System.Windows.Forms.ListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.RichTextBox();
			this.boutonAjouter = new System.Windows.Forms.Button();
			this.boutonAnnuler = new System.Windows.Forms.Button();
			this.checkAllAttributs = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(-2, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(621, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sélectionner les attributs pour Foreign Key, la table de References et les attrib" +
			"uts de la table";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Attributs";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(172, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tables références";
			// 
			// listeAttributs
			// 
			this.listeAttributs.FormattingEnabled = true;
			this.listeAttributs.Location = new System.Drawing.Point(12, 88);
			this.listeAttributs.Name = "listeAttributs";
			this.listeAttributs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listeAttributs.Size = new System.Drawing.Size(120, 251);
			this.listeAttributs.TabIndex = 3;
			this.listeAttributs.SelectedIndexChanged += new System.EventHandler(this.ListeAttributsSelectedIndexChanged);
			// 
			// listeTables
			// 
			this.listeTables.FormattingEnabled = true;
			this.listeTables.Location = new System.Drawing.Point(172, 88);
			this.listeTables.Name = "listeTables";
			this.listeTables.Size = new System.Drawing.Size(120, 251);
			this.listeTables.TabIndex = 4;
			this.listeTables.SelectedIndexChanged += new System.EventHandler(this.ListeTablesSelectedIndexChanged);
			// 
			// listeAttributsRef
			// 
			this.listeAttributsRef.FormattingEnabled = true;
			this.listeAttributsRef.Location = new System.Drawing.Point(331, 88);
			this.listeAttributsRef.Name = "listeAttributsRef";
			this.listeAttributsRef.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listeAttributsRef.Size = new System.Drawing.Size(120, 251);
			this.listeAttributsRef.TabIndex = 5;
			this.listeAttributsRef.SelectedIndexChanged += new System.EventHandler(this.ListeAttributsRefSelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(331, 43);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(120, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Attributs de la table";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(475, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 7;
			this.label5.Text = "Code Oracle";
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.Color.White;
			this.txtCode.Location = new System.Drawing.Point(475, 119);
			this.txtCode.Name = "txtCode";
			this.txtCode.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(144, 151);
			this.txtCode.TabIndex = 8;
			this.txtCode.Text = "";
			// 
			// boutonAjouter
			// 
			this.boutonAjouter.Location = new System.Drawing.Point(436, 360);
			this.boutonAjouter.Name = "boutonAjouter";
			this.boutonAjouter.Size = new System.Drawing.Size(75, 23);
			this.boutonAjouter.TabIndex = 9;
			this.boutonAjouter.Text = "Ajouter";
			this.boutonAjouter.UseVisualStyleBackColor = true;
			this.boutonAjouter.Click += new System.EventHandler(this.BoutonAjouterClick);
			// 
			// boutonAnnuler
			// 
			this.boutonAnnuler.Location = new System.Drawing.Point(544, 360);
			this.boutonAnnuler.Name = "boutonAnnuler";
			this.boutonAnnuler.Size = new System.Drawing.Size(75, 23);
			this.boutonAnnuler.TabIndex = 10;
			this.boutonAnnuler.Text = "Annuler";
			this.boutonAnnuler.UseVisualStyleBackColor = true;
			this.boutonAnnuler.Click += new System.EventHandler(this.BoutonAnnulerClick);
			// 
			// checkAllAttributs
			// 
			this.checkAllAttributs.Location = new System.Drawing.Point(331, 58);
			this.checkAllAttributs.Name = "checkAllAttributs";
			this.checkAllAttributs.Size = new System.Drawing.Size(120, 24);
			this.checkAllAttributs.TabIndex = 11;
			this.checkAllAttributs.Text = "Tous les attributs";
			this.checkAllAttributs.UseVisualStyleBackColor = true;
			this.checkAllAttributs.CheckedChanged += new System.EventHandler(this.CheckAllAttributsCheckedChanged);
			// 
			// ContrainteForeignKey
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 395);
			this.Controls.Add(this.checkAllAttributs);
			this.Controls.Add(this.boutonAnnuler);
			this.Controls.Add(this.boutonAjouter);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listeAttributsRef);
			this.Controls.Add(this.listeTables);
			this.Controls.Add(this.listeAttributs);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ContrainteForeignKey";
			this.Text = "Ajout d\'une contrainte Foreign Key";
			this.Load += new System.EventHandler(this.ContrainteForeignKeyLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.CheckBox checkAllAttributs;
		private System.Windows.Forms.ListBox listeAttributs;
		private System.Windows.Forms.ListBox listeTables;
		private System.Windows.Forms.ListBox listeAttributsRef;
		private System.Windows.Forms.RichTextBox txtCode;
		private System.Windows.Forms.Button boutonAjouter;
		private System.Windows.Forms.Button boutonAnnuler;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
