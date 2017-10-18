using AowenPlatform.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace AowenPlatform.Web.Host.Controllers
{
    public class AntiForgeryController : AowenPlatformControllerBase
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