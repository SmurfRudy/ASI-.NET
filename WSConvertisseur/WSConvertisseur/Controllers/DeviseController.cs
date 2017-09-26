using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace WSConvertisseur.Controllers
{
    public class DeviseController : ApiController
    {
        List<Models.Devise> devises = new List<Models.Devise>();
        public DeviseController()
        {
            Models.Devise dollar = new Models.Devise(1, "Dollar", 1.08);
            Models.Devise franc = new Models.Devise(2, "Franc Suisse", 1.07);
            Models.Devise yen = new Models.Devise(3, "Yen", 120);

            devises.Add(dollar);
            devises.Add(franc);
            devises.Add(yen);
        }

        // GET: api/Devise
        public IEnumerable<Models.Devise> Get()
        {
            return this.devises.AsEnumerable();
        }

        // GET: api/Devise/5
        [ResponseType(typeof(Models.Devise))]
        public IHttpActionResult Get(int id)
        {
            Models.Devise devise = devises.FirstOrDefault((d) => d.id == id);
            if (devise == null)
            {
                return NotFound();
            }
            return Ok(devise);
        }

        // POST: api/Devise
        [ResponseType(typeof(Models.Devise))]
        public IHttpActionResult Post(Models.Devise devise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            devises.Add(devise);
            return CreatedAtRoute("DefaultApi", new { id = devise.id }, devise);
        }

        // PUT: api/Devise/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Models.Devise devise)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != devise.id)
            {
                return BadRequest();
            }
            int index = devises.FindIndex((d) => d.id == id);
            if (index < 0)
            {
                return NotFound();
            }
            devises[index] = devise;
            return StatusCode(HttpStatusCode.NoContent);
        }

        // DELETE: api/Devise/5
        public IHttpActionResult Delete(int id)
        {
            Models.Devise devise = devises.FirstOrDefault((d) => d.id == id);
            if (devise == null)
            {
                return NotFound();
            }
            devises.Remove(devise);
            return Ok(devise);
        }
    }
}
