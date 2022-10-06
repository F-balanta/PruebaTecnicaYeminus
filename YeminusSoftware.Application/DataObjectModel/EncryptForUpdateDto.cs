namespace YeminusSoftware.Application.DataObjectModel.Base
{
    public class EncryptForUpdateDto : BaseDto
    {
        public string Phrase { get; set; }
        public int Key { get; set; }
    }
}
