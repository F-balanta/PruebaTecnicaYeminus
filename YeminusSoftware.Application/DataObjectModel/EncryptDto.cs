namespace YeminusSoftware.Application.DataObjectModel.Base
{
    public class EncryptDto : BaseDto
    {
        public string Phrase { get; set; }
        public int Key { get; set; }
    }
}
