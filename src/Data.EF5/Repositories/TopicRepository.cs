using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Data.Respositories;
using Domain.Model;

namespace Data.EF5.Repositories
{
    public class TopicRepository: BaseRepository<TadantechContext>, ITopicRepository
    {
        public ICollection<Topic> GetTopicById(int id)
        {
            using(DataContext)
            {
                return
                    DataContext
                        .Topics
                        .Where(t => t.SubjectId == id)
                        .ToList();
            }
        }
    }
}
