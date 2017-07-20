using BrunoofgodArch.Application;
using BrunoofgodArch.Application.Interface;
using BrunoofgodArch.Domain.Interfaces.Repositories;
using BrunoofgodArch.Domain.Interfaces.Services;
using BrunoofgodArch.Domain.Services;
using BrunoofgodArch.Infra.Data.Repositories;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace ProjetoModeloDDD.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType(typeof(IAppServiceBase<>),typeof(AppServiceBase<>));
            container.RegisterType<IContatoAppService,ContatoAppService>();
            container.RegisterType(typeof(IServiceBase<>),typeof(ServiceBase<>));
            container.RegisterType<IContatoService,ContatoService>();
            container.RegisterType(typeof(IRepositoryBase<>),typeof(RepositoryBase<>));
            container.RegisterType<IContatoRepository,ContatoRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}