using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EquipmentMeetingRoom :BaseEntity<int>, IEntity
    {
        public int EquipmentId { get; set; }
        public int MeetingRoomId { get; set; }

        public MeetingRoom MeetingRoom { get; set; }
        public Equipment Equipment { get; set; }
    }
}
