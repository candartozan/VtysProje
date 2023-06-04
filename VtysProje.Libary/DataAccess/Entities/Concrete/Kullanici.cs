using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Entities.Abstract;

namespace VtysProje.Libary.DataAccess.Entities.Concrete
{
	public class Kullanici : IEntity
	{
		public int ID { get; set; }
		public int? YetkiID { get; set; }
		public string KullaniciAdi { get; set; }
		public string Sifre { get; set; }
		public string Eposta { get; set; }
		public string AdSoyad { get; set; }
		public DateTime? DogumTarihi { get; set; }
		public DateTime? KatilmaTarihi { get; set; }
	}
}
