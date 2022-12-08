using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.AnnouncementDtos;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Crm_UILayer.Controllers
{
    [AllowAnonymous]
    public class AnnouncementController : Controller
    {

        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService, IMapper mapper)
        {
            _announcementService = announcementService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddAnnouncement(AnnouncementAddDto p)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _announcementService.TInsert(new Announcement()
        //        {
        //            Title = p.Title,
        //            Publisher = p.Publisher,
        //            Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
        //        });
        //        return RedirectToAction("Index");
        //    }
        //    return View();
        //}


        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto p)
        {
            if (ModelState.IsValid)
            {
                var value = _mapper.Map<Announcement>(p);
                _announcementService.TInsert(value);
                
            }
            return View();
        }
    }
}
