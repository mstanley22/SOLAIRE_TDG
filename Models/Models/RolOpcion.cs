using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class RolOpcion : BaseModel
    {
        public RolOpcion()
        {
            OpcionesMenu = new List<MenuOpcion>();
        }

        public bool Habilitado { get; set; }

        public RolUsuario Rol { get; set; }
        public string RolId { get; set; }

        public List<MenuOpcion> OpcionesMenu { get; set; }

    }
}
