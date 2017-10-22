using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Mantenimiento :BaseModel
    {
        public Mantenimiento()
        {  
            Reprogramaciones = new List<Reprogramacion>();
        }
        [Display(Name = "TipoMantenimiento", Prompt = "Tipo de Mantenimiento")]
        public TipoMantenimiento TipoMantenimiento { get; set; }

        [Display(Name = "FechaInicioProgramada", Prompt = "Fecha de Inicio Programada")]
        public DateTime FechaInicioProgramada { get; set; }

        [Display(Name = "HoraInicioProgramada", Prompt = "Hora de Inicio Programada")]
        public DateTime HoraInicioProgramada { get; set; }

        [Display(Name = "FechaFinProgramada", Prompt = "Fecha de Finalizacion Programada")]
        public DateTime FechaFinProgramada { get; set; }

        [Display(Name = "HoraFinProgramada", Prompt = "Hora de Finalizacion Programada")]
        public DateTime HoraFinProgramada { get; set; }

        [Display(Name = "Estado", Prompt = "Estado")]
        public EstadoMantenimiento Estado { get; set; }

        [Display(Name = "Observaciones", Prompt = "Observaciones")]
        public string Observaciones { get; set; }

        public Empleado AprobadoPor { get; set; }

        [ForeignKey("AprobadoPor")]
        public int? AprobadoPorId { get; set; }

        public Bitacora Bitacora { get; set; }
        public int BitacoraId { get; set; }

        public Plan Plan { get; set; }
        public int PlanId { get; set; }

        public InsumoUtilizado InsumoUtilizado { get; set; }
        public int InsumoUtilizadoId { get; set; }

        public List<Reprogramacion> Reprogramaciones { get; set; }

    }
}
