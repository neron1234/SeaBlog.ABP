using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.BlogEntitys
{
    public class BlogCategory
    {
        public Guid BlogID { get; set; }

        public Blog Blog { get; set; }

        public Guid CategoryID { get; set; }

        public Category Category { get; set; }
    }
}
