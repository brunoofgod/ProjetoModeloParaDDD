using AutoMapper;
using BrunoofgodArch.Api.ViewModels;
using BrunoofgodArch.Application.Interface;
using BrunoofgodArch.Domain.Entities;
using Newtonsoft.Json;
using System.Web.Http;


namespace ProjetoModeloDDD.Api.Controllers
{
    public class ContatoController : ApiController
    {
        private readonly IContatoAppService _contatoApp;

        public ContatoController(IContatoAppService contatoApp)
        {
            _contatoApp = contatoApp;
        }

        public ContatoController()
        {

        }

        // GET api/values/5
        public string Get(int id)
        {
            return JsonConvert.SerializeObject(_contatoApp.GetById(id));
        }

        // GET api/values/5
        public string GetAll(int id)
        {
            return JsonConvert.SerializeObject(_contatoApp.GetAll());
        }

        // POST api/values
        public string Post([FromBody]ContatoViewModel contatoViewModel)
        {
           var contato =  Mapper.Map<ContatoViewModel, Contato >(contatoViewModel);
            _contatoApp.Add(contato);
            return JsonConvert.SerializeObject(contato);
        }

        // PUT api/values/5
        public string Put([FromBody]ContatoViewModel contatoViewModel)
        {
            var contato = Mapper.Map<ContatoViewModel, Contato>(contatoViewModel);
            return JsonConvert.SerializeObject(contato);
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            var contato =_contatoApp.GetById(id);
            _contatoApp.Remove(contato);

            return "true";
        }
    }
}
