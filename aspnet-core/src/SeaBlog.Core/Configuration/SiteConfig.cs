using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Configuration
{
    public class SiteConfig
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string UserName { get; set; }
        public string UserInfo { get; set; }
        public string GitHub { get; set; }
        public string About { get; set; }
        public int PageSize { get; set; }
    }
}
