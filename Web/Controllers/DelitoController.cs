using System;
using System.Web.Mvc;
using RegistroPolicial.Domain.Entities;
using RegistroPolicial.Application.Main.Interfaces;
using Web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Web.Controllers
{
    public class DelitoController : Controller
    {
    
        private readonly IDelitoAppService app;
        private readonly IPersonaJuridicaAppService personaJuridicaApp;
        private readonly IDelitoPersonaJuridicaAppService delitoPersonaJuridicaApp;

        public DelitoController(IDelitoAppService app, IPersonaJuridicaAppService personaJuridicaApp, IDelitoPersonaJuridicaAppService delitoPersonaJuridicaApp)
        {
            this.delitoPersonaJuridicaApp = delitoPersonaJuridicaApp;
            this.app = app;
            this.personaJuridicaApp = personaJuridicaApp;
            
        }
       
        public ActionResult Index()
        {
            return View(this.app.GetAllEntity());
        }
       
        public ActionResult Details(int id)
        {
            Delito delito = this.app.GetByIdEntity(id);
            if (delito == null)
            {
                return HttpNotFound();
            }
            return View(delito);
        }
       
        public ActionResult Create()
        {
            return View();
        }
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DelitoView delitoView)
        {
   
            if (ModelState.IsValid)
            {
                PersonaJuridica personaJuridicaCreada = null;

                if (!string.IsNullOrEmpty(delitoView.personaJuridica.cedulaJuridica))
                {
                    try
                    {
                        personaJuridicaCreada = personaJuridicaApp.AddEntity(delitoView.personaJuridica);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Exception caught1.", e);
                    }
                        
                }

                if (!String.IsNullOrEmpty(delitoView.delito.origen))
                {
                    Delito delitoCreado = this.app.AddEntity(delitoView.delito);

                    if (personaJuridicaCreada != null)
                    {
                        try
                        {
                            DelitoPersonaJuridica delitoPersonaJuridica = new DelitoPersonaJuridica()
                            {
                                idDelito = delitoCreado.id,
                                idPersonaJuridica = personaJuridicaCreada.id
                            };
                            this.delitoPersonaJuridicaApp.AddEntity(delitoPersonaJuridica);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("{0} Exception caugh2t.", e);
                        }                    
                    }

                    return RedirectToAction("Index");
                }
            }

            return View(delitoView.delito);
        }
        
        public ActionResult Edit(int id)
        {
            Delito delito = this.app.GetByIdEntity(id);
            DelitoPersonaJuridica delitoPersonaJuridica = this.delitoPersonaJuridicaApp.GetAllEntity().FirstOrDefault();
            PersonaJuridica personaJuridica = this.personaJuridicaApp.GetByIdEntity(delitoPersonaJuridica.idPersonaJuridica.Value);

            DelitoView delitoView = new DelitoView()
            {
                delito = delito,
                personaJuridica = personaJuridica
            };

            if (delito == null)
            {
                return HttpNotFound();
            }
            return View(delitoView);
        }
        
        [HttpPost]
        public ActionResult Edit(DelitoView delitoView)
        {
            if (ModelState.IsValid)
            {               
                if (!string.IsNullOrEmpty(delitoView.delito.origen))
                {
                    this.app.ModifyEntity(delitoView.delito);
                    return RedirectToAction("Index");
                }
            }

            return View(delitoView);
        }
      
        public ActionResult Delete(int id)
        {
            Delito delito = this.app.GetByIdEntity(id);
            if (delito == null)
            {
                return HttpNotFound();
            }
            return View(delito);
        }
   
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            this.app.DeleteEntity(id);
            return RedirectToAction("Index");
        }    
    }
}
