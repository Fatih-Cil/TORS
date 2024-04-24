using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MeetingRoom:BaseEntity<int>,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public int MinParticipant { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
        
        public ICollection<Rule> Rules { get; set; }
        public ICollection<EquipmentMeetingRoom> EquipmentMeetingRooms { get; set; }
    }
}
