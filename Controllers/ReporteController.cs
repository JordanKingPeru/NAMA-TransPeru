using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nama.Data;
using Nama.Models;

namespace Nama.Controllers
{
    /**
     * Tasks Controller
     */
    public class ReporteController : Controller
    {
        private readonly AppDbContext dbContext;
        
        /**
         * ReporteController constructor.
         * @param dbCtx Application database context
         */
        public ReporteController(AppDbContext dbCtx)
        {
            this.dbContext = dbCtx;
        }

        public IActionResult Index()
        {
            string username = HttpContext.Session.GetString("username");
            User user = null;
            if(!string.IsNullOrWhiteSpace(username)){
                user = this.dbContext.Users.SingleOrDefault(user => user.Username == username);
                if (user == null)
                    return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult login()
        {
            string usernameSession = HttpContext.Session.GetString("username");
            string username = Request.Form["username"];
            string password = Request.Form["password"];
            if (!ModelState.IsValid||
                !string.IsNullOrWhiteSpace(usernameSession)||
                string.IsNullOrWhiteSpace(username)||
                string.IsNullOrWhiteSpace(password)){
                HttpContext.Session.SetString("message","Ingreso no válido"); 
                return RedirectToAction(nameof(Index));
            }
            User user = null;
            user = this.dbContext.Users.SingleOrDefault(user => user.Username == username);
            if (user == null){
                HttpContext.Session.SetString("message","Usuario no existe"); 
                return RedirectToAction(nameof(Index));
            }
            password = user.ComputeStringToSha256Hash(password);
            user = this.dbContext.Users.SingleOrDefault(user => user.Username == username && user.Password == password);
            if (user == null){
                HttpContext.Session.SetString("message","Credenciales no válidas"); 
                return RedirectToAction(nameof(Index));
            }
            HttpContext.Session.SetString("username",user.Username); 
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> guardaravance(IFormFile sustento)
        {
            string username = HttpContext.Session.GetString("username");
            if (string.IsNullOrWhiteSpace(username)){
                HttpContext.Session.SetString("message","Usuario no loguead"); 
                return RedirectToAction(nameof(Index));
            }
            User user = this.dbContext.Users.SingleOrDefault(user => user.Username == username);
            if (user == null){
                HttpContext.Session.SetString("message","Usuario no existe"); 
                return RedirectToAction(nameof(Index));
            }
            string actividad    = Request.Form["actividad"];
            string trimestre    = Request.Form["trimestre"];
            string description  = Request.Form["description"];
            if (string.IsNullOrWhiteSpace(actividad)||
                string.IsNullOrWhiteSpace(trimestre)||
                string.IsNullOrWhiteSpace(description)||
                sustento==null){
                HttpContext.Session.SetString("message","Los datos ingresados no son validos"); 
                return RedirectToAction(nameof(Index));
            }
            string filename     = trimestre + "_" + actividad+ "_" + user.Entidad + Path.GetExtension(sustento.FileName);
            string path = @"C:\Archivos\" + filename;
            using (Stream fileStream = new FileStream(path, FileMode.Create)) {
                sustento.CopyTo(fileStream);
            }

            Reporte reporte = new Reporte();
            reporte.actividad    = actividad;
            reporte.trimestre    = trimestre;
            reporte.description  = description ;
            reporte.entidad      = user.Entidad;
            reporte.username     = username;
            reporte.filename     = filename;
            this.dbContext.Add(reporte);
            await this.dbContext.SaveChangesAsync();

            HttpContext.Session.SetString("message","Guardado correctamente"); 
            HttpContext.Session.SetString("username","");
            return RedirectToAction(nameof(Index));

        }

    }
}
