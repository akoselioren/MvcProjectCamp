using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator() 
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı kısmını boş geçilemez.!");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu kısmını boş geçilemez.!");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj kısmını boş geçilemez.!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En az 3 karakter girişi yapınız.!");
            RuleFor(x => x.Subject).MaximumLength(500).WithMessage("500 Karakterden uzun olamaz.!");
        }
    }
}
