using System.Linq;
using System.Web.Mvc;
using BlogApp.Areas.Admin.ViewModels;
using BlogApp.Infrastructure;
using BlogApp.Models;
using NHibernate.Linq;

namespace BlogApp.Controllers
{
    
    public class PostsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}