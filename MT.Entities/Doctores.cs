using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Entities
{
    public partial class Doctores: General.EntityBase
    {
        public Doctores()
        {
            GID = Guid.NewGuid();
        }
        public Guid ClinicaID { get; set; }
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }

    }
}
