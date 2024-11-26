using AgriculturePresentation.Business.Abstract;
using AgriculturePresentation.Business.ValidationRules;
using AgriculturePresentation.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.UI.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.Insert(service);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.GetById(id);
            _serviceService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditService(int id)
        {
            var value = _serviceService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditService(Service service)
        {
            _serviceService.Update(service);
            return RedirectToAction("Index");
        }
    }
}
