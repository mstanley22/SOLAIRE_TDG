using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Area : BaseModel
    {
        public Area()
        {  
            Maquinarias = new List<Maquinaria>();
        }
        [Display(Name = "Nombre de Area", Prompt = "Nombre de Area")]
        public string Nombre { get; set; }

        public Departamento Departamento { get; set; }

        public int DeparatmentoId { get; set; }
 
        public List<Maquinaria> Maquinarias { get; set; }

        public Empleado Encargado { get; set; }

        [ForeignKey("Encargado")]
        public int? EncargadoId { get; set; }
    }
}
