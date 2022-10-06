using YeminusSoftware.Application.Interfaces;
using YeminusSoftware.Domain;
using YeminusSoftware.Domain.Repository;
using YeminusSoftware.Util;

namespace YeminusSoftware.Application.Services
{
    public class EncryptService : IEncryptService
    {
        private readonly IEncryptRepository _repository;

        private readonly IHelpers _helper;

        public EncryptService(IEncryptRepository repository, IHelpers helper)
        {
            _repository = repository;
            _helper = helper;

        }
        public async Task<IEnumerable<Encrypt>> GetEncryptPhrases() => await _repository.GetAllAsync();
        
        public async Task<Encrypt> GetEncryptPhrase(int id) => await _repository.GetByIdAsync(id);
        
        public async Task<Encrypt> Create(Encrypt encrypt)
        {
            var PhraseEncrypted = new Encrypt {Phrase = _helper.Encriptar(encrypt.Phrase, encrypt.Key)};
            var newPhrase = await _repository.AddAsync(PhraseEncrypted);
            return newPhrase;
        }
        
        public async Task Update(Encrypt encrypt)
        {
            var phraseEncrypted = await _repository.GetByIdAsync(encrypt.Code);
            encrypt.Phrase = _helper.Desencriptar(phraseEncrypted.Phrase, encrypt.Code);
        }
        public async Task Delete(int id)
        {
            var phraseDelete = await _repository.GetByIdAsync(id);
            await _repository.DeleteAsync(phraseDelete);
        }
    }
}
