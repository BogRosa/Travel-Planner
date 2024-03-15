using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface ISearchable
    {
        IEnumerable<SearchResult> Search(string criteria);
    }

    public class SearchResult
    {
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
