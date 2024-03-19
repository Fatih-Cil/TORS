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
    public class EquipmentManager : IEquipmentService
    {

        IEquipmentDal _equipmentDal;

        public EquipmentManager(IEquipmentDal equipmentDal)
        {
            _equipmentDal = equipmentDal;
        }

        public void AddEquipment(Equipment equipment)
        {
            _equipmentDal.Add(equipment);
        }

        public List<Equipment> GetAll()
        {
            return _equipmentDal.GetAll();
        }

        public Equipment GetById(int id)
        {
          return  _equipmentDal.Get(x=>x.Id==id);
        }

        public void RemoveEquipment(Equipment equipment)
        {
            _equipmentDal.Delete(equipment);
        }

        public void UpdateEquipment(Equipment equipment)
        {
            _equipmentDal.Update(equipment);
        }
    }
}
