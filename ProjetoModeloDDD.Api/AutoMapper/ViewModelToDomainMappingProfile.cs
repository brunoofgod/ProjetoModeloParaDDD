using AutoMapper;
using BrunoofgodArch.Domain.Entities;
using BrunoofgodArch.Api.ViewModels;

namespace BrunoofgodArch.Api.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Contato, ContatoViewModel>();
        }
    }
}