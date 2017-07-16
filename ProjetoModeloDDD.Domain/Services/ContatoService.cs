using BrunoofgodArch.Domain.Entities;
using BrunoofgodArch.Domain.Interfaces.Repositories;
using BrunoofgodArch.Domain.Interfaces.Services;

namespace BrunoofgodArch.Domain.Services
{
    public class ContatoService : ServiceBase<Contato>, IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
            : base(contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }
    }
}