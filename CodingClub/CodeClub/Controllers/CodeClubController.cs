using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class CodeClubController : Controller
    {
        // 
        // GET: /CodeClub/
        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /CodeClub/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}