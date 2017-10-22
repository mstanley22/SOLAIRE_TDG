using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Bitacora :BaseModel
    {
        public Bitacora()
        {
            Mantenimientos = new List<Mantenimiento>();
        }  
        public List<Mantenimiento> Mantenimientos { get; set; }
        public Maquinaria Maquinaria { get; set; }

        [ForeignKey("Maquinaria")]
        public int MaquinariaId { get; set; }

        //public Periodo Periodo { get; set; }
        //[ForeignKey("Periodo")]
        //public int PeriodoId { get; set; }
    }
}
