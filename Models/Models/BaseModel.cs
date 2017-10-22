using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseModel
    {

        public BaseModel()
        {
            LastUpdate = DateTime.Now;

        }

        [Key]
        public int Id { get; set; }
        public DateTime LastUpdate { get; set; }
        public Guid ModifiedBy { get; set; }
    }
}
