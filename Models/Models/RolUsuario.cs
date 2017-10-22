using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class RolUsuario : IdentityRole
    {
        public RolUsuario()
        {
            OpcionesRol = new List<RolOpcion>();
        } 

        public List<RolOpcion> OpcionesRol { get; set; }


        public Empleado Empleado { get; set; }

        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }
    }
}
