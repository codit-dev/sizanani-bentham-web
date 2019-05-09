using PagedList;
using SizananiBentham.DataAccessLayer;
using SizananiBentham.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SizananiBentham.Controllers
{
    public class NewsController : Controller
    {

        private UnitOfWork unitOfWork;

        public NewsController()
        {
            unitOfWork = new UnitOfWork(new ApplicationDbContext());
        }

        // GET: Article
        public ActionResult Article(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ArticleViewModel fullArticle = new ArticleViewModel();
            var article = unitOfWork.Articles.GetByGuid((Guid)id);

            if (article == null)
            {
                return HttpNotFound();
            }

            fullArticle.Id = article.Id;
            fullArticle.Title = article.Title;
            fullArticle.Author = article.Author;
            fullArticle.Body = article.Body;
            fullArticle.PublishDay = article.PublishDate.Day.ToString();
            fullArticle.PublishMonth = article.PublishDate.ToString("MMMM");
            fullArticle.PublishYear = article.PublishDate.ToString("yyyy");
            fullArticle.ImageFilePath = article.ImageFilePath;

            return View(fullArticle);
        }

        // GET: Articles
        public ActionResult Articles(string currentFilter, string searchString, int? page)
        {
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);

            List<ArticleViewModel> articles = new List<ArticleViewModel>();

            foreach (var article in unitOfWork.Articles.GetAll())
            {
                articles.Add(new ArticleViewModel()
                {
                    Id = article.Id,
                    Title = article.Title,
                    Author = article.Author,
                    Body = article.Body,
                    PublishDay = article.PublishDate.Day.ToString(),
                    PublishMonth = article.PublishDate.ToString("MMMM"),
                    PublishYear = article.PublishDate.ToString("yyyy"),
                    ImageFilePath = article.ImageFilePath
                    
                });
            }

            return View(articles.ToPagedList(pageNumber, pageSize));
        }
    }
}

