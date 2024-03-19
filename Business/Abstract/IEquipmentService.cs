using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEquipmentService
    {
        List<Equipment> GetAll();
        Equipment GetById(int id);
        void AddEquipment(Equipment equipment);
        void RemoveEquipment(Equipment equipment);
        void UpdateEquipment(Equipment equipment);
    }
}
