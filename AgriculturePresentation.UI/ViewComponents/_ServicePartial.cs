﻿using AgriculturePresentation.Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.UI.ViewComponents
{
    public class _ServicePartial : ViewComponent
    {
        private readonly IServiceService _serviceService;

        public _ServicePartial(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _serviceService.GetListAll();
            return View(values);
        }
    }
}
