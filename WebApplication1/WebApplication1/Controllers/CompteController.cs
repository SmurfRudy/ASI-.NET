﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models.Entity;

namespace WebApplication1.Controllers
{
    public class CompteController : ApiController
    {
        private BDFilmsAvisContext db = new BDFilmsAvisContext();

        // GET: api/Compte
        public IQueryable<T_E_COMPTE_CPT> GetCompte()
        {
            return db.T_E_COMPTE_CPT;
        }

        // GET: api/Compte/5
        [ResponseType(typeof(T_E_COMPTE_CPT))]
        public IHttpActionResult GetCompte(int id)
        {
            T_E_COMPTE_CPT t_E_COMPTE_CPT = db.T_E_COMPTE_CPT.Find(id);
            if (t_E_COMPTE_CPT == null)
            {
                return NotFound();
            }

            return Ok(t_E_COMPTE_CPT);
        }

        // GET: api/Compte/?email=compte@mail.com
        public IHttpActionResult GetCompte(string email)
        {
            T_E_COMPTE_CPT t_E_COMPTE_CPT = db.T_E_COMPTE_CPT.Where(c=>c.CPT_MEL.ToUpper()==email.ToUpper()).FirstOrDefault();
            if (t_E_COMPTE_CPT == null)
            {
                return NotFound();
            }

            return Ok(t_E_COMPTE_CPT);
        }

        // PUT: api/Compte/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCompte(int id, T_E_COMPTE_CPT t_E_COMPTE_CPT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != t_E_COMPTE_CPT.CPT_ID)
            {
                return BadRequest();
            }

            db.Entry(t_E_COMPTE_CPT).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Compte
        [ResponseType(typeof(T_E_COMPTE_CPT))]
        public IHttpActionResult PostCompte(T_E_COMPTE_CPT t_E_COMPTE_CPT)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.T_E_COMPTE_CPT.Add(t_E_COMPTE_CPT);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = t_E_COMPTE_CPT.CPT_ID }, t_E_COMPTE_CPT);
        }

        /*
        // DELETE: api/Compte/5
        [ResponseType(typeof(T_E_COMPTE_CPT))]
        public IHttpActionResult DeleteCompte(int id)
        {
            T_E_COMPTE_CPT t_E_COMPTE_CPT = db.T_E_COMPTE_CPT.Find(id);
            if (t_E_COMPTE_CPT == null)
            {
                return NotFound();
            }

            db.T_E_COMPTE_CPT.Remove(t_E_COMPTE_CPT);
            db.SaveChanges();

            return Ok(t_E_COMPTE_CPT);
        }*/

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CompteExists(int id)
        {
            return db.T_E_COMPTE_CPT.Count(e => e.CPT_ID == id) > 0;
        }
    }
}