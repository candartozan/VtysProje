using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Entities.Concrete;

namespace VtysProje.Libary.Business.Abstract
{
	public interface IKullaniciService
	{
		List<Kullanici> GetAll();
		Kullanici GetById(int id);
		Kullanici Add(Kullanici kullanici);
		Kullanici Update(Kullanici kullanici);
		Kullanici Remove(Kullanici kullanici);
		Kullanici GetByEmail(string email);
	}
}
