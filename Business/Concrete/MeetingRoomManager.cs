using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MeetingRoomManager : IMeetingRoomService
    {

        IMeetingRoomDal _meetingRoomDal;
        public MeetingRoomManager(IMeetingRoomDal meetingRoomDal)
        {
           _meetingRoomDal = meetingRoomDal;
        }

        public void AddMeetingRoom(MeetingRoom meetingRoom)
        {
            _meetingRoomDal.Add(meetingRoom);
        }

        public List<MeetingRoom> GetAll()
        {
            return _meetingRoomDal.GetAll();
        }

        public MeetingRoom GetById(int id)
        {
            return _meetingRoomDal.Get(x=> x.Id == id);
        }

        public void RemoveMeetingRoom(MeetingRoom meetingRoom)
        {
            _meetingRoomDal.Delete(meetingRoom);
        }

        public void UpdateMeetingRoom(MeetingRoom meetingRoom)
        {
            _meetingRoomDal.Update(meetingRoom);
        }
    }
}
