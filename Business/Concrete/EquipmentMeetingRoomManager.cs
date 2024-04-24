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
    public class EquipmentMeetingRoomManager : IEquipmentRoomService
    {

        IEquipmentRoomDal _equipmentRoomDal;

        public EquipmentMeetingRoomManager(IEquipmentRoomDal equipmentRoomDal)
        {
            _equipmentRoomDal = equipmentRoomDal;
        }

        public void Add(EquipmentMeetingRoom equipmentMeetingRoom)
        {
            _equipmentRoomDal.Add(equipmentMeetingRoom);
        }

        public List<EquipmentMeetingRoom> GetAll()
        {
            return _equipmentRoomDal.GetAll();
        }

        public EquipmentMeetingRoom GetById(int id)
        {
            return _equipmentRoomDal.Get(x => x.Id == id);
        }

        public void Remove(EquipmentMeetingRoom equipmentMeetingRoom)
        {
            _equipmentRoomDal.Delete(equipmentMeetingRoom);
        }

        public void Update(EquipmentMeetingRoom equipmentMeetingRoom)
        {
            _equipmentRoomDal.Update(equipmentMeetingRoom);
        }
    }
}
