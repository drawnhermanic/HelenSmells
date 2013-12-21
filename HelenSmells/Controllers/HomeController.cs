using System;
using System.Web.Mvc;
using Domain;
using Domain.ViewModels;

namespace HelenSmells.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHelper _helper;
        //
        // GET: /Home/

        public HomeController(IHelper helper)
        {
            _helper = helper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View(new HomeViewModel());
        }

        [HttpPost]
        public ActionResult Index(HomeViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }

            if (_helper.AreYouHelen(viewModel))
            {
                return RedirectToAction("Index", "Images");    
            }
            viewModel.Message = "You are not allowed to view this page. Go away!";
            return View(viewModel);
        }

    }
}
