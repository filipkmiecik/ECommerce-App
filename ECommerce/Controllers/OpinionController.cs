using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerce.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace ECommerce.Controllers
{
    [Authorize]
    public class OpinionController : Controller
    {
        private readonly IOpinionRepository _opinionRepository;

        public OpinionController(IOpinionRepository opinion)
        {
            _opinionRepository = opinion;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                _opinionRepository.addOpinion(opinion);
                return RedirectToAction("OpinionSend");
            }
            else
            {
                return View(opinion);
            }
        }

        public IActionResult OpinionSend()
        {
            return View();
        }
    }
}