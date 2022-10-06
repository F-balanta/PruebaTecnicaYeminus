using YeminusSoftware.Domain.Base;

namespace YeminusSoftware.Domain
{
    public class Product : BaseEntity
    {
        public string? Description { get; set; }

        public List<int>? PriceList { get; set; }

        public string? ImgUrl { get; set; }

        public bool? ForSale { get; set; }

        public int? Vat { get; set; }
        
    }
}
