﻿/*
 * 
 * Date: ${DATE}
 * @author: Hassen Ben Tanfous
 */
namespace OracleScriptGenerator.GUI.Tables
{
	partial class ContraintePrimaryKey : System.Windows.Forms.Form
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
			this.liste = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.boutonAjouter = new System.Windows.Forms.Button();
			this.boutonAnnuler = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// liste
			// 
			this.liste.FormattingEnabled = true;
			this.liste.Location = new System.Drawing.Point(12, 62);
			this.liste.Name = "liste";
			this.liste.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.liste.Size = new System.Drawing.Size(120, 199);
			this.liste.TabIndex = 0;
			
			this.liste.Click += new System.EventHandler(this.ListeClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Sélectionner les attributs Primary Key";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(180, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Code Oracle";
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.Color.White;
			this.txtCode.Location = new System.Drawing.Point(180, 103);
			this.txtCode.Name = "txtCode";
			this.txtCode.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(208, 192);
			this.txtCode.TabIndex = 3;
			this.txtCode.Text = "";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Liste des attributs";
			// 
			// boutonAjouter
			// 
			this.boutonAjouter.Location = new System.Drawing.Point(217, 306);
			this.boutonAjouter.Name = "boutonAjouter";
			this.boutonAjouter.Size = new System.Drawing.Size(75, 23);
			this.boutonAjouter.TabIndex = 5;
			this.boutonAjouter.Text = "Ajouter";
			this.boutonAjouter.UseVisualStyleBackColor = true;
			this.boutonAjouter.Click += new System.EventHandler(this.BoutonAjouterClick);
			// 
			// boutonAnnuler
			// 
			this.boutonAnnuler.Location = new System.Drawing.Point(313, 306);
			this.boutonAnnuler.Name = "boutonAnnuler";
			this.boutonAnnuler.Size = new System.Drawing.Size(75, 23);
			this.boutonAnnuler.TabIndex = 6;
			this.boutonAnnuler.Text = "Annuler";
			this.boutonAnnuler.UseVisualStyleBackColor = true;
			this.boutonAnnuler.Click += new System.EventHandler(this.BoutonAnnulerClick);
			// 
			// ContraintePrimaryKey
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 341);
			this.Controls.Add(this.boutonAnnuler);
			this.Controls.Add(this.boutonAjouter);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.liste);
			this.Name = "ContraintePrimaryKey";
			this.Text = "Ajout d\'une contrainte Primary Key";
			this.Load += new System.EventHandler(this.ContraintePrimaryKeyLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ListBox liste;
		private System.Windows.Forms.RichTextBox txtCode;
		private System.Windows.Forms.Button boutonAjouter;
		private System.Windows.Forms.Button boutonAnnuler;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
