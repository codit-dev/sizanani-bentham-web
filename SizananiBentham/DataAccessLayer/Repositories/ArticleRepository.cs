using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SizananiBentham.DataAccessLayer.IRepositories;
using SizananiBentham.Models;

namespace SizananiBentham.DataAccessLayer.Repositories
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(ApplicationDbContext context)
            : base(context)
        {
        }

        

        public ApplicationDbContext ApplicationDbContext
        {
            get { return Context as ApplicationDbContext; }
        }
    }

}