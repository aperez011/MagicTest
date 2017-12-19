using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Services.General
{
    public interface IBasicMethods<T> where T : class
    {

        List<T> GetAll();

        T GetBy(Guid gid);

        bool Save(List<T> entities);

    }
}
