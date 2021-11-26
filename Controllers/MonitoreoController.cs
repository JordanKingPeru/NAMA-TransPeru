using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Nama.Data;

namespace Nama.Controllers
{
    /**
     * Tasks Controller
     */
    public class MonitoreoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult transportepublico()
        {
            return View();
        }
        
        public IActionResult transportenomotorizado()
        {
            return View();
        }

        public IActionResult gasesefectoinvernadero()
        {
            return View();
        }
    }
}
