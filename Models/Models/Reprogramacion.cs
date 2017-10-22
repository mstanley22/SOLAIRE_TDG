using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
   public class Reprogramacion  : BaseModel
    {
        [Display(Name = "TipoMantenimiento", Prompt = "Tipo de Mantenimiento")]
        public TipoMantenimiento TipoMantenimiento { get; set; }

        [Display(Name = "FechaReprogramacion", Prompt = "Fecha de Reprogramacion")]
        public DateTime FechaReprogramacion { get; set; }

        [Display(Name = "HoraFinProgramada", Prompt = "Hora de Finalizacion Programada")]
        public DateTime HoraReprogramaciona { get; set; }

        [Display(Name = "Observaciones", Prompt = "Observaciones")]
        public string Observaciones { get; set; }

        public Mantenimiento Mantenimiento { get; set; }
        public int MantenimientoId { get; set; }

        public MotivoReprogramacion Motivo { get; set; }

        [ForeignKey("Motivo")]
        public int MotivoId { get; set; }

    }
}
