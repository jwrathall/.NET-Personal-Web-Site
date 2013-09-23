using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Model;

namespace Domain.Data.Respositories
{
    public interface IContactInfoRespository
    {
        void Add<T>(T entity) where T : class;
        void SaveChanges();
    }
}
