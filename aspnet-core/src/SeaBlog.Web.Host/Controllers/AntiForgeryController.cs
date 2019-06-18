using Microsoft.AspNetCore.Antiforgery;
using SeaBlog.Controllers;

namespace SeaBlog.Web.Host.Controllers
{
    public class AntiForgeryController : SeaBlogControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
