using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
		public AboutValidator()
		{
			RuleFor(x => x.Description).NotEmpty().WithMessage("Acıklama Bos Geçilemez");
			RuleFor(x => x.Image).NotEmpty().WithMessage("Lütfen görsel seçiniz");
			RuleFor(x => x.Description).MinimumLength(50).WithMessage("En az 50 Karakter Kullanınız");
			RuleFor(x => x.Description).MaximumLength(1500).WithMessage("En Fazla 1500 Karakter Giriniz");

		}
	}
}
