using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Entities
{
    public partial class Pacientes: General.EntityBase
    {
        public Pacientes()
        {
            GID = Guid.NewGuid();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
        public string ContactNumber { get; set; }
        public Nullable<DateTime> DoB { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public Guid InsuranceID { get; set; }
    }
}
