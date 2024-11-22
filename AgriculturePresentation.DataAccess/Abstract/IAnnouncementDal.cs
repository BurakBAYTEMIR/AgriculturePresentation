using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.DataAccess.Abstract
{
    public interface IAnnouncementDal : IGenericDal<Announcement>
    {
        void AnnouncementStatusToTrue(int id);
        void AnnouncementStatusToFalse(int id);
    }
}