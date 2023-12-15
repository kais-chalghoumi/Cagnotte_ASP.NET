using CA.ApplicationCore.Domain;
using CA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.ApplicationCore.Services
{
    public class ServiceParticipant : Service<Participant>, IServiceParticipant
    {
        public ServiceParticipant(IUnitOfWork utwk) : base(utwk)
        { }
        public int NbrCagnottes(int id)
        {
            return GetAll().Where(p => p.ParticipantId == id).Select(p => p.Participations).Count();
        }
    }
}
