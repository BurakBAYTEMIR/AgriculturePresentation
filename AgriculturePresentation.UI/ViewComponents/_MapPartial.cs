using AgriculturePresentation.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgriculturePresentation.UI.ViewComponents
{
    public class _MapPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            AgriculturePresentationContext context = new AgriculturePresentationContext();
            var values = context.Addresses.Select(x => x.Mapinfo).FirstOrDefault();
            ViewBag.Map = values;
            return View();
        }
    }
}
