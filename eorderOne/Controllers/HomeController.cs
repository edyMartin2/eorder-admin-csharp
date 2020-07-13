using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eorderOne.Models.ViewModels;
using eorderOne.Models;

namespace eorderOne.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lines() {
            List<listMlineaViewModel> lst;
            using (empresaEntities db = new empresaEntities()) {
                lst = (from i in db.mlinea
                       select new listMlineaViewModel {
                           ID_EMPRESA = i.ID_EMPRESA,
                           ID_LOCAL = i.ID_LOCAL,
                           ID_LINEA = i.ID_LINEA,
                           linea = i.LINEA,
                           //w_order = i.W_ORDEN
                       }).ToList();
            }

            return View(lst);
        }

        public ActionResult Addlines() {
            return View();
        }
        [HttpPost]
        public ActionResult Addlines(tableMlineaViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (empresaEntities db = new empresaEntities()) {
                        var newTable = new mlinea();
                        newTable.ID_EMPRESA = viewModel.ID_EMPRESA;
                        newTable.ID_LINEA = viewModel.ID_LINEA;
                        newTable.ID_LOCAL = viewModel.ID_LOCAL;
                        newTable.LINEA = viewModel.linea;
                        newTable.W_ORDEN = 1;

                        db.mlinea.Add(newTable);
                        db.SaveChanges();
                    }
                    return Redirect("/Home");
                }
                return View(viewModel);
            }
            catch (Exception e) {
                throw new Exception(e.Message);
            }
        }


        [HttpGet]
        public ActionResult deleteLine(string id) {
            using (empresaEntities db = new empresaEntities()) {
                db.mlinea.Remove(db.mlinea.Find(id));
                db.SaveChanges();
            }

            return Redirect("~/Home/lines");
        }
    }
}