using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blazor.Admin.Models
{
    public class BlogDetail
    {
        public string Id { get; set; }

        public DateTime CreationTime { get; set; }

        public string Slug { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }

        public string HtmlContent { get; set; }

        public bool IsShow { get; set; }

        public virtual List<BlogCategory> BlogCategories { get; set; }
    }
}
