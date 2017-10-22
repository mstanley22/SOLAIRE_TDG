using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
   public class MaquinariaFabricante : BaseModel
    {
        [Display(Name = "NombreFabricante", Prompt = "Fabricante")]
        public string Nombre { get; set; }

        [Display(Name = "TelefonoFabricante", Prompt = "Telefono")]
        [Phone]
        public string Telefono { get; set; }

        [Display(Name = "EmailFabricante", Prompt = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Asistencia", Prompt = "Disponibilidad de Asistencia")]
        public string Asistencia { get; set; }
        
        ////Maquinaria 1:1
        //public Maquinaria Maquinaria { get; set; }
        //public int MaquinariaId { get; set; }
    }
}
