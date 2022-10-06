using System.Net;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using YeminusSoftware.Application.DataObjectModel.Base;
using YeminusSoftware.Application.ErrorHandler;
using YeminusSoftware.Application.Interfaces;
using YeminusSoftware.Domain;

namespace YeminusSoftware.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PhraseController : ControllerBase
    {
        private readonly IEncryptService _encryptService;

        private readonly IMapper _mapper;

        public PhraseController(IEncryptService encryptService, IMapper mapper)
        {
            _encryptService = encryptService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<EncryptDto>> GetEncryptPhrases()
        {
            var phraseList = await _encryptService.GetEncryptPhrases();
            return _mapper.Map<List<EncryptDto>>(phraseList);
        }

        [HttpGet("{id:int}")]
        public async Task<EncryptDto> GetPhraseById(int id)
        {
            var encryptPhrase = await _encryptService.GetEncryptPhrase(id);
            return _mapper.Map<EncryptDto>(encryptPhrase);
        }

        [HttpPost]
        public async Task<EncryptDto> EncryptPhrase([FromBody] EncryptForCreateDto encrypt)
        {
            var mapped = _mapper.Map<Encrypt>(encrypt);
            var phraseMapped = await _encryptService.Create(mapped);
            return _mapper.Map<EncryptDto>(phraseMapped);
        }

        [HttpPut]
        public async Task DecryptPhrase([FromBody] EncryptForUpdateDto encryptViewModel)
        {
            var mapped = _mapper.Map<Encrypt>(encryptViewModel);
            if (mapped == null)
                throw new RestException(HttpStatusCode.NotFound, new { message = "La frase que deseas desencriptar no existe" });
            await _encryptService.Update(mapped);
        }

        [HttpDelete("{id:int}")]
        public async Task DeletePhrase(int id)
        {
            var phraseDelete = await _encryptService.GetEncryptPhrase(id);
            if(phraseDelete == null)
                throw new RestException(HttpStatusCode.NotFound, new { message = "La frase que deseas eliminar no existe" });
            
            await _encryptService.Delete(id);
        }
    }
}
