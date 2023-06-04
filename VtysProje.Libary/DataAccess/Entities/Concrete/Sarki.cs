using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Entities.Abstract;

namespace VtysProje.Libary.DataAccess.Entities.Concrete
{
	public class Sarki : IEntity
	{
		public int ID { get; set; }
		public int? SanatciID { get; set; }
		public int? AlbumID { get; set; }
		public int? TurID { get; set; }
		public string Baslik { get; set; }
		public DateTime? YayinTarihi { get; set; }
		public decimal? Ucret { get; set; }
		public int? SatilmaSayisi { get; set; }
		public DateTime? EklenmeTarihi { get; set; }
	}
}
