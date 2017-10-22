using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Maquinaria : BaseModel
    {
        [Display(Name = "Codigo", Prompt = "Codigo")]
        public string Codigo { get; set; }

        [Display(Name = "Nombre", Prompt = "Nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Marca", Prompt = "Marca")]
        public string Marca { get; set; }

        [Display(Name = "Modelo", Prompt = "Modelo")]
        public string Modelo { get; set; }

        [Display(Name = "Serie", Prompt = "Serie")]
        public string Serie { get; set; }

        [Display(Name = "Matricula", Prompt = "Matricula")]
        public string Matricula { get; set; }

        [Display(Name = "NombreTroquel", Prompt = "Nombre de Troquel")]
        public string NombreTroquel { get; set; }

        [Display(Name = "TipoMaquina", Prompt = "Tipo de Maquina")]
        public TipoMaquina TipoMaquina { get; set; }

        public Area Area { get; set; }
        public int AreaId { get; set; }

        public MaquinariaFabricante MaquinariaFabricante { get; set; }

        [ForeignKey("MaquinariaFabricante")]
        public int MaquinariaFabricanteId { get; set; }

        public MaquinariaEspecificacion MaquinariaEspecificacion { get; set; }

        [ForeignKey("MaquinariaEspecificacion")]
        public int MaquinariaEspecificacionId { get; set; }

        public MaquinariaContable MaquinariaContable { get; set; }

        [ForeignKey("MaquinariaContable")]
        public int MaquinariaContableId { get; set; }

        ////Bitacora 1:1
        //public Bitacora Bitacora { get; set; }
        //public int BitacoraId { get; set; }
    }
}
