using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nama.Data;

namespace Nama.Controllers
{
    /**
     * Tasks Controller
     */
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
