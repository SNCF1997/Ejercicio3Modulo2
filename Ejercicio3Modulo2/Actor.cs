using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase3Modulo2EFCore
{
    public class Actor
    {
        [Key] public int IdActor { get; set; }

        public string NombreActor { get; set; }
        public string ApellidoActor { get; set; }
        public string NomArtActor { get; set; }
        public int EdadActor { get; set; }
        public string NacionalidadActor { get; set; }
        public char GeneroActor { get; set; }
    }
}