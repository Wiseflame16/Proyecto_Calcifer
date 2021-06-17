using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Peliculas.Models;

namespace Peliculas.Controllers
{
    public class CargoController : Controller
    {
        Inventario_PeliculasEntities entidad = new Inventario_PeliculasEntities();
        // GET: Cargo
        public ActionResult Index()
        {
            var listarcargos = entidad.cargo;
            return View(listarcargos.ToList());
        }
        public ActionResult ListaMaestraCargos()
        {
            var listarcargos = entidad.cargo;
            return View(listarcargos.ToList());
        }
        public ActionResult Usuario(String cargo)
        {
            var modelo = from p in entidad.usuario where p.cargo.nombre_cargo == cargo select p; 
            return View(modelo.ToList());
        }
        public ActionResult ListarUsuarioNombre()
        {
            var modelo = from p in entidad.usuario
                         join c in entidad.cargo
                         on p.id_cargo equals c.id_cargo
                         select new ElUsuario
                         {
                             id = p.id_usuario,
                             rut = p.rut_usuario,
                             nombre = p.nombres_usuario,
                             apellido = p.apellido_usuario,
                             telefono = p.telefono,
                             cargo = c.nombre_cargo
                         };

            return View(modelo.ToList());
        }
      
    }
}