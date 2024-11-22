using AgriculturePresentation.DataAccess.Abstract;
using AgriculturePresentation.DataAccess.Concrete.Repository;
using AgriculturePresentation.DataAccess.Contexts;
using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.DataAccess.Concrete.EntityFramework
{
    public class EfAnnouncementDal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void AnnouncementStatusToTrue(int id)
        {
            using var context = new AgriculturePresentationContext();
            Announcement announcement = context.Announcements.Find(id);
            announcement.Status = true;
            context.SaveChanges();
        }

        public void AnnouncementStatusToFalse(int id)
        {
            using var context = new AgriculturePresentationContext();
            Announcement announcement = context.Announcements.Find(id);
            announcement.Status = false;
            context.SaveChanges();
        }
    }
}