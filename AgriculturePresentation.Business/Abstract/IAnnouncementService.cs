using AgriculturePresentation.Entities.Concrete;

namespace AgriculturePresentation.Business.Abstract
{
    public interface IAnnouncementService : IGenericService<Announcement>
    {
        void AnnouncementStatusToTrue(int id);
        void AnnouncementStatusToFalse(int id);
    }
}