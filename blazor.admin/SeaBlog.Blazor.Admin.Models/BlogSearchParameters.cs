using SeaBlog.Blazor.Admin.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blazor.Admin.Models
{
    public class BlogSearchParameters : SearchParameters
    {
        public string CategoryId { get; set; }

        public bool? IsShow { get; set; }
    }
}
