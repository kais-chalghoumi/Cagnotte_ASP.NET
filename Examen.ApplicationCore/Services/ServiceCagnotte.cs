using CA.ApplicationCore.Domain;
using CA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CA.ApplicationCore.Services
{
    public class ServiceCagnotte : Service<Cagnotte>, IServiceCagnotte
    {
        public ServiceCagnotte(IUnitOfWork utwk) : base(utwk)
        { }

        public IEnumerable<Cagnotte> Encours()
        {
            return GetAll().Where(c => c.DateLimite.CompareTo(DateTime.Now) > 0);
        }

        public IEnumerable<Entreprise> Top2Entreprise(string Type)
        {
            var linq = (from c in GetMany(c => c.Type.ToString() == Type)
                        orderby c.EntrepriseId
                        select c.EntrepriseId).Take(2);
            return (IEnumerable<Entreprise>)linq;
        }

        public Entreprise PlusParticipants()
        {
            var x = GetAll().OrderBy((e => e.Participantions.Count())).First();

            return x.Entreprise;
        }
    }
}
