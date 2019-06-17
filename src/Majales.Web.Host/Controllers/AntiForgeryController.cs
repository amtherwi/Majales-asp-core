using Microsoft.AspNetCore.Antiforgery;
using Majales.Controllers;

namespace Majales.Web.Host.Controllers
{
    public class AntiForgeryController : MajalesControllerBase
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
