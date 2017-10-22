using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Notificacion  : BaseModel
    {
        public DateTime FechaEnvio { get; set; }
        public DateTime FechaLectura { get; set; }
        public TipoNotificacion TipoNotificacion { get; set; }
    }
}
