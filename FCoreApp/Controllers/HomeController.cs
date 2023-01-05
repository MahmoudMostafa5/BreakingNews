using FCoreApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewsContext context;

        public HomeController(ILogger<HomeController> logger ,NewsContext context)
        {
            _logger = logger;
            this.context = context;
        }

        public IActionResult Index()
        {
            var res = context.Categories.ToList();
            return View(res);
        }
        
        public IActionResult Messages()
        {
            var res = context.Contacts.ToList();
            return View(res);
        }

        public IActionResult TeamMembers()
        {
            var res = context.TeamMembers.ToList();
            return View(res);
        }

        //[Authorize]
        public IActionResult News(int id)
        {
            Category cat = context.Categories.Find(id);
            ViewBag.categ = cat.Name;
            var res = context.News.Where(x => x.CategoryId == id).OrderByDescending(x => x.Date).ToList();
            return View(res);
        }

        public IActionResult DeleteNews(int id)
        {
            var res = context.News.Find(id);
            context.News.Remove(res);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveContact(ContactUs model)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(model);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Contact", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
