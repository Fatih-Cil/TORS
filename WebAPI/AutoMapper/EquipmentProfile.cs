using AutoMapper;
using Business.Models.EquipmentModel;
using Business.Models.ReservationModel;
using Entities.Concrete;

namespace WebAPI.AutoMapper
{
    public class EquipmentProfile: Profile
    {
        public EquipmentProfile()
        {
            CreateMap<Equipment, UpdateEquipmentModel>().ReverseMap();
            CreateMap<Equipment, AddEquipmentModel>().ReverseMap();
            CreateMap<Reservation, AddReservationModel>().ReverseMap(); 

        }
    }
}
