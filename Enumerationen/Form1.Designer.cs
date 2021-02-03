
namespace Enumerationen
{
	partial class Form1
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnEnumeration1 = new System.Windows.Forms.Button();
			this.lblAnzeige = new System.Windows.Forms.Label();
			this.btnEnumeration2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEnumeration1
			// 
			this.btnEnumeration1.Location = new System.Drawing.Point(417, 27);
			this.btnEnumeration1.Name = "btnEnumeration1";
			this.btnEnumeration1.Size = new System.Drawing.Size(208, 64);
			this.btnEnumeration1.TabIndex = 0;
			this.btnEnumeration1.Text = "Enumeration 1 anzeigen";
			this.btnEnumeration1.UseVisualStyleBackColor = true;
			this.btnEnumeration1.Click += new System.EventHandler(this.btnEnumeration1_Click);
			// 
			// lblAnzeige
			// 
			this.lblAnzeige.AutoSize = true;
			this.lblAnzeige.Location = new System.Drawing.Point(42, 27);
			this.lblAnzeige.Name = "lblAnzeige";
			this.lblAnzeige.Size = new System.Drawing.Size(51, 20);
			this.lblAnzeige.TabIndex = 1;
			this.lblAnzeige.Text = "label1";
			// 
			// btnEnumeration2
			// 
			this.btnEnumeration2.Location = new System.Drawing.Point(417, 111);
			this.btnEnumeration2.Name = "btnEnumeration2";
			this.btnEnumeration2.Size = new System.Drawing.Size(208, 76);
			this.btnEnumeration2.TabIndex = 2;
			this.btnEnumeration2.Text = "Enumeration 2 anzeigen";
			this.btnEnumeration2.UseVisualStyleBackColor = true;
			this.btnEnumeration2.Click += new System.EventHandler(this.btnEnumeration2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnEnumeration2);
			this.Controls.Add(this.lblAnzeige);
			this.Controls.Add(this.btnEnumeration1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnEnumeration1;
		private System.Windows.Forms.Label lblAnzeige;
		private System.Windows.Forms.Button btnEnumeration2;
	}
}

