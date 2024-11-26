using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.DataAccess.Concrete.Repository;
using AgriculturePresentation.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriculturePresentation.DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal : GenericRepository<Admin>,IAdminDal
    {
    }
}
