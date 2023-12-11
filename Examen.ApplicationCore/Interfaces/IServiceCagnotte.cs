using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.ApplicationCore.Interfaces
{
 public interface IServiceCagnotte:IService<Cagnotte>
    {
        IEnumerable<Cagnotte> Encours();
        IEnumerable<Entreprise> Top2Entreprise(string Type);
        int Montant(int id);
    }
}
