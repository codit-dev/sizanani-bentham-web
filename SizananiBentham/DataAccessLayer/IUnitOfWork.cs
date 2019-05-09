using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SizananiBentham.DataAccessLayer.IRepositories;

namespace SizananiBentham.DataAccessLayer
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository Articles { get; }

        int SaveChanges();
    }
}
