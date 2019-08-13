using System.Web.Http;
using System.Web.Mvc;

using AspnetSignalR.Interfaces;
using AspnetSignalR.Repositories;

namespace AspnetSignalR.Controllers
{
    public class HomeController : Controller
    {
        private const string ArticleHeaderTemplate = "Writer: {0} - {1} Views";
        private const string ArticleTitle = "Article Title";

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "contact page.";

            return View();
        }

        public ActionResult Article()
        {
            ViewBag.Title = ArticleTitle;
            var writer = "Behzad Karim";
            var pageViewsCount = 127;
            ViewBag.Message = string.Format(ArticleHeaderTemplate, writer, pageViewsCount);

            return View();
        }

        [System.Web.Http.HttpPost]
        public string ArticleViewed(string articleId)
        {
            return articleId;
        }
    }
}