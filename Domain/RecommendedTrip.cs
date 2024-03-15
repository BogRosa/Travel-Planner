using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class RecommendedTrip : ISearchable, ILikeable
    {
        public int RecommendedTripId { get; set; }
        public string Title { get; set; }
        public string Destination { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        public int GetLikesCount()
        {
            throw new NotImplementedException();
        }

        public void Like(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SearchResult> Search(string criteria)
        {
            throw new NotImplementedException();
        }

        public void Unlike(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
