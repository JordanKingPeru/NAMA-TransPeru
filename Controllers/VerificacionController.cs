using System.IO;
using System.Linq;
using System.IO.Compression;
using System.Threading.Tasks;
using System.Data.OracleClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Nama.Data;
using Nama.Models;
namespace Nama.Controllers
{
    /**
     * Tasks Controller
     */
    public class VerificacionController : Controller
    {
        private readonly AppDbContext dbContext;
        
        /**
         * ReporteController constructor.
         * @param dbCtx Application database context
         */
        public VerificacionController(AppDbContext dbCtx)
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
        public FileStreamResult descargaavance(string trimestre,string entidad)
        {       
            var reportes = this.dbContext.Reportes
                               .Where(reporte => (reporte.trimestre==trimestre||string.IsNullOrWhiteSpace(trimestre))&&(reporte.entidad==entidad||string.IsNullOrWhiteSpace(entidad))).ToList()
                               .GroupBy(reporte => new {reporte.trimestre, reporte.entidad, reporte.actividad})
                               .Select(reporte  => reporte.OrderByDescending(e => e.Date).First());
                               
            MemoryStream memoryStream = new MemoryStream();
            using (var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create, true)) {
                foreach(var reporte in reportes) {
                    var demoFile = archive.CreateEntry(reporte.filename);
                    using(var content = new FileStream(@"C:\Archivos\"+reporte.filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                    using(var entryStream = demoFile.Open())
                        content.CopyTo(entryStream);
                }
                var fileLog = archive.CreateEntry("registros.csv");
                using(var entryStream = fileLog.Open())
                using (StreamWriter streamWriter = new StreamWriter(entryStream)) {
                    streamWriter.WriteLine("Actividad;Trimestre;Entidad;Descripcion;Usuario;Archivo");
                    foreach(var reporte in reportes) {
                        streamWriter.WriteLine(reporte.actividad+";"+reporte.trimestre+";"+reporte.entidad+";"+reporte.description+";"+reporte.username+";"+reporte.filename);
                    }
                }
            }
            memoryStream.Seek(0, SeekOrigin.Begin);
            FileStreamResult response = File(memoryStream, "application/octet-stream","sustentos.zip");
            return response;
        }
    }
}
