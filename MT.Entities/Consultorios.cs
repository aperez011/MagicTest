using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Entities
{
    public partial class Consultorios: General.EntityBase
    {
        public Consultorios()
        {
            GID = Guid.NewGuid();
        }

        public Guid ClinicaID { get; set; }
        public string Number { get; set; }
        public int FloorNumber { get; set; }
    }
}
