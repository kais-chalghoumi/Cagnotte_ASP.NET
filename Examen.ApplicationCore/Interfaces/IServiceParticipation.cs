using CA.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA.ApplicationCore.Interfaces
{
    public interface IServiceParticipation : IService<Participation>
    {
        int Montant(int id);
    }
}
