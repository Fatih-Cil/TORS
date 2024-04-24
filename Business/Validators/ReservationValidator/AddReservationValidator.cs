
using Business.Models.ReservationModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators.ReservationValidator
{
    public class AddReservationValidator : AbstractValidator<AddReservationModel>
    {
        public AddReservationValidator()
        {
            RuleFor(x => x.Turnout)
                .NotEmpty().WithMessage("Katılımcı sayısı boş olamaz");
            RuleFor(x => x.UserId)
                .NotEmpty().WithMessage("Kullanıcı Id boş olamaz");
            RuleFor(x => x.MeetingRoomId)
                .NotEmpty().WithMessage("Toplandı odası Id boş olamaz");
            RuleFor(x => x.StartDateTime)
                .NotEmpty().WithMessage("Başlangıç zamanı seçiniz");
            RuleFor(x => x.FinishDateTime)
                .NotEmpty().WithMessage("Bitiş zamanı seçiniz");


        }
    }
}
