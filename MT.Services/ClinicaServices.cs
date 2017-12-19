using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MT.Entities;
using MT.Data.dbModel;

namespace MT.Services
{
    public partial class ClinicaServices : General.IBasicMethods<Entities.Clinica>
    {

        #region [ Public Properties ]
        public static ClinicaServices Current { get { return new ClinicaServices(); } }
        #endregion

        #region [ Internal Properties ]
        internal dbCentroMedicoContainer _context;
        #endregion
        public ClinicaServices()
        {
        }


        public List<Entities.Clinica> GetAll()
        {
            _context = new dbCentroMedicoContainer();

            var cls = new List<Entities.Clinica>();

            foreach (var cli in _context.Clinicas.Select(c=>c).Take(100).OrderByDescending(cc=>cc.Indx))
            {
                cls.Add(new Entities.Clinica()
                {
                    GID = cli.GID,
                    IsActive = cli.IsActive,
                    LogDate = cli.LogDate,
                    Indx = cli.Indx,
                    Name = cli.Name,
                    PhoneNumber1 = cli.PhoneNumber1,
                    PhoneNumber2 = cli.PhoneNumber2,
                    Address = cli.Address
                });
            }

            return cls;
        }

        public Entities.Clinica GetBy(Guid gid)
        {
            throw new NotImplementedException();
        }

        public bool Save(Entities.Clinica entity)
        {
            return this.Save(new List<Entities.Clinica>() { entity });
        }

        public bool Save(List<Entities.Clinica> entities)
        {
            _context = new dbCentroMedicoContainer();

            List<Data.dbModel.Clinica> sClinicas = new List<Data.dbModel.Clinica>();
            try
            {
                foreach (var cli in entities)
                {
                    sClinicas.Add(new Data.dbModel.Clinica()
                    {
                        GID = cli.GID,
                        IsActive = cli.IsActive,
                        LogDate = cli.LogDate,
                        Name = cli.Name,
                        PhoneNumber1 = cli.PhoneNumber1,
                        PhoneNumber2 = cli.PhoneNumber2,
                        Address = cli.Address
                    });
                }

                _context.Clinicas.AddRange(sClinicas);

                _context.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }

        }
    }
}