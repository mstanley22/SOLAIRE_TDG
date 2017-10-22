using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Plan :BaseModel
    {
        public Plan()
        {
            Mantenimientos = new List<Mantenimiento>();
        }  
        public DateTime FechaElaboracion { get; set; }
        public DateTime FechaAprobacion { get; set; }

        public List<Mantenimiento> Mantenimientos { get; set; }

        public Empleado ElaboradoPor { get; set; }

        [ForeignKey("ElaboradoPor")]
        public int? ElaboradoPorId { get; set; }

        public Empleado AprobadoPor { get; set; }

        [ForeignKey("AprobadoPor")]
        public int? AprobadoPorId { get; set; }

        public Periodo Periodo { get; set; }

        [ForeignKey("Periodo")]
        public int PeriodoId { get; set; }
    }
}
