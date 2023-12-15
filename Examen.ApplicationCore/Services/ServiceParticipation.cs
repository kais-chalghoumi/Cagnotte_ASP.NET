using CA.ApplicationCore.Domain;
using CA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.ApplicationCore.Services
{
    public class ServiceParticipation : Service<Participation>, IServiceParticipation
    {
        public ServiceParticipation(IUnitOfWork utwk) : base(utwk)
        { }

        public int Montant(int id)
        {
            var req = GetAll().Where(p => p.CagnotteFk == id);
            int m = 0;
            foreach (var item in req)
            {
                m = m + item.Montant;
            }
            return m;
        }
    }
}
