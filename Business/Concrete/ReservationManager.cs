using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {

        IReservationDal _reservationDal;
        IMeetingRoomService _meetingRoomService;

        public ReservationManager(IReservationDal reservationDal, IMeetingRoomService meetingRoomService)
        {
            _reservationDal = reservationDal;
            _meetingRoomService = meetingRoomService;
        }

        public bool AddReservation(Reservation reservation)
        {
            //Başlangıç tarihi ile bitiş tarihi karşılaştırıyor.
            if (!CheckMeetTime(reservation.StartDateTime, reservation.FinishDateTime)) return false;
            
            //Katılımcı sayısı kontrol
            if (!CheckParticipant(reservation)) return false;
            //daha önce o saatlerde bir rezarvasyon var mı kontrol ediyor.
            if (!CheckReservationTime(reservation.StartDateTime, reservation.FinishDateTime,reservation.MeetingRoomId)) return false;


            _reservationDal.Add(reservation);
            return true;
        }

        public bool CheckReservationTime(DateTime start, DateTime finish,int meetinRoomId)
        {
            var result = _reservationDal.Get(x => x.MeetingRoomId==meetinRoomId && start <= x.FinishDateTime && finish >= x.StartDateTime);

            if (result != null) return false;
            return true;

        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }

        public Reservation GetById(int id)
        {
            return _reservationDal.Get(x => x.Id == id);
        }

        public void RemoveReservation(Reservation reservation)
        {
            _reservationDal.Delete(reservation);
        }

        public void UpdateReservation(Reservation reservation)
        {
            _reservationDal.Update(reservation);
        }

        private bool CheckParticipant(Reservation reservation)
        {

            var result = _meetingRoomService.GetById(reservation.MeetingRoomId);

            if (result != null)
            {
                if (reservation.Turnout < result.MinParticipant || reservation.Turnout > result.Capacity)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        private bool CheckMeetTime(DateTime start, DateTime finish)
        {

            if (DateTime.Now < start && DateTime.Now < finish && start < finish) return true;
            return false;
        }


    }
}
