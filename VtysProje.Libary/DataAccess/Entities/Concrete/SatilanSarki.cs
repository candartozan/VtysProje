using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Entities.Abstract;

namespace VtysProje.Libary.DataAccess.Entities.Concrete
{
	public class SatilanSarki : IEntity
	{
		[Key]
		public int SarkiID { get; set; }
		[Key]
		public int KullaniciID { get; set; }
		public DateTime? SatilmaTarihi { get; set; }
	}
}
