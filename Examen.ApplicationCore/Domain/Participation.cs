using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CA.ApplicationCore.Domain
{
    public class Participation
    {
        public int Montant { get; set; }

        public int ParticipantFk { get; set; }

        public int CagnotteFk { get; set; }

        [ForeignKey("ParticipantFk")]
        public virtual Participant Participant { get; set; }

        [ForeignKey("CagnotteFk")]
        public virtual Cagnotte Cagnotte { get; set; }
    }
}
