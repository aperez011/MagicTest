using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Entities;

namespace MT.Services
{
    class ClinicaServices : General.IBasicMethods<Clinica>
    {
        public List<Clinica> GetAll()
        {
            throw new NotImplementedException();
        }

        public Clinica GetBy(Guid gid)
        {
            throw new NotImplementedException();
        }

        public bool Save(Clinica entity)
        {
            return this.Save(new List<Clinica>() { entity });
        }

        public bool Save(List<Clinica> entities)
        {
            throw new NotImplementedException();
        }
    }
}
