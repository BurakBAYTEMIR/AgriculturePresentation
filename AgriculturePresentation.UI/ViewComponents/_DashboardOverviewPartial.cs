using AgriculturePresentation.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgriculturePresentation.ViewComponents
{
    public class _DashboardOverviewPartial : ViewComponent
    {
        AgriculturePresentationContext context = new AgriculturePresentationContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.teamCount = context.Teams.Count();
            ViewBag.serviceCount = context.Services.Count();
            ViewBag.messageCount = context.Contacts.Count();
            ViewBag.currentMonthMessage = 3;

            ViewBag.announcementTrue = context.Announcements.Where(x => x.Status == true).Count();
            ViewBag.announcementFalse = context.Announcements.Where(x => x.Status == false).Count();

            ViewBag.urunPazarlama = context.Teams.Where(x => x.Title == "Ürün Pazarlama").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.bakliyatYonetimi = context.Teams.Where(x => x.Title == "Bakliyat Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.sutUretici = context.Teams.Where(x => x.Title == "Süt Üreticisi").Select(y => y.PersonName).FirstOrDefault();
            ViewBag.gubreYonetimi = context.Teams.Where(x => x.Title == "Gübre Yönetimi").Select(y => y.PersonName).FirstOrDefault();
            return View();
        }
    }
}
