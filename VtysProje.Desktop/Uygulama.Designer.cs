namespace VtysProje.Desktop
{
	partial class Uygulama
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgv = new System.Windows.Forms.DataGridView();
			this.btnTumSarkilar = new System.Windows.Forms.Button();
			this.btnEnCokKazandıran = new System.Windows.Forms.Button();
			this.BtnEnCokSatilan = new System.Windows.Forms.Button();
			this.btnSarkilarim = new System.Windows.Forms.Button();
			this.tbxArama = new System.Windows.Forms.TextBox();
			this.lblBilgi = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(12, 116);
			this.dgv.Name = "dgv";
			this.dgv.Size = new System.Drawing.Size(776, 322);
			this.dgv.TabIndex = 0;
			// 
			// btnTumSarkilar
			// 
			this.btnTumSarkilar.Location = new System.Drawing.Point(12, 87);
			this.btnTumSarkilar.Name = "btnTumSarkilar";
			this.btnTumSarkilar.Size = new System.Drawing.Size(176, 23);
			this.btnTumSarkilar.TabIndex = 1;
			this.btnTumSarkilar.Text = "Tüm Şarkılar";
			this.btnTumSarkilar.UseVisualStyleBackColor = true;
			this.btnTumSarkilar.Click += new System.EventHandler(this.btnTumSarkilar_Click);
			// 
			// btnEnCokKazandıran
			// 
			this.btnEnCokKazandıran.Location = new System.Drawing.Point(414, 87);
			this.btnEnCokKazandıran.Name = "btnEnCokKazandıran";
			this.btnEnCokKazandıran.Size = new System.Drawing.Size(176, 23);
			this.btnEnCokKazandıran.TabIndex = 2;
			this.btnEnCokKazandıran.Text = "En Çok Kazandıran Şarkılar";
			this.btnEnCokKazandıran.UseVisualStyleBackColor = true;
			this.btnEnCokKazandıran.Click += new System.EventHandler(this.btnEnCokKazandıran_Click);
			// 
			// BtnEnCokSatilan
			// 
			this.BtnEnCokSatilan.Location = new System.Drawing.Point(612, 87);
			this.BtnEnCokSatilan.Name = "BtnEnCokSatilan";
			this.BtnEnCokSatilan.Size = new System.Drawing.Size(176, 23);
			this.BtnEnCokSatilan.TabIndex = 3;
			this.BtnEnCokSatilan.Text = "En Çok Satılan Şarkılar";
			this.BtnEnCokSatilan.UseVisualStyleBackColor = true;
			this.BtnEnCokSatilan.Click += new System.EventHandler(this.BtnEnCokSatilan_Click);
			// 
			// btnSarkilarim
			// 
			this.btnSarkilarim.Location = new System.Drawing.Point(212, 87);
			this.btnSarkilarim.Name = "btnSarkilarim";
			this.btnSarkilarim.Size = new System.Drawing.Size(176, 23);
			this.btnSarkilarim.TabIndex = 4;
			this.btnSarkilarim.Text = "Şarkılarım";
			this.btnSarkilarim.UseVisualStyleBackColor = true;
			this.btnSarkilarim.Click += new System.EventHandler(this.btnSarkilarim_Click);
			// 
			// tbxArama
			// 
			this.tbxArama.Location = new System.Drawing.Point(265, 40);
			this.tbxArama.Name = "tbxArama";
			this.tbxArama.Size = new System.Drawing.Size(374, 20);
			this.tbxArama.TabIndex = 5;
			this.tbxArama.TextChanged += new System.EventHandler(this.tbxArama_TextChanged);
			// 
			// lblBilgi
			// 
			this.lblBilgi.AutoSize = true;
			this.lblBilgi.Location = new System.Drawing.Point(12, 43);
			this.lblBilgi.Name = "lblBilgi";
			this.lblBilgi.Size = new System.Drawing.Size(247, 13);
			this.lblBilgi.TabIndex = 6;
			this.lblBilgi.Text = "Tüm Şarkılarda Arama Yapmak İçin Şarkı Adı Yazın";
			// 
			// Uygulama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblBilgi);
			this.Controls.Add(this.tbxArama);
			this.Controls.Add(this.btnSarkilarim);
			this.Controls.Add(this.BtnEnCokSatilan);
			this.Controls.Add(this.btnEnCokKazandıran);
			this.Controls.Add(this.btnTumSarkilar);
			this.Controls.Add(this.dgv);
			this.Name = "Uygulama";
			this.Text = "Uygulama";
			this.Load += new System.EventHandler(this.Uygulama_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.Button btnTumSarkilar;
		private System.Windows.Forms.Button btnEnCokKazandıran;
		private System.Windows.Forms.Button BtnEnCokSatilan;
		private System.Windows.Forms.Button btnSarkilarim;
		private System.Windows.Forms.TextBox tbxArama;
		private System.Windows.Forms.Label lblBilgi;
	}
}

