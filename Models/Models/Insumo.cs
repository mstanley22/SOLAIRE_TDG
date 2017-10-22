using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Insumo: BaseModel
    {
        [Display(Name = "NombreInsumo", Prompt = "Nombre del Insumo")]
        public string Nombre { get; set; }
        [Display(Name = "UnidadMedida", Prompt = "Unidad de Medida")]
        public string UnidadMedida { get; set; }
        [Display(Name = "Descripcion", Prompt = "Descripcion")]
        public string Descripcion { get; set; }
        [Display(Name = "Marca", Prompt = "Marca")]
        public string Marca { get; set; }
        [Display(Name = "PrecioUnitario", Prompt = "PrecioUnitario")]
        public string PrecioUnitario { get; set; }

        public InsumoUtilizado InsumoUtilizado { get; set; }
        public int InsumoUtilizadoId { get; set; }
    }
}
