using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(X => X.Title).NotEmpty().WithMessage("Görsel başlığını boş geçemezsiniz");
            RuleFor(X => X.Description).NotEmpty().WithMessage("Görsel açıklamasını boş geçemezsiniz");
            RuleFor(X => X.ImageUrl).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz");
            RuleFor(X => X.Title).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri girişi yapın");
            RuleFor(X => X.Title).MinimumLength(8).WithMessage("Lütfen en az 8 karakter veri girişi yapın");
            RuleFor(X => X.Description).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri girişi yapın");
            RuleFor(X => X.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter veri girişi yapın");
        }
    }
}
