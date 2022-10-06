namespace YeminusSoftware.Application.DataObjectModel.Base
{
    public class EncryptForCreateDto : BaseDto
    {
        public string Phrase { get; set; }
        public int Key { get; set; }
    }
}
