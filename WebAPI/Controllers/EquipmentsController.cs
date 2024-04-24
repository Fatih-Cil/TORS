using AutoMapper;
using Business.Abstract;
using Business.Models.EquipmentModel;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        IEquipmentService _equipmentService;
        IMapper _mapper;
       

        public EquipmentsController(IEquipmentService equipmentService, IMapper mapper)
        {
            _equipmentService = equipmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
        var result = _equipmentService.GetAll();

            
            return (result.Count==0)
                ? BadRequest("Ekipman listesi henüz oluşmadı")
                : Ok(result);

        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
           var result= _equipmentService.GetById(id);

            return (result==null)
                ? BadRequest(id + " id numasına ait bir kayıt bulunamadı")
                : Ok(result);

            
        }

        [HttpPost]
        public IActionResult Add(AddEquipmentModel addEquipmentModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var equipment = _mapper.Map<Equipment>(addEquipmentModel);
           // equipment.Name = addEquipmentModel.Name;
            
            
            equipment.CreatedDate=DateTime.Now;

            _equipmentService.AddEquipment(equipment);
            return Ok(equipment.Name+" adında ekipman eklendi.");
        }

        [HttpPut]
        public IActionResult Update(UpdateEquipmentModel updateEquipmentModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           var equipment= _equipmentService.GetById(updateEquipmentModel.Id);

            if (equipment == null)
            {
                return BadRequest(updateEquipmentModel.Id + " id numasına ait bir kayıt bulunamadı");
            }

            
             var equipmentMap = _mapper.Map<Equipment>(updateEquipmentModel);
            // equipment.Name=updateEquipmentModel.Name;
            equipmentMap.UpdatedDate=DateTime.Now;
            equipmentMap.CreatedDate=equipment.CreatedDate;

            _equipmentService.UpdateEquipment(equipmentMap);

            return Ok("Update işlemi yapıldı.");
            
        }

        [HttpDelete]
        public IActionResult Delete(DeleteEquipmentModel deleteEquipmentModel)
        {

           var result= _equipmentService.GetById(deleteEquipmentModel.Id);
            if (result == null)
            {
                return BadRequest(deleteEquipmentModel.Id + " id numasına ait bir kayıt bulunamadı");
            }
           
            _equipmentService.RemoveEquipment(result);

            return Ok("Silme işlemi başarılı.");

        }
    }
}
