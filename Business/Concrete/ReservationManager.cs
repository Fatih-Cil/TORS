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
    public class ReservationManager : IReservationService
    {

        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;   
        }

        public void AddReservation(Reservation reservation)
        {
            _reservationDal.Add(reservation);
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.Get(x=> x.Id == id);
        }

        public void RemoveReservation(Reservation reservation)
        {
            _reservationDal.Delete(reservation);
        }

        public void UpdateReservation(Reservation reservation)
        {
            _reservationDal.Update(reservation);
        }
    }
}
