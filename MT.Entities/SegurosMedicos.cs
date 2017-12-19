using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Entities
{
    public partial class SegurosMedicos: General.EntityBase
    {
        public SegurosMedicos()
        {
            GID = Guid.NewGuid();
        }

        public string Name { get; set; }
        public string Decription { get; set; }
        public string Type { get; set; }
        public string InsuranceCompany { get; set; }
    }
}
