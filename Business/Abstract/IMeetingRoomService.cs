using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMeetingRoomService
    {
        List<MeetingRoom> GetAll();
        MeetingRoom GetById(int id);
        void AddMeetingRoom(MeetingRoom meetingRoom);
        void RemoveMeetingRoom(MeetingRoom meetingRoom);
        void UpdateMeetingRoom(MeetingRoom meetingRoom);
    }
}
