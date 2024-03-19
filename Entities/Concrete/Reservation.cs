﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Reservation:BaseEntity<int>,IEntity
    {
        public int UserId { get; set; }
        public int MeetingRoomId { get; set; }
        public int Turnout { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }

        public User User{ get; set; }
        public MeetingRoom MeetingRoom { get; set; }

    }
}
