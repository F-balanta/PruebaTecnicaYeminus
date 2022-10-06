using YeminusSoftware.Domain.Base;

namespace YeminusSoftware.Domain
{
    public class Encrypt : BaseEntity
    {
        public string Phrase { get; set; }
        public int Key { get; set; }
    }
}
