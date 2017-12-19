using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Entities.General
{
    public class EntityBase
    {
        public Guid GID { get; set; }
        public bool IsActive { get; set; }
        public DateTime LogDate { get; set; }
        public int Indx { get; set; }
    }
}
