using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Crm_UILayer.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto p)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TInsert(new Announcement()
                {
                    Title = p.Title,
                    Publisher = p.Publisher,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
