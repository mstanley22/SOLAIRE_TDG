using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class MenuOpcion :BaseModel
    {
        public string Nombre { get; set; }

        public string Controller { get; set; }

        public string Metodo { get; set; }

        public RolOpcion OpcionesRol { get; set; }
        public int OpcionesRolId { get; set; }
    }
}
