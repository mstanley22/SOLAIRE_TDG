using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Departamento :BaseModel
    {
        public Departamento()
        {
            Areas = new List<Area>();
            Empleados = new List<Empleado>();
        }
        public List<Empleado> Empleados { get; set; }
        [Display(Name = "Departamento", Prompt = "Departamento")]
        public string Nombre { get; set; }

        public List<Area> Areas { get; set; }
        public Empleado Encargado { get; set; }

        [ForeignKey("Encargado")]
        [Display(Name = "EncargadoDepartamento", Prompt = "Encargado del Departamento")]
        public int? EncargadoId { get; set; }

        public Empresa Empresa { get; set; }

        [Display(Name = "EmpresaId", Prompt = "Nombre de la Empresa")]
        public int EmpresaId { get; set; }
    }
}
