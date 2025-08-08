using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(X => X.PersonName).NotEmpty().WithMessage("Takım arkadaşı ismini boş geçemezsiniz");
            RuleFor(X => X.Title).NotEmpty().WithMessage("Görev kısmını boş geçemezsiniz");
            RuleFor(X => X.ImageUrl).NotEmpty().WithMessage("Resim yolu boş geçilemez");
            RuleFor(X => X.PersonName).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");
            RuleFor(X => X.PersonName).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri girişi yapın");
            RuleFor(X => X.Title).MaximumLength(50).WithMessage("Lütfen 50 karakterden daha az veri girişi yapın");
            RuleFor(X => X.Title).MinimumLength(3).WithMessage("Lütfen en az 3 karakter veri girişi yapın");
        }

        
    }
}
