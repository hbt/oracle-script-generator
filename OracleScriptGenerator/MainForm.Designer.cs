/*
 * 
 * Date: 2006/05/22
 * @author: Hassen Ben Tanfous
 */
using OracleScriptGenerator.GUI;
using System.Drawing;

namespace OracleScriptGenerator.GUI
{
	partial class MainForm : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.liste = new System.Windows.Forms.ListBox();
			this.txtCode = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.scriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afficherToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.enregistrersousToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.créerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.afficherToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.créerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.modifierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.supprimerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.afficherToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sequenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.créerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.modifierToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.supprimerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.afficherToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.synonymeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.créerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.modifierToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.supprimerToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.afficherToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.auteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// liste
			// 
			this.liste.FormattingEnabled = true;
			this.liste.Location = new System.Drawing.Point(23, 112);
			this.liste.Name = "liste";
			this.liste.Size = new System.Drawing.Size(185, 485);
			this.liste.TabIndex = 1;
			this.liste.Click += new System.EventHandler(this.ListeClick);
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.Color.White;
			this.txtCode.Location = new System.Drawing.Point(257, 112);
			this.txtCode.Name = "txtCode";
			this.txtCode.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(640, 485);
			this.txtCode.TabIndex = 2;
			this.txtCode.Text = "";
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 26);
			this.label1.TabIndex = 3;
			this.label1.Text = "Liste de toutes les entités";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(379, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(202, 26);
			this.label2.TabIndex = 4;
			this.label2.Text = "Contenu du script";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// scriptToolStripMenuItem
			// 
			this.scriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.afficherToolStripMenuItem4,
									this.toolStripSeparator2,
									this.enregistrerToolStripMenuItem,
									this.enregistrersousToolStripMenuItem1,
									this.toolStripSeparator1,
									this.quitterToolStripMenuItem1});
			this.scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
			this.scriptToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.scriptToolStripMenuItem.Text = "Script";
			// 
			// afficherToolStripMenuItem4
			// 
			this.afficherToolStripMenuItem4.Name = "afficherToolStripMenuItem4";
			this.afficherToolStripMenuItem4.Size = new System.Drawing.Size(176, 22);
			this.afficherToolStripMenuItem4.Text = "Charger Script SQL";
			this.afficherToolStripMenuItem4.Click += new System.EventHandler(this.AfficherToolStripMenuItem4Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(173, 6);
			// 
			// enregistrerToolStripMenuItem
			// 
			this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
			this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
			this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.enregistrerToolStripMenuItem.Text = "Enregistrer";
			// 
			// enregistrersousToolStripMenuItem1
			// 
			this.enregistrersousToolStripMenuItem1.Name = "enregistrersousToolStripMenuItem1";
			this.enregistrersousToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
			this.enregistrersousToolStripMenuItem1.Text = "Enregistrer-sous";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(173, 6);
			// 
			// quitterToolStripMenuItem1
			// 
			this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
			this.quitterToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
			this.quitterToolStripMenuItem1.Text = "Quitter";
			// 
			// tableToolStripMenuItem
			// 
			this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.créerToolStripMenuItem,
									this.modifierToolStripMenuItem,
									this.supprimerToolStripMenuItem,
									this.afficherToolStripMenuItem,
									this.afficherToolStripMenuItem5});
			this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
			this.tableToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.tableToolStripMenuItem.Text = "Table";
			// 
			// créerToolStripMenuItem
			// 
			this.créerToolStripMenuItem.Name = "créerToolStripMenuItem";
			this.créerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.créerToolStripMenuItem.Text = "Créer";
			this.créerToolStripMenuItem.Click += new System.EventHandler(this.CréerToolStripMenuItemClick);
			// 
			// modifierToolStripMenuItem
			// 
			this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
			this.modifierToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.modifierToolStripMenuItem.Text = "Modifier";
			// 
			// supprimerToolStripMenuItem
			// 
			this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
			this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.supprimerToolStripMenuItem.Text = "Supprimer";
			// 
			// afficherToolStripMenuItem
			// 
			this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
			this.afficherToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.afficherToolStripMenuItem.Text = "Décrire";
			// 
			// afficherToolStripMenuItem5
			// 
			this.afficherToolStripMenuItem5.Name = "afficherToolStripMenuItem5";
			this.afficherToolStripMenuItem5.Size = new System.Drawing.Size(133, 22);
			this.afficherToolStripMenuItem5.Text = "Afficher";
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.créerToolStripMenuItem1,
									this.modifierToolStripMenuItem1,
									this.supprimerToolStripMenuItem1,
									this.afficherToolStripMenuItem1});
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.indexToolStripMenuItem.Text = "Index";
			// 
			// créerToolStripMenuItem1
			// 
			this.créerToolStripMenuItem1.Name = "créerToolStripMenuItem1";
			this.créerToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
			this.créerToolStripMenuItem1.Text = "Créer";
			// 
			// modifierToolStripMenuItem1
			// 
			this.modifierToolStripMenuItem1.Name = "modifierToolStripMenuItem1";
			this.modifierToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
			this.modifierToolStripMenuItem1.Text = "Modifier";
			// 
			// supprimerToolStripMenuItem1
			// 
			this.supprimerToolStripMenuItem1.Name = "supprimerToolStripMenuItem1";
			this.supprimerToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
			this.supprimerToolStripMenuItem1.Text = "Supprimer";
			// 
			// afficherToolStripMenuItem1
			// 
			this.afficherToolStripMenuItem1.Name = "afficherToolStripMenuItem1";
			this.afficherToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
			this.afficherToolStripMenuItem1.Text = "Afficher";
			// 
			// sequenceToolStripMenuItem
			// 
			this.sequenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.créerToolStripMenuItem2,
									this.modifierToolStripMenuItem2,
									this.supprimerToolStripMenuItem2,
									this.afficherToolStripMenuItem2});
			this.sequenceToolStripMenuItem.Name = "sequenceToolStripMenuItem";
			this.sequenceToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.sequenceToolStripMenuItem.Text = "Sequence";
			// 
			// créerToolStripMenuItem2
			// 
			this.créerToolStripMenuItem2.Name = "créerToolStripMenuItem2";
			this.créerToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
			this.créerToolStripMenuItem2.Text = "Créer";
			// 
			// modifierToolStripMenuItem2
			// 
			this.modifierToolStripMenuItem2.Name = "modifierToolStripMenuItem2";
			this.modifierToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
			this.modifierToolStripMenuItem2.Text = "Modifier";
			// 
			// supprimerToolStripMenuItem2
			// 
			this.supprimerToolStripMenuItem2.Name = "supprimerToolStripMenuItem2";
			this.supprimerToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
			this.supprimerToolStripMenuItem2.Text = "Supprimer";
			// 
			// afficherToolStripMenuItem2
			// 
			this.afficherToolStripMenuItem2.Name = "afficherToolStripMenuItem2";
			this.afficherToolStripMenuItem2.Size = new System.Drawing.Size(133, 22);
			this.afficherToolStripMenuItem2.Text = "Afficher";
			// 
			// synonymeToolStripMenuItem
			// 
			this.synonymeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.créerToolStripMenuItem3,
									this.modifierToolStripMenuItem3,
									this.supprimerToolStripMenuItem3,
									this.afficherToolStripMenuItem3});
			this.synonymeToolStripMenuItem.Name = "synonymeToolStripMenuItem";
			this.synonymeToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.synonymeToolStripMenuItem.Text = "Synonyme";
			// 
			// créerToolStripMenuItem3
			// 
			this.créerToolStripMenuItem3.Name = "créerToolStripMenuItem3";
			this.créerToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
			this.créerToolStripMenuItem3.Text = "Créer";
			// 
			// modifierToolStripMenuItem3
			// 
			this.modifierToolStripMenuItem3.Name = "modifierToolStripMenuItem3";
			this.modifierToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
			this.modifierToolStripMenuItem3.Text = "Modifier";
			// 
			// supprimerToolStripMenuItem3
			// 
			this.supprimerToolStripMenuItem3.Name = "supprimerToolStripMenuItem3";
			this.supprimerToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
			this.supprimerToolStripMenuItem3.Text = "Supprimer";
			// 
			// afficherToolStripMenuItem3
			// 
			this.afficherToolStripMenuItem3.Name = "afficherToolStripMenuItem3";
			this.afficherToolStripMenuItem3.Size = new System.Drawing.Size(133, 22);
			this.afficherToolStripMenuItem3.Text = "Afficher";
			// 
			// aideToolStripMenuItem
			// 
			this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.auteurToolStripMenuItem});
			this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
			this.aideToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.aideToolStripMenuItem.Text = "Aide";
			// 
			// auteurToolStripMenuItem
			// 
			this.auteurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("auteurToolStripMenuItem.Image")));
			this.auteurToolStripMenuItem.Name = "auteurToolStripMenuItem";
			this.auteurToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.auteurToolStripMenuItem.Text = "Auteur";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.scriptToolStripMenuItem,
									this.tableToolStripMenuItem,
									this.indexToolStripMenuItem,
									this.sequenceToolStripMenuItem,
									this.synonymeToolStripMenuItem,
									this.aideToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(920, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(920, 618);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.liste);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OracleScriptGenerator -- par Hassen Ben Tanfous";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.RichTextBox txtCode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
		private System.Windows.Forms.ListBox liste;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem auteurToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem scriptToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem synonymeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem sequenceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem supprimerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem créerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		
		
	}
}
