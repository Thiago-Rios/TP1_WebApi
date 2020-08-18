using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;
using WebAPI_TP1.Services;

namespace WebAPI_TP1.Controllers
{
    public class AmigosController : Controller
    {
        private AmigosServices Services { get; set; }

        public AmigosController(AmigosServices services)
        {
            Services = services;
        }

        // GET: Amigos
        public ActionResult Amigos(string ids = "")
        {
            var amigos = Services.GetAll();

            if (!String.IsNullOrWhiteSpace(ids))
            {
                ViewBag.IdsSelecionados = ids.Split(",");
            }
            return View(amigos);
        }

        public ActionResult AmigosSelecionados(string ids)
        {
            List<Amigo> amigosSelecionados = new List<Amigo>();

            if (!String.IsNullOrWhiteSpace(ids))
            {
                foreach (var item in ids.Split(","))
                {
                    amigosSelecionados.Add(this.Services.GetAmigoById(int.Parse(item)));
                }
            }

            return View(amigosSelecionados);
        }

        // GET: Amigos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Amigos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Amigos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Amigos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Amigos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Amigos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Amigos/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}