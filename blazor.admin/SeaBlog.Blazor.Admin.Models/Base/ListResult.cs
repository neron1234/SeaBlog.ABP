using System;
using System.Collections.Generic;
using System.Text;

namespace SeaBlog.Blazor.Admin.Models
{
    public class ListResult<T>
    {
        public ListResultModel<T> Result { get; set; }

        public object TargetUrl { get; set; }

        public bool Success { get; set; }

        public object Error { get; set; }

        public bool UnAuthorizedRequest { get; set; }

        public bool __abp { get; set; }
    }

    public class ListResultModel<T>
    {
        public int TotalCount { get; set; }

        public IList<T> Items { get; set; }
    }
}
