﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz.!");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazar Soyadını boş geçemezsiniz.!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçemezsiniz.!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan kısmını boş geçemezsiniz.!");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız.!");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("20 Karakterden uzun olamaz.!");
        }
    }
}
