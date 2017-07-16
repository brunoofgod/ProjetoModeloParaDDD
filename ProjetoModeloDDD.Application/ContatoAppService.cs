using BrunoofgodArch.Application.Interface;
using BrunoofgodArch.Domain.Entities;
using BrunoofgodArch.Domain.Interfaces.Services;

namespace BrunoofgodArch.Application
{
    public class ContatoAppService : AppServiceBase<Contato>, IContatoAppService
    {
        private readonly IContatoService _contatoService;

        public ContatoAppService(IContatoService contatoService)
            : base(contatoService)
        {
            _contatoService = contatoService;
        }
    }
}