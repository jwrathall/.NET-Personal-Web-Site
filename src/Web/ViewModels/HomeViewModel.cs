using System.Collections.Generic;
using Domain.Data.Respositories;
using Domain.Model;

namespace Web.ViewModels
{
    public class HomeViewModel
    {
        private readonly ISubjectRepository _subject;
        public ICollection<Subject> Subjects { get; set; }

        public HomeViewModel(ISubjectRepository subject)
        {
            _subject = subject;
            Subjects = _subject.GetAll();
        }
    }

}