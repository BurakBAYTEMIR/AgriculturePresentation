using AgriculturePresentation.Entities.Concrete;
using FluentValidation;

namespace AgriculturePresentation.Business.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
        }
    }
}