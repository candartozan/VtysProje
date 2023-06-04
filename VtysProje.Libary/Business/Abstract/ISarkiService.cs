using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Entities.Concrete;

namespace VtysProje.Libary.Business.Abstract
{
	internal interface ISarkiService
	{
		List<Sarki> GetAll();
		Sarki GetById(int id);
		Sarki Add(Sarki sarki);
		Sarki Update(Sarki sarki);
		Sarki Remove(Sarki sarki);
		List<Sarki> GetByUserID(int id);
		List<SarkiKazanc> MostProfit();
		List<Sarki> SortDescanding();
		List<Sarki> GetByName(string text);
	}
}
