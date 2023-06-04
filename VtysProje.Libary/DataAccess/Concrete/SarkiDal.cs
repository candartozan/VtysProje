using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VtysProje.Libary.DataAccess.Abstract;
using VtysProje.Libary.DataAccess.Entities.Concrete;

namespace VtysProje.Libary.DataAccess.Concrete
{
	public class SarkiDal : EntityRepositoryBase<Sarki, Context>, ISarkiDal
	{
	}
}
