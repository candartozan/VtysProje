using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Entities.Abstract;

namespace VtysProje.Libary.DataAccess.Entities.Concrete
{
	public class SarkiKazanc : IEntity
	{
		public int SarkiID { get; set; }
		public decimal? Kazanc { get; set; }
	}
}
