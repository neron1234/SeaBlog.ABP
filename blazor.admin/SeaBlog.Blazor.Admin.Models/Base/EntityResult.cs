using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blazor.Admin.Models
{
    public class EntityResult<T>
    {
        public T Result { get; set; }

        public object TargetUrl { get; set; }

        public bool Success { get; set; }

        public object Error { get; set; }

        public bool UnAuthorizedRequest { get; set; }

        public bool __abp { get; set; }
    }
}
