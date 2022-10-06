using YeminusSoftware.Domain;

namespace YeminusSoftware.Application.Interfaces
{
    public interface IEncryptService
    {
        Task<IEnumerable<Encrypt>> GetEncryptPhrases();
        Task<Encrypt> GetEncryptPhrase(int id);
        Task<Encrypt> Create(Encrypt encrypt);
        Task Update(Encrypt encrypt);
        Task Delete(int id);
    }
}
