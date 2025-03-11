using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using ProjeCore.Models;
using System.Security.Claims;

namespace ProjeCore.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        [HttpGet]
        public IActionResult GirisYap()
        {
            return View();
        }
        
        public async Task<IActionResult> GirisYap(Admin p)
        {
            var bilgiler = c.Admins.FirstOrDefault(x => x.Kullanici == p.Kullanici && x.Sifre == p.Sifre);
            if (bilgiler != null)
            {
                //islemler
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,p.Kullanici)
                };
                var useridenty = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridenty);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Personelim");

            }
            return View();
        }
    }
}
