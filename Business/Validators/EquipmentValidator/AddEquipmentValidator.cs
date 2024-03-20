using Business.Models.EquipmentModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Validators.EquipmentValidator
{
    public class AddEquipmentValidator : AbstractValidator<AddEquipmentModel>
    {
        public AddEquipmentValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Ekipman adı boş olamaz")
                .Length(2, 30).WithMessage("Ekipman adı en az 2 en çok 30 karakter olmalıdır");

        }
    }
}
