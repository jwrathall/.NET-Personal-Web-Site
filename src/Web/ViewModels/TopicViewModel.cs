using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Data.EF5.Repositories;
using Domain.Data.Respositories;
using Domain.Model;
using Domain.Services;


namespace Web.ViewModels
{
    public class TopicViewModel
    {
        private readonly ITopicRepository _topic;
        public ICollection<Topic> Topics { get; set; }

        public TopicViewModel(TopicRepository topicRepository)
        {
            _topic = topicRepository;
        }
        
        public TopicViewModel(ITopicRepository topicRepository, string id)
        {
            _topic = topicRepository;
            Topics = _topic.GetTopicById(Convert.ToInt32(id));
        }
    }
    public class ContactViewModel
    {

        public ContactViewModel() : this(null) { }
        public ContactViewModel(ContactInfo model)
        {
            UserRequest = model ?? new ContactInfo();
        }
        public ContactInfo UserRequest { get; set; }
    }
}
