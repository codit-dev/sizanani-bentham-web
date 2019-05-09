using PagedList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace SizananiBentham.Models
{
    public class ArticleViewModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }
        public string ImageFilePath { get; set; }
        public string PublishDay { get; set; }
        public string PublishMonth { get; set; }
        public string PublishYear { get; set; } 
    }
}