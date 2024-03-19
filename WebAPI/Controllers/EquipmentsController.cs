using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        IEquipmentService _equipmentService;

        public EquipmentsController(IEquipmentService equipmentService)
        {
            _equipmentService = equipmentService;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
        var result = _equipmentService.GetAll();

            if (result.Count != 0) 
            {
                return Ok(result); 
            } else
            {
                return BadRequest("Ekipman listesi henüz oluşmadı");
            }
            
        }

    }
}
