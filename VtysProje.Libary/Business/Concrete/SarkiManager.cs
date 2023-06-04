using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.Business.Abstract;
using VtysProje.Libary.DataAccess.Abstract;
using VtysProje.Libary.DataAccess.Concrete;
using VtysProje.Libary.DataAccess.Entities.Concrete;

namespace VtysProje.Libary.Business.Concrete
{
	public class SarkiManager : ISarkiService
	{
		ISarkiDal _sarkiDal;
		ISatilanSarkiDal _satilanSarkiDal;

		public SarkiManager()
		{
			_sarkiDal = new SarkiDal();
			_satilanSarkiDal = new SatilanSarkiDal();
		}

		public Sarki Add(Sarki sarki)
		{
			return _sarkiDal.Add(sarki);
		}

		public List<Sarki> GetAll()
		{
			return _sarkiDal.GetList();
		}

		public Sarki GetById(int id)
		{
			return _sarkiDal.Get(s => s.ID == id);
		}

		public List<Sarki> GetByName(string text)
		{
			return _sarkiDal.GetList(s => s.Baslik.ToLower().Contains(text.ToLower())).ToList();
		}

		public List<Sarki> GetByUserID(int id)
		{
			var satilanlar = _satilanSarkiDal.GetList(ss => ss.KullaniciID == id).Select(ss => ss.SarkiID).ToList();
			return _sarkiDal.GetList(s => satilanlar.Contains(s.ID));
		}

		public List<SarkiKazanc> MostProfit()
		{
			var sarkilar = _sarkiDal.GetList();
			var kazanc = new List<SarkiKazanc>();
			foreach (var s in sarkilar)
			{
				kazanc.Add(new SarkiKazanc { SarkiID = s.ID, Kazanc = ((decimal)s.SatilmaSayisi * (decimal)s.Ucret) });
			}
			kazanc = kazanc.OrderByDescending(k=>k.Kazanc).ToList();
			return kazanc;
		}

		public Sarki Remove(Sarki sarki)
		{
			return _sarkiDal.Delete(sarki);
		}

		public List<Sarki> SortDescanding()
		{
			var sarkilar = _sarkiDal.GetList();
			sarkilar = sarkilar.OrderByDescending(s => s.SatilmaSayisi).ToList();
			return sarkilar;
		}

		public Sarki Update(Sarki sarki)
		{
			return _sarkiDal.Update(sarki);
		}
	}
}
