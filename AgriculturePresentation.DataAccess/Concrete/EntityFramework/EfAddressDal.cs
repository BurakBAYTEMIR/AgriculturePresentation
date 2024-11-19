using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.DataAccess.Concrete.Repository;
using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.DataAccess.Concrete.EntityFramework
{
    public class EfAddressDal : GenericRepository<Address>, IAddressDal
    {
    }
}