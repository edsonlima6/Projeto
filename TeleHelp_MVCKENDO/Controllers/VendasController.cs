﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeleHelp_MVCKENDO.Controllers
{
    public class VendasController : Controller
    {
        // GET: Vendas
        public ActionResult Index()
        {
            return View();
        }

        // GET: Vendas/Details/5
        public ActionResult CadastroVenda()
        {
            return View();
        }

        // GET: Vendas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vendas/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vendas/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Vendas/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vendas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Vendas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
