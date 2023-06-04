using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.Business.Abstract;
using VtysProje.Libary.DataAccess.Concrete;
using VtysProje.Libary.DataAccess.Entities.Concrete;

namespace VtysProje.Libary.Business.Concrete
{
	public class SatilanSarkiManager : ISatilanSarkiService
	{
		SatilanSarkiDal _satilanSarkiDal;

		public SatilanSarkiManager()
		{
			_satilanSarkiDal = new SatilanSarkiDal();
		}

		public SatilanSarki Add(SatilanSarki satilanSarki)
		{
			return _satilanSarkiDal.Add(satilanSarki);
		}

		public List<SatilanSarki> GetAll()
		{
			return _satilanSarkiDal.GetList();
		}

		public SatilanSarki Remove(SatilanSarki satilanSarki)
		{
			return _satilanSarkiDal.Delete(satilanSarki);
		}

		public SatilanSarki Update(SatilanSarki satilanSarki)
		{
			return _satilanSarkiDal.Update(satilanSarki);
		}
	}
}
