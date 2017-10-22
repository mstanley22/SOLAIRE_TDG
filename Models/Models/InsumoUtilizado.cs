using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class InsumoUtilizado : BaseModel
    {
        public InsumoUtilizado()
        {
            Insumos = new List<Insumo>();
            Mantenimientos = new List<Mantenimiento>();
        }
        [Display(Name = "Cantidad", Prompt = "Cantidad")]
        public string Cantidad { get; set; }
        public List<Insumo> Insumos { get; set; }
        public List<Mantenimiento> Mantenimientos { get; set; }
    }
}
