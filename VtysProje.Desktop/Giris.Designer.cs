namespace VtysProje.Desktop
{
	partial class Giris
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
			this.lblEposta = new System.Windows.Forms.Label();
			this.lblSifre = new System.Windows.Forms.Label();
			this.txbEposta = new System.Windows.Forms.TextBox();
			this.txbSifre = new System.Windows.Forms.TextBox();
			this.btnGiris = new System.Windows.Forms.Button();
			this.btnKayıt = new System.Windows.Forms.Button();
			this.lblBilgi = new System.Windows.Forms.Label();
			this.llblUnuttum = new System.Windows.Forms.LinkLabel();
			this.SuspendLayout();
			// 
			// lblEposta
			// 
			this.lblEposta.AutoSize = true;
			this.lblEposta.Location = new System.Drawing.Point(31, 59);
			this.lblEposta.Name = "lblEposta";
			this.lblEposta.Size = new System.Drawing.Size(43, 13);
			this.lblEposta.TabIndex = 0;
			this.lblEposta.Text = "E-posta";
			// 
			// lblSifre
			// 
			this.lblSifre.AutoSize = true;
			this.lblSifre.Location = new System.Drawing.Point(31, 132);
			this.lblSifre.Name = "lblSifre";
			this.lblSifre.Size = new System.Drawing.Size(28, 13);
			this.lblSifre.TabIndex = 1;
			this.lblSifre.Text = "Şifre";
			// 
			// txbEposta
			// 
			this.txbEposta.Location = new System.Drawing.Point(31, 92);
			this.txbEposta.Name = "txbEposta";
			this.txbEposta.Size = new System.Drawing.Size(250, 20);
			this.txbEposta.TabIndex = 2;
			// 
			// txbSifre
			// 
			this.txbSifre.Location = new System.Drawing.Point(31, 165);
			this.txbSifre.Name = "txbSifre";
			this.txbSifre.Size = new System.Drawing.Size(250, 20);
			this.txbSifre.TabIndex = 3;
			// 
			// btnGiris
			// 
			this.btnGiris.Location = new System.Drawing.Point(31, 205);
			this.btnGiris.Name = "btnGiris";
			this.btnGiris.Size = new System.Drawing.Size(110, 23);
			this.btnGiris.TabIndex = 4;
			this.btnGiris.Text = "Giriş";
			this.btnGiris.UseVisualStyleBackColor = true;
			this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
			// 
			// btnKayıt
			// 
			this.btnKayıt.Location = new System.Drawing.Point(171, 205);
			this.btnKayıt.Name = "btnKayıt";
			this.btnKayıt.Size = new System.Drawing.Size(110, 23);
			this.btnKayıt.TabIndex = 5;
			this.btnKayıt.Text = "Kayıt Ol";
			this.btnKayıt.UseVisualStyleBackColor = true;
			// 
			// lblBilgi
			// 
			this.lblBilgi.AutoSize = true;
			this.lblBilgi.Location = new System.Drawing.Point(31, 26);
			this.lblBilgi.Name = "lblBilgi";
			this.lblBilgi.Size = new System.Drawing.Size(155, 13);
			this.lblBilgi.TabIndex = 6;
			this.lblBilgi.Text = "Giriş yapmak için bilgileriniz girin";
			// 
			// llblUnuttum
			// 
			this.llblUnuttum.AutoSize = true;
			this.llblUnuttum.Location = new System.Drawing.Point(31, 249);
			this.llblUnuttum.Name = "llblUnuttum";
			this.llblUnuttum.Size = new System.Drawing.Size(81, 13);
			this.llblUnuttum.TabIndex = 7;
			this.llblUnuttum.TabStop = true;
			this.llblUnuttum.Text = "Şifremi Unuttum";
			// 
			// Giris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 299);
			this.Controls.Add(this.llblUnuttum);
			this.Controls.Add(this.lblBilgi);
			this.Controls.Add(this.btnKayıt);
			this.Controls.Add(this.btnGiris);
			this.Controls.Add(this.txbSifre);
			this.Controls.Add(this.txbEposta);
			this.Controls.Add(this.lblSifre);
			this.Controls.Add(this.lblEposta);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(326, 338);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(326, 338);
			this.Name = "Giris";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblEposta;
		private System.Windows.Forms.Label lblSifre;
		private System.Windows.Forms.TextBox txbEposta;
		private System.Windows.Forms.TextBox txbSifre;
		private System.Windows.Forms.Button btnGiris;
		private System.Windows.Forms.Button btnKayıt;
		private System.Windows.Forms.Label lblBilgi;
		private System.Windows.Forms.LinkLabel llblUnuttum;
	}
}