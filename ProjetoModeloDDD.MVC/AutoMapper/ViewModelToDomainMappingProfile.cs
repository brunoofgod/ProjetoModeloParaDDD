using AutoMapper;
using BrunoofgodArch.Domain.Entities;
using BrunoofgodArch.MVC.ViewModels;

namespace BrunoofgodArch.MVC.AutoMapper
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