using SeaBlog.Blazor.Admin.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api
{
    public class Config
    {
        public const string ApiUrl = "http://localhost:21021";

        public const int PageSize = 10;

        public static string BuildApiUrl(string api) => $"{ApiUrl}/{api.TrimEnd('/')}";

        public static string BuildApiUrlWithParams(string api, SearchParameters searchParameters)
        {
            var properties = searchParameters.GetType().GetProperties();
            return $"{BuildApiUrl(api)}?{string.Join("&", properties.Select(paramsBuilder))}";

            string paramsBuilder(PropertyInfo f)
            {
                if (f.Name == "PageIndex")
                    return $"SkipCount={(searchParameters.PageIndex - 1) * PageSize}&MaxResultCount={PageSize}";
                return $"{f.Name}={f.GetValue(searchParameters)}";
            }
        }
    }
}
