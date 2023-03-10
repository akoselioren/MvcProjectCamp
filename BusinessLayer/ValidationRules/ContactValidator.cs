using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator: AbstractValidator<Contact>
    {
        public ContactValidator() 
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresi boş geçilemez.!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adını Boş Geçemezsiniz.!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı kısmını boş geçemezsiniz.!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız.!");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız.!");
            RuleFor(x => x.Subject).MaximumLength(20).WithMessage("20 Karakterden uzun olamaz.!");
        }
    }
}
