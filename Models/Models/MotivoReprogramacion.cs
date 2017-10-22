using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class MotivoReprogramacion : BaseModel
    {
        [Display(Name = "Nombre", Prompt = "Motivo")]
        public string Nombre { get; set; }

        [Display(Name = "Codigo", Prompt = "Codigo")]
        public string Codigo { get; set; }

        [Display(Name = "Descripcion", Prompt = "Descripcion")]
        public string Descripcion { get; set; }

        ////Reprogramacion 1:1
        //public Reprogramacion Reprogramacion { get; set; }
        //public int ReprogramacionId { get; set; }
    }
}
