using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Model;

namespace Domain.Data.Respositories
{
    public interface IPastWorkRepository
    {
        IQueryable<Site> GetSiteById(int id);
        IQueryable<Site> GetAllSites();
    }
}
