using CA.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.ApplicationCore.Interfaces
{
    public interface IServiceCagnotte : IService<Cagnotte>
    {
        IEnumerable<Cagnotte> Encours();
        IEnumerable<Entreprise> Top2Entreprise(string Type);
        Entreprise PlusParticipants();
    }
}
