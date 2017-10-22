using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Usuario : BaseModel
    {
        [ForeignKey("AspNetuser")] 
        public string UserId { get; set; }

        public ApplicationUser AspNetuser { get; set; }
        public Empleado Empleado { get; set; }

        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }
    }
}
