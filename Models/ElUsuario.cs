﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Peliculas.Models
{
    public class ElUsuario
    {
        public int id { get; set; }
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string telefono { get; set; }
        public string cargo { get; set; }


    }
}