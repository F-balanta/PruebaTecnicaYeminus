using FluentValidation;
using YeminusSoftware.Application.DataObjectModel;

namespace YeminusSoftware.Application.Validators
{
    public class ProductValidator : AbstractValidator<ProductForCreateDto>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Description).NotEmpty();
            RuleFor(x => x.Vat).NotEmpty();
            RuleFor(x => x.ForSale).NotEmpty();
            RuleFor(x => x.ImgUrl).NotEmpty();
            RuleFor(x => x.Price).NotEmpty();
        }
    }
}
