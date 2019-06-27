using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blazor.Admin.Models.Base
{
    public class SearchParameters
    {
        public int PageIndex { get; set; }

        public string KeyWord { get; set; }
    }
}
