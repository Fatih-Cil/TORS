using AutoMapper;
using Business.Abstract;
using Business.Models.EquipmentModel;
using Business.Models.ReservationModel;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        IReservationService _reservationService;
        IUserService _userService;
        IMeetingRoomService _meetingRoomService;
        IMapper _mapper;

        public ReservationsController(IReservationService reservationService, IMapper mapper, IUserService userService, IMeetingRoomService meetingRoomService)
        {
            _reservationService = reservationService;
            _mapper = mapper;
            _userService = userService;
            _meetingRoomService = meetingRoomService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _reservationService.GetAll();


            return (result.Count == 0)
                ? BadRequest("Rezervasyon listesi henüz oluşmadı")
                : Ok(result);

        }

        [HttpGet("GetById")]
        public IActionResult Get(int id)
        {
            var result = _reservationService.GetById(id);

            return (result == null)
                ? BadRequest(id + " id numasına ait bir kayıt bulunamadı")
                : Ok(result);


        }

        [HttpPost]
        public IActionResult Add(AddReservationModel addReservationModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var reservation = _mapper.Map<Reservation>(addReservationModel);
            reservation.CreatedDate = DateTime.Now;

           var result= _reservationService.AddReservation(reservation);

            return (result == false)
                ? BadRequest("Kayıt yapılamadı")
                : Ok("Kayıt başarılı.");




        }
    }
}
