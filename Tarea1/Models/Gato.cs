using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tarea1.Models
{
    public class Gato
    {
        #region Propiedades
        public String Nombre { get; set; }
        public String Raza { get; set; }
        public int Edad { get; set; }
        public String Color { get; set; }
        #endregion

        #region Contructor
        public Gato()
        {
           Nombre = "Kero";
           Raza = "Ruso azul";
           Edad = 5;
           Color = "Gris";

        }
        #endregion
    }
}