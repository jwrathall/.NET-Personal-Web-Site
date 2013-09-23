using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.Data.Respositories;
using Domain.Model;

namespace Data.EF5.Repositories
{
    public class SubjectRepository : BaseRepository<TadantechContext>, ISubjectRepository
    {
        public ICollection<Subject> GetAll()
        {
            using (DataContext)
            {
                return  DataContext
                    .Subjects
                    .Select(n => n)
                    .Include(t=>t.Topics)
                    .OrderBy(s => s.OrderBy)
                    .ToList();
            }
        }
        public Subject GetOne(int id)
        {
            return DataContext
                .Subjects
                .FirstOrDefault(n => n.Id == id);
        }

    }
}
