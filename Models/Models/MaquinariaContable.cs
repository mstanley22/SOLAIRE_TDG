using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class MaquinariaContable : BaseModel
    {
        [Display(Name = "Precio", Prompt = "Precio")]
        public decimal Precio { get; set; }

        [Display(Name = "FechaCompra", Prompt = "Fecha de Compra")]
        public DateTime FechaCompra { get; set; }

        [Display(Name = "VidaPromedio", Prompt = "Vida Promedio")]
        public decimal VidaPromedio { get; set; }

        [Display(Name = "PeriodoGarantia", Prompt = "Tiempo de Garantia")]
        public decimal PeriodoGarantia { get; set; }

        ////Maquinaria 1:1
        //public Maquinaria Maquinaria { get; set; }
        //public int MaquinariaId { get; set; }
    }
}
