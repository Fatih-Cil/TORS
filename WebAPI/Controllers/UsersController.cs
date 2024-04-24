using AutoMapper;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();


            return (result.Count == 0)
                ? BadRequest("Kullanıcı listesi henüz oluşmadı")
                : Ok(result);

        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var result = _userService.GetById(id);

            return (result == null)
                ? BadRequest(id + " id numasına ait bir kullanıcı bulunamadı")
                : Ok(result);


        }
    }
}
