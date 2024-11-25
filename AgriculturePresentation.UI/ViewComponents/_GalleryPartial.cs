using AgriculturePresentation.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.UI.ViewComponents
{
    public class _GalleryPartial : ViewComponent
    {
        private readonly IImageService _imageService;
        public _GalleryPartial(IImageService imageService)
        {
            _imageService = imageService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _imageService.GetListAll();
            return View(values);
        }
    }
}
