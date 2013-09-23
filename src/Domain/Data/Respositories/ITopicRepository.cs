using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Model;

namespace Domain.Data.Respositories
{
    public interface ITopicRepository
    {
        ICollection<Topic> GetTopicById(int id);
    }
}
