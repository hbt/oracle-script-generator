/*
 * 
 * Date: ${DATE}
 * @author: Hassen Ben Tanfous
 */
namespace OracleScriptGenerator.GUI.Tables
{
	partial class ContrainteCheck : System.Windows.Forms.Form
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
			this.txtCheck = new System.Windows.Forms.TextBox();
			this.liste = new System.Windows.Forms.ListBox();
			this.txtCode = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.boutonAnnuler = new System.Windows.Forms.Button();
			this.boutonAjouter = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(232, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Écrivez la contrainte CHECK";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "Liste attributs à titre de référence";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(171, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Contrainte CHECK";
			// 
			// txtCheck
			// 
			this.txtCheck.Location = new System.Drawing.Point(171, 72);
			this.txtCheck.Name = "txtCheck";
			this.txtCheck.Size = new System.Drawing.Size(260, 21);
			this.txtCheck.TabIndex = 3;
			this.txtCheck.TextChanged += new System.EventHandler(this.TxtCheckTextChanged);
			// 
			// liste
			// 
			this.liste.FormattingEnabled = true;
			this.liste.Location = new System.Drawing.Point(12, 72);
			this.liste.Name = "liste";
			this.liste.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.liste.Size = new System.Drawing.Size(114, 251);
			this.liste.TabIndex = 4;
			this.liste.SelectedIndexChanged += new System.EventHandler(this.ListeSelectedIndexChanged);
			// 
			// txtCode
			// 
			this.txtCode.BackColor = System.Drawing.Color.White;
			this.txtCode.Location = new System.Drawing.Point(171, 156);
			this.txtCode.Name = "txtCode";
			this.txtCode.ReadOnly = true;
			this.txtCode.Size = new System.Drawing.Size(260, 119);
			this.txtCode.TabIndex = 5;
			this.txtCode.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(171, 121);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 6;
			this.label4.Text = "Code Oracle";
			// 
			// boutonAnnuler
			// 
			this.boutonAnnuler.Location = new System.Drawing.Point(382, 315);
			this.boutonAnnuler.Name = "boutonAnnuler";
			this.boutonAnnuler.Size = new System.Drawing.Size(75, 23);
			this.boutonAnnuler.TabIndex = 7;
			this.boutonAnnuler.Text = "Annuler";
			this.boutonAnnuler.UseVisualStyleBackColor = true;
			this.boutonAnnuler.Click += new System.EventHandler(this.BoutonAnnulerClick);
			// 
			// boutonAjouter
			// 
			this.boutonAjouter.Location = new System.Drawing.Point(277, 315);
			this.boutonAjouter.Name = "boutonAjouter";
			this.boutonAjouter.Size = new System.Drawing.Size(75, 23);
			this.boutonAjouter.TabIndex = 8;
			this.boutonAjouter.Text = "Ajouter";
			this.boutonAjouter.UseVisualStyleBackColor = true;
			this.boutonAjouter.Click += new System.EventHandler(this.BoutonAjouterClick);
			// 
			// ContrainteCheck
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(469, 359);
			this.Controls.Add(this.boutonAjouter);
			this.Controls.Add(this.boutonAnnuler);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.liste);
			this.Controls.Add(this.txtCheck);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ContrainteCheck";
			this.Text = "Ajout d\'une contrainte CHECK";
			this.Load += new System.EventHandler(this.ContrainteCheckLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtCheck;
		private System.Windows.Forms.ListBox liste;
		private System.Windows.Forms.RichTextBox txtCode;
		private System.Windows.Forms.Button boutonAnnuler;
		private System.Windows.Forms.Button boutonAjouter;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
