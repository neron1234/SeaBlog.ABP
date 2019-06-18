using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using SeaBlog.EntityBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.BlogEntitys
{
    public class Category : DeleteAndAuditedEntity<Guid>
    {
        public string Name { get; set; }

        public virtual List<BlogCategory> BlogCategories { get; set; }
    }
}
