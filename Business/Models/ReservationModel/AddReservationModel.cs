using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.ReservationModel
{
    public class AddReservationModel
    {
        public DateTime StartDateTime { get; set; }
        public DateTime FinishDateTime { get; set; }
        public int  Turnout { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public int UserId { get; set; }
        public int MeetingRoomId { get; set; }


    }
}
