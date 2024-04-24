using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEquipmentRoomService
    {
        List<EquipmentMeetingRoom> GetAll();
        EquipmentMeetingRoom GetById(int id);
        void Add(EquipmentMeetingRoom equipmentMeetingRoom);
        void Remove(EquipmentMeetingRoom equipmentMeetingRoom);
        void Update(EquipmentMeetingRoom equipmentMeetingRoom);
    }
}
