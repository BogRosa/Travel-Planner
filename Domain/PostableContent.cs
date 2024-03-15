using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class PostableContent : ILikeable,ISearchable
    {
        public int ContentId { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PostDate { get; set; }

        protected PostableContent(int contentId, string title, string description, DateTime postDate)
        {
            ContentId = contentId;
            Title = title;
            Description = description;
            PostDate = postDate;
        }

        public IEnumerable<SearchResult> Search(string criteria)
        {
            throw new NotImplementedException();
        }

        public void Like(int userId)
        {
            throw new NotImplementedException();
        }

        public void Unlike(int userId)
        {
            throw new NotImplementedException();
        }

        public int GetLikesCount()
        {
            throw new NotImplementedException();
        }
    }
}
