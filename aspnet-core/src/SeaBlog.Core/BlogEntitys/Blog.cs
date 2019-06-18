using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SeaBlog.Authorization.Users;
using SeaBlog.EntityBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SeaBlog.BlogEntitys
{
    public class Blog : DeleteAndAuditedEntity<Guid>
    {
        public string Slug { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Content { get; set; }

        public bool IsShow { get; set; }


        public virtual List<BlogCategory> BlogCategories { get; set; }

        public User CreatorUser { get; set; }
    }
}
