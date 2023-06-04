using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VtysProje.Libary.Business.Concrete;
using VtysProje.Libary.DataAccess.Concrete;

namespace VtysProje.Desktop
{
	public partial class Giris : Form
	{
		KullaniciManager _kullaniciManager;
		public Giris()
		{
			InitializeComponent();
			_kullaniciManager = new KullaniciManager();
		}

		private void btnGiris_Click(object sender, EventArgs e)
		{
			string eposta = txbEposta.Text;
			string sifre = txbSifre.Text;
			if (EntryControl(eposta, sifre))
			{
				var kullanici = _kullaniciManager.GetByEmail(eposta);
				var uygulama = new Uygulama(kullanici);
				uygulama.Show();
				this.Hide();
				return;
			}
			MessageBox.Show("E-posta ya da şifre hatalı!");
		}

		private bool EntryControl(string eposta, string sifre)
		{
			var kullanici = _kullaniciManager.GetByEmail(eposta);
			if (kullanici == null || kullanici.Sifre != sifre)
				return false;
			return true;
		}
	}
}
