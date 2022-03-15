using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz .");
            RuleFor(x=>x.Content).NotEmpty().WithMessage("Blog İçerigini Boş Geçemezsiniz .");
            RuleFor(x=>x.BlogImage).NotEmpty().WithMessage("Blog Görselini Boş Geçemezsiniz .");
            RuleFor(x => x.BlogTitle).MaximumLength(200).WithMessage("Blog Başlığı 200 Karakterden Uzun Olamaz .");
            RuleFor(x => x.BlogTitle).MinimumLength(4).WithMessage("Blog Başlığı 4 Karakterden Kısa Olamaz .");
        }
    }
}
