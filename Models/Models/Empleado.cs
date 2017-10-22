using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Empleado : BaseModel
    {
       
        [Display(Name = "Nombres", Prompt = "Nombres")]
        public string Nombres { get; set; }

        [Display(Name = "Apellidos", Prompt = "Apellidos")]
        public string Apellidos { get; set; }

        [Display(Name = "DUI", Prompt = "DUI")]
        public string Dui { get; set; }

        [Display(Name = "TelefonoPrincipal", Prompt = "Telefono Principal")]
        [Phone]
        public string TelefonoPrincipal { get; set; }

        [Display(Name = "TelefonoSecundario", Prompt = "Telefono Secundario")]
        [Phone]
        public string TelefonoSecundario { get; set; }

        [Display(Name = "Especialidad", Prompt = "Especialidad")]
        public string Especialidad { get; set; }

        [Display(Name = "AreaExperiencia", Prompt = "Area de Experiencia")]
        public string AreaExperiencia { get; set; }

        [Display(Name = "Sexo", Prompt = "Sexo")]
        public Sexo Sexo { get; set; }

        [Display(Name = "Direccion", Prompt = "Direccion")]
        public string Direccion { get; set; }

        [Display(Name = "Salario", Prompt = "Salario")]
        public decimal Salario { get; set; }

        public string FullUserName
        {
            get
            {
                return Nombres + " " + Apellidos;
            }
        }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

        
        ////Area 1:1
        //public Area Area { get; set; }
        //public int? AreaId { get; set; }
        ////Mantenimiento 1:1
        //public Mantenimiento Mantenimiento { get; set; }
        //public int? MantenimientoId { get; set; } 
    }
}
