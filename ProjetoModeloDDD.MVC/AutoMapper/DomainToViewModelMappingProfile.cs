using AutoMapper;
using BrunoofgodArch.Domain.Entities;
using BrunoofgodArch.MVC.ViewModels;

namespace BrunoofgodArch.MVC.AutoMapper
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