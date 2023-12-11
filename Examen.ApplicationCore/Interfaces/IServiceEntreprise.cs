using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.ApplicationCore.Interfaces
{
  public  interface IServiceEntreprise : IService<Entreprise>
    {
        Entreprise PlusParticipants();
    }
}
