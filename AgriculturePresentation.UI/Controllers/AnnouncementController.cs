using System;
using AgriculturePresentation.Business.Abstract;
using AgriculturePresentation.Business.ValidationRules;
using AgriculturePresentation.Entities.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.UI.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _announcementService.GetListAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            AnnouncementValidator validationRules = new AnnouncementValidator();
            ValidationResult result = validationRules.Validate(announcement);
            if (result.IsValid)
            {
                announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
                announcement.Status = false;
                _announcementService.Insert(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            var value = _announcementService.GetById(id);
            _announcementService.Delete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditAnnouncement(int id)
        {
            var value = _announcementService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult EditAnnouncement(Announcement announcement)
        {
            AnnouncementValidator validationRules = new AnnouncementValidator();
            ValidationResult result = validationRules.Validate(announcement);
            if (result.IsValid)
            {
                _announcementService.Update(announcement);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult ChangeStatusToTrue(int id)
        {
            _announcementService.AnnouncementStatusToTrue(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusToFalse(int id)
        {
            _announcementService.AnnouncementStatusToFalse(id);
            return RedirectToAction("Index");
        }
    }
}
