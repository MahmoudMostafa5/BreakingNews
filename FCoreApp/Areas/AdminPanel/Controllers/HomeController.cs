using FCoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCoreApp.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class HomeController : Controller
    {
        private readonly NewsContext context;

        public HomeController(NewsContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var TeamMemberCount = context.TeamMembers.Count();
            var NewsCount = context.News.Count();
            var ContactsCount = context.Contacts.Count();
            var CategoriesCount = context.Categories.Count();

            return View(new Admin
            {
                team = TeamMemberCount,
                news = NewsCount,
                contact = ContactsCount,
                categ = CategoriesCount
            });
        }
    }
    public class Admin
    {
        public int team { get; set; }
        public int news { get; set; }
        public int contact { get; set; }
        public int categ { get; set; }
    }
}
