using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAQSearch.Models
{
    public class SearchEntryFaqModel
    {
        public string SearchQuery { get; set; }
        public SearchEntryFaqModel(string str)
        {
            this.SearchQuery = str;
        }
    }
}