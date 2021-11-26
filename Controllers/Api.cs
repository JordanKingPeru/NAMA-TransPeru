using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nama.Data;

namespace Nama.Controllers
{
    [Produces("application/json")]
    public class ApiController : Controller
    {
        private readonly AppDbContext dbContext;

        /**
         * ApiController constructor.
         * @param dbCtx Application database context
         */
        public ApiController(AppDbContext dbCtx)
        {
            this.dbContext = dbCtx;
        }

        [HttpGet]
        public JsonResult avances(string componente, string actividad,string medioTransporte,string ubicacion,string provincia)
        {  
            return Json(from avance in this.dbContext.Avances
                                           .Where(avance => (avance.Componente==componente||string.IsNullOrWhiteSpace(componente))&&(avance.Actividad==actividad||avance.Actividad=="Todos"||string.IsNullOrWhiteSpace(actividad))
                                                            &&(avance.MedioTransporte==medioTransporte||string.IsNullOrWhiteSpace(medioTransporte))
                                                            &&(avance.Ubicacion==ubicacion||string.IsNullOrWhiteSpace(ubicacion))&&(avance.Provincia==provincia||string.IsNullOrWhiteSpace(provincia)))
                                           .GroupBy(avance => new {avance.Anio, avance.Trimestre, avance.Indicador})
                                           .Select(avance  => new{Key= avance.Key, Gei= avance.Sum(e => e.Gei)})
                                           .OrderBy(avance => avance.Key.Indicador + avance.Key.Anio + avance.Key.Trimestre)
                        select avance);
        }

        [HttpGet]
        public JsonResult actividades(string componente)
        {  
            return Json(from avance in this.dbContext.Avances
                                           .Where(avance => (avance.Componente==componente||string.IsNullOrWhiteSpace(componente)))
                                           .GroupBy(avance => new {avance.Actividad})
                                           .Select(avance  => new{Key= avance.Key})
                                           .OrderBy(avance => avance.Key.Actividad)
                        select avance);
        }

        [HttpGet]
        public JsonResult totales()
        {  
            return Json(from avance in this.dbContext.Avances
                                           .GroupBy(avance => new {avance.Anio, avance.Trimestre, avance.Indicador})
                                           .Select(avance  => new{Key= avance.Key, Gei= avance.Sum(e => e.Gei)})
                                           .OrderBy(avance => avance.Key.Indicador + avance.Key.Anio + avance.Key.Trimestre)
                        select avance);
        }
    }
}