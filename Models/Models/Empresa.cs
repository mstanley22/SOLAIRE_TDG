using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Empresa : BaseModel
    {
        public Empresa()
        {
            Departamentos = new List<Departamento>();
        }
        [Display(Name = "Nombre de la Empresa", Prompt = "Nombre de la Empresa")]
        public string Nombre { get; set; }
        public string Siglas { get; set; }
        public string Logo { get; set; }
        public string Direccion { get; set; }
        public List<Departamento> Departamentos { get; set; }
    }
}
