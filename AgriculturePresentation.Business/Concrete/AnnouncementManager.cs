using System.Collections.Generic;
using AgriculturePresentation.Business.Abstract;
using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        private readonly IAnnouncementDal _announcementDal;

        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }

        public void Insert(Announcement t)
        {
            _announcementDal.Insert(t);
        }

        public void Delete(Announcement t)
        {
            _announcementDal.Delete(t);
        }

        public void Update(Announcement t)
        {
            _announcementDal.Update(t);
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(id);
        }

        public List<Announcement> GetListAll()
        {
            return _announcementDal.GetListAll();
        }

        public void AnnouncementStatusToTrue(int id)
        {
            _announcementDal.AnnouncementStatusToTrue(id);
        }

        public void AnnouncementStatusToFalse(int id)
        {
            _announcementDal.AnnouncementStatusToFalse(id);
        }
    }
}