using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BlogApp.Areas.Admin.ViewModels;
using BlogApp.Infrastructure;
using BlogApp.Models;
using NHibernate.Linq;

namespace BlogApp.Areas.Admin.Controllers
{
    [Authorize (Roles = "admin" )]
    [SelectedTab("users")]
    public class UsersController : Controller
    {
        // GET: Admin/Users
        public ActionResult Index()
        {
            return View(new UsersIndex()
            {
                Users = Database.Session.Query<User>().ToList()
            });
        }
    }
}