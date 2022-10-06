using YeminusSoftware.Application.DataObjectModel.Base;

namespace YeminusSoftware.Application.DataObjectModel
{
    public class ProductDto : BaseDto
    {
        public string? Description { get; set; }

        public List<int>? PriceList { get; set; }

        public string? ImgUrl { get; set; }

        public bool? ForSale { get; set; }

        public int? Vat { get; set; }
    }
}
