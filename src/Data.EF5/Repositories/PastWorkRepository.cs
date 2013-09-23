using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Domain.Data.Respositories;
using Domain.Model;

namespace Data.EF5.Repositories
{
    public class PastWorkRepository : BaseRepository<TadantechContext>, IPastWorkRepository
    {
        public IQueryable<Site> GetSiteById(int id)
        {
            return
                DataContext
                    .Sites
                    .Include(n => n.Skills)
                    .Include(r => r.Roles)
                    .Include(i => i.Images)
                    .Where(s => s.Id == id);
        }

        public IQueryable<Site> GetAllSites()
        {
           return DataContext.Sites.Select(s => s);
        }
    }
}
