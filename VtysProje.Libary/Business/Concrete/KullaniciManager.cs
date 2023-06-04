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
	public class KullaniciManager : IKullaniciService
	{
		IKullaniciDal _kullaniciDal;

		public KullaniciManager()
		{
			_kullaniciDal = new KullaniciDal();
		}

		public Kullanici Add(Kullanici kullanici)
		{
			return _kullaniciDal.Add(kullanici);
		}

		public List<Kullanici> GetAll()
		{
			return _kullaniciDal.GetList();
		}

		public Kullanici GetByEmail(string email)
		{
			return _kullaniciDal.Get(k => k.Eposta == email);
		}

		public Kullanici GetById(int id)
		{
			return _kullaniciDal.Get(k => k.ID == id);
		}

		public Kullanici Remove(Kullanici kullanici)
		{
			return _kullaniciDal.Delete(kullanici);
		}

		public Kullanici Update(Kullanici kullanici)
		{
			return _kullaniciDal.Update(kullanici);
		}
	}
}
