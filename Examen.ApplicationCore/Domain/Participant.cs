using System;
using System.Collections.Generic;
using System.Text;

namespace CA.ApplicationCore.Domain
{
    public class Participant
    {
        public int ParticipantId { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string MailParticipant { get; set; }

        public virtual ICollection<Participation> Participations { get; set; }
    }
}
