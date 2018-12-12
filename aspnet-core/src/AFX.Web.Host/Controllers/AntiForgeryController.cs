using Microsoft.AspNetCore.Antiforgery;
using AFX.Controllers;

namespace AFX.Web.Host.Controllers
{
    public class AntiForgeryController : AFXControllerBase
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
