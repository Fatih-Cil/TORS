using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Equipment:BaseEntity<int>,IEntity
    {
        public string Name { get; set; }

        public ICollection<MeetingRoom> MeetingRooms { get; set; }
    }
}
