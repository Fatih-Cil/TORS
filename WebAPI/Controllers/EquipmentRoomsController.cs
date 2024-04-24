using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentRoomsController : ControllerBase
    {
        IMapper _mapper;

        public EquipmentRoomsController(IMapper mapper)
        {
            _mapper = mapper;
        }


    }
}
