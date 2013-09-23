using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Data.Respositories;
using Domain.Model;

namespace Data.EF5.Repositories
{
    public class SocialRepository: BaseRepository<TadantechContext>, ISocialRepository
    {
        public IQueryable<Social> GetSocialLinks()
        {
            return
                DataContext
                .SocialLinks
                .Select(s => s);
        }
    }
}
