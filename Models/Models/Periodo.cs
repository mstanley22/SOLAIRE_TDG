using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Periodo :BaseModel
    {
        [Display(Name = "FechaInicio", Prompt = "Fecha de Inicio")]
        public DateTime FechaInicio { get; set; }

        [Display(Name = "FechaFin", Prompt = "Fecha de Fin")]
        public DateTime FechaFin { get; set; }

        ////Bitacora 1:1
        //public Bitacora Bitacora { get; set; }
        //public int? BitacoraId { get; set; }
        ////Bitacora 1:1
        //public Plan Plan { get; set; }
        //public int? PlanId { get; set; }
    }
}
