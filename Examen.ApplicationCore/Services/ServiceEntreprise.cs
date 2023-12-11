using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen.ApplicationCore.Services
{
    public class ServiceEntreprise : Service<Entreprise>, IServiceEntreprise
    {
        public ServiceEntreprise(IUnitOfWork utwk) : base(utwk)
        {

        }

        //Service5
        public Entreprise PlusParticipants()
        {
            var x = utwk.Repository<Cagnotte>().GetAll().OrderBy((e => e.Participantions.Count())).First();

            return x.Entreprise;
        }


    }
}
