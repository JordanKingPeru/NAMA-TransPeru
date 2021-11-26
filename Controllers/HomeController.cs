using System;
using System.Xml;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using System.Collections.Generic;

using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using Nama.Models;

namespace Nama.Controllers
{
    /**
     * Home Controller
     */
    public class HomeController : Controller
    {

        // GET /Home/Error
        public IActionResult Error()
        {
            ErrorViewModel model = new ErrorViewModel
            {
                RequestId = (Activity.Current?.Id ?? HttpContext.TraceIdentifier)
            };

            return View(model);
        }

        private List<Models.Noticia> getListaNoticias(String URLString, String type){
            List<Models.Noticia> noticias = new List<Models.Noticia>();
            XmlTextReader reader = new XmlTextReader (URLString);
            while (reader.Read())
            {   
                if (reader.Name.Equals("item") && (reader.NodeType == XmlNodeType.Element))
                {  
                    
                    Models.Noticia noticia = new Models.Noticia();
                    XmlReader r = reader.ReadSubtree();
                    while (r.Read())
                    {
                        if ((r.NodeType == XmlNodeType.Element || r.NodeType == XmlNodeType.Text) && (r.Name!=string.Empty))
                        {
                            switch (r.Name)
                            {
                                case "title":
                                    while(r.Read() && r.Value == string.Empty);
                                    noticia.title = r.Value;
                                    break;
                                case "description":
                                    while(r.Read() && r.Value == string.Empty);
                                    noticia.description = r.Value;
                                    break;
                                case "image":
                                    while(r.Read() && r.Value == string.Empty);
                                    noticia.image = r.Value;
                                    break;
                                case "link":
                                    while(r.Read() && r.Value == string.Empty);
                                    noticia.url = r.Value;
                                    break;
                            }
                        }
                    }
                    noticia.tipo = type;
                    noticias.Add(noticia);
                }
            }
            return noticias;
        }
        
        // GET [ /, /Home/, /Home/Index ]
        public IActionResult Index()
        {
            //List<Models.Noticia> noticias = getListaNoticias("https://www.gob.pe/busquedas.rss?contenido[]=noticias&institucion[]=mtc&sheet=1&sort_by=recent&term=TRANSPer%C3%BA","noticia");
            //noticias.AddRange(getListaNoticias("https://www.gob.pe/busquedas.rss?contenido[]=publicaciones&institucion[]=mtc&sheet=1&sort_by=recent&term=GEI","publicacion"));
            List<Models.Noticia> noticias = new List<Models.Noticia>();
            return View(noticias);
        }
        
        public IActionResult logout()
        {
            HttpContext.Session.SetString("username","");
            //List<Models.Noticia> noticias = getListaNoticias("https://www.gob.pe/busquedas.rss?contenido[]=noticias&institucion[]=mtc&sheet=1&sort_by=recent&term=TRANSPer%C3%BA","noticia");
            //noticias.AddRange(getListaNoticias("https://www.gob.pe/busquedas.rss?contenido[]=publicaciones&institucion[]=mtc&sheet=1&sort_by=recent&term=GEI","publicacion"));
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }

    }
}
