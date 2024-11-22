using System.Collections.Generic;
using AgriculturePresentation.Business.Abstract;
using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Insert(Contact t)
        {
            _contactDal.Insert(t);
        }

        public void Delete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public void Update(Contact t)
        {
            throw new System.NotImplementedException();
        }

        public Contact GetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> GetListAll()
        {
            return _contactDal.GetListAll();
        }
    }
}