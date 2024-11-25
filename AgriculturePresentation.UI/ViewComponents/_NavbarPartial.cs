using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.UI.ViewComponents
{
    public class _NavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
