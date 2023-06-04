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
using VtysProje.Libary.DataAccess.Abstract;
using VtysProje.Libary.DataAccess.Concrete;
using VtysProje.Libary.DataAccess.Entities.Concrete;

namespace VtysProje.Desktop
{
	public partial class Uygulama : Form
	{
		Kullanici mevcutKullanici;
		KullaniciManager _kullaniciManager;
		SarkiManager _sarkiManager;
		public Uygulama(Kullanici kullanici)
		{
			InitializeComponent();
			mevcutKullanici = kullanici;
			_kullaniciManager = new KullaniciManager();
			_sarkiManager = new SarkiManager();
		}

		private void Uygulama_Load(object sender, EventArgs e)
		{
			dgv.DataSource = _sarkiManager.GetAll();
		}

		private void btnTumSarkilar_Click(object sender, EventArgs e)
		{
			dgv.DataSource = _sarkiManager.GetAll();
		}

		private void btnSarkilarim_Click(object sender, EventArgs e)
		{
			dgv.DataSource = _sarkiManager.GetByUserID(mevcutKullanici.ID);
		}

		private void btnEnCokKazandıran_Click(object sender, EventArgs e)
		{
			var kazanc = _sarkiManager.MostProfit();
			dgv.DataSource = kazanc;
		}

		private void BtnEnCokSatilan_Click(object sender, EventArgs e)
		{
			dgv.DataSource = _sarkiManager.SortDescanding();
		}

		private void tbxArama_TextChanged(object sender, EventArgs e)
		{
			dgv.DataSource = _sarkiManager.GetByName(tbxArama.Text);
		}
	}
}
