using AutoMapper;
using BrunoofgodArch.Api.ViewModels;
using BrunoofgodArch.Application.Interface;
using BrunoofgodArch.Domain.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace ProjetoModeloDDD.Api.Controllers
{
    public class ContatoController : ApiController
    {
        private readonly IContatoAppService _contatoApp;

        public ContatoController(IContatoAppService contatoApp)
        {
            _contatoApp = contatoApp;
        }

        // GET api/values/5
        public JsonResult<Contato> Get(int id)
        {

            return Json(_contatoApp.GetById(id));
        }   

        // GET api/values/5
        public JsonResult<IEnumerable<Contato>> GetAll()
        {
            return Json(_contatoApp.GetAll());
        }

        // POST api/values
        [System.Web.Http.HttpPost]
        public JsonResult<Contato> Post([FromBody]Contato contatoViewModel)
        {
            _contatoApp.Add(contatoViewModel);
            return Json(contatoViewModel);
        }

        // PUT api/values/5
        [System.Web.Http.HttpPut]
        public JsonResult<Contato> Put([FromBody]Contato contatoViewModel)
        {
            _contatoApp.Update(contatoViewModel);
            return Json(contatoViewModel);
        }

        // DELETE api/values/5
        [System.Web.Http.HttpDelete]
        public JsonResult<IEnumerable<Contato>> Delete(int id)
        {
            var contato =_contatoApp.GetById(id);
            _contatoApp.Remove(contato);

            return Json(_contatoApp.GetAll());
        }
    }
}
