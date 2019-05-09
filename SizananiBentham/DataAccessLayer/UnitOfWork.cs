using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SizananiBentham.DataAccessLayer.IRepositories;
using SizananiBentham.DataAccessLayer.Repositories;
using SizananiBentham.Models;

namespace SizananiBentham.DataAccessLayer
{
    public class UnitOfWork :IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Articles = new ArticleRepository(_context);
        }

        public IArticleRepository Articles { get; private set; }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}