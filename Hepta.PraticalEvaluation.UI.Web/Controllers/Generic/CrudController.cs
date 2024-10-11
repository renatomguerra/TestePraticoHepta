using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hepta.PraticalEvaluation.Domain;
using Hepta.PraticalEvaluation.Application.Interfaces;
using Hepta.PraticalEvaluation.Application.Services;

namespace Hepta.PraticalEvaluation.UI.Web.Controllers.Generic
{
    public abstract class CrudController<TDataKeyType, TEntity> : Controller
           where TEntity : BaseEntity<TDataKeyType>, new()

    {
        public IService<TDataKeyType, TEntity> _service = null;
        public CrudController(IService<TDataKeyType, TEntity> service)
        {
            _service = service;
        }

        protected virtual void OnInit()
        {
        }

        [HttpGet]
        public virtual ActionResult Index()
        {
            OnInit();
            return View(_service.GetAll());
        }

        [HttpGet]
        public virtual ActionResult Create()
        {
            OnInit();
            return View(new TEntity());
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public virtual ActionResult Create(TEntity entity)
        {
            try
            {
                if (ModelState.IsValid == false)
                {
                    return View(entity);
                }

                _service.Add(entity);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Erro", e.Message);
                return View(entity);
            }
            return RedirectToAction("Index");
        }

        [HttpGet()]
        [Route("{id}")]
        public virtual ActionResult Edit(TDataKeyType id)
        {
            OnInit();

            TEntity entity = null;
            try
            {
                entity = _service.FindById(id);

                if (entity == null)
                {
                    return HttpNotFound();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
            }
            return View(entity);
        }

        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public virtual ActionResult Edit(TEntity entity)
        {
            try
            {
                _service.Update(entity);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                return View(entity);
            }

            return RedirectToAction("Index");
        }

        [HttpGet()]
        [Route("{id}")]
        public virtual ActionResult Delete(TDataKeyType id)
        {
            TEntity entity = null;
            try
            {
                entity = _service.FindById(id);

                if (entity == null)
                {
                    return HttpNotFound();
                }
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
            }
            return View(entity);
        }

        [HttpPost()]
        [Route("{id}")]
        public virtual ActionResult Delete(TEntity entity)
        {
            try
            {
                _service.Delete(entity);
            }
            catch (Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                return View(entity);
            }
            return RedirectToAction("Index");
        }

    }
}