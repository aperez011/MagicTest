using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Entities
{
    public partial class Clinica : General.EntityBase
    {
        public Clinica()
        {
            GID = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
    }
}
