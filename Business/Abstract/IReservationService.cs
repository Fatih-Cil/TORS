using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReservationService
    {
        List<Reservation> GetAll();
        Reservation GetById(int id);
        void AddReservation(Reservation reservation);
        void RemoveReservation(Reservation reservation);
        void UpdateReservation(Reservation reservation);
    }
}
