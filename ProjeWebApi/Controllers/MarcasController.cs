using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ProjeWebApi.DataConnection;

namespace ProjeWebApi.Controllers
{
    public class MarcasController : ApiController
    {
        DataConnetion db = new DataConnetion();

        // GET: api/Patrimonio busca Lista 
        [HttpGet]
        public IEnumerable<Marca> GetMarca()
        {
            try
            {
                var lista = db.Marca.ToList().Distinct();
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
            /*
            try
            {
                return Ok(new Marca().GetAll());
            }
            catch (Exception)
            {
                throw;
            }
          */
        }

        // GET: api/Patrimonio/ busca elemento por id 
        [HttpGet]
        public IHttpActionResult GetMarca(int id)
        {
            Marca _returne = new Marca(id);
            if (_returne.MarcaId == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(_returne);
            }
        }

        // POST: api/Patrimonio inser elemento
        [HttpPost]
        public IHttpActionResult PostMarca([FromBody] Marca mrc)
        {
            try
            {
                mrc.Insert();
            }
            catch (System.Exception)
            {

                throw;
            }
            return Ok();
        }

        // PUT: api/Patrimonio/ edita elemento 
        [HttpPut]
        public IHttpActionResult PutMarca(int id, [FromBody]Marca mrc)
        {
            Marca mc = new Marca(id);
            mc.Nome = mrc.Nome;
            //mc.MarcaId = mrc.MarcaId;
            try
            {
                mc.Update();
                mc.SaveChanges();

            }
            catch (System.Exception)
            {

                throw;
            }

            return Ok();
        }

        // DELETE: api/Patrimonio/ deleta elemento 
        [HttpDelete]
        public IHttpActionResult DeleteMarca(int id)
        {
            Marca mrc = new Marca(id);
            try
            {
                mrc.Delete();
                mrc.SaveChanges();

            }
            catch (System.Exception)
            {

                throw;
            }
            return Ok();

        }
    }
}
