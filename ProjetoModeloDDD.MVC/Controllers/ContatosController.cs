using AutoMapper;
using BrunoofgodArch.Application.Interface;
using BrunoofgodArch.Domain.Entities;
using BrunoofgodArch.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BrunoofgodArch.MVC.Controllers
{
    public class ContatosController : Controller
    {
        private readonly IContatoAppService _contatoApp;

        public ContatosController(IContatoAppService contatoApp)
        {
            _contatoApp = contatoApp;
        }

        // GET: Contatos
        public ActionResult Index()
        {
            var contatoViewModel = Mapper.Map<IEnumerable<Contato>, IEnumerable<ContatoViewModel>>(_contatoApp.GetAll());
            return View(contatoViewModel);
        }

        // GET: Contatos/Details/5
        public ActionResult Details(int id)
        {
            var contato = _contatoApp.GetById(id);
            var contatoViewModel = Mapper.Map<Contato, ContatoViewModel>(contato);

            return View(contatoViewModel);
        }

        // GET: Contatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contatos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ContatoViewModel contato)
        {
            if (ModelState.IsValid)
            {
                var contatoDomain = Mapper.Map<ContatoViewModel, Contato>(contato);
                _contatoApp.Add(contatoDomain);

                return RedirectToAction("Index");
            }

            return View(contato);
        }

        // GET: Contatos/Edit/5
        public ActionResult Edit(int id)
        {
            var contato = _contatoApp.GetById(id);
            var contatoViewModel = Mapper.Map<Contato, ContatoViewModel>(contato);

            return View(contatoViewModel);
        }

        // POST: Contatos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ContatoViewModel contato)
        {
            if (ModelState.IsValid)
            {
                var contatoDomain = Mapper.Map<ContatoViewModel, Contato>(contato);
                _contatoApp.Update(contatoDomain);

                return RedirectToAction("Index");
            }

            return View(contato);
        }

        // GET: Contatos/Delete/5
        public ActionResult Delete(int id)
        {
            var contato = _contatoApp.GetById(id);
            var contatoViewModel = Mapper.Map<Contato, ContatoViewModel>(contato);

            return View(contatoViewModel);
        }

        // POST: Contatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var contato = _contatoApp.GetById(id);
            _contatoApp.Remove(contato);

            return RedirectToAction("Index");
        }
    }
}