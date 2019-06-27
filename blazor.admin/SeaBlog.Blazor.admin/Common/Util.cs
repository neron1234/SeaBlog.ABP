using SeaBlog.Blazor.Admin.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Common
{
    public static class Util
    {
        public static int GetPageCount(int recordCount)
        {
            var result = recordCount / Config.PageSize;
            if (recordCount % Config.PageSize > 0)
                return result + 1;
            else
                return result;
        }
    }
}
