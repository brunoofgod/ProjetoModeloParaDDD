using AutoMapper;
using BrunoofgodArch.Domain.Entities;
using BrunoofgodArch.Api.ViewModels;

namespace BrunoofgodArch.Api.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ContatoViewModel, Contato>();
        }
    }
}