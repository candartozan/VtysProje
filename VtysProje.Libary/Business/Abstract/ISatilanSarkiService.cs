using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Entities.Concrete;

namespace VtysProje.Libary.Business.Abstract
{
	public interface ISatilanSarkiService
	{
		List<SatilanSarki> GetAll();
		SatilanSarki Add(SatilanSarki satilanSarki);
		SatilanSarki Update(SatilanSarki satilanSarki);
		SatilanSarki Remove(SatilanSarki satilanSarki);
	}
}
