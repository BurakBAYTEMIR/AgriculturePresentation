using AgriculturePresentation.Entities.Concrete;
using FluentValidation;

namespace AgriculturePresentation.Business.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Description).NotEmpty().WithMessage("Görsel açıklamasını boş geçemezsiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görsel başlığını boş geçemezsiniz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim yolunu boş geçemezsiniz");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter veri girişi yapın");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Lütfen 50 karakterden az veri girişi yapın");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Lütfen en az 8 karakter veri girişi yapın");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Lütfen 20 karakterden az veri girişi yapın");
        }
    }
}