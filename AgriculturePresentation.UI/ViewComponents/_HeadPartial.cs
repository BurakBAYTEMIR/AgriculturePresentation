using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.UI.ViewComponents
{
	public class _HeadPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}