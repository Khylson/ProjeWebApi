using ProjeWebApi.DataConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjeWebApi.Controllers
{
    public class PatrimoniosController : ApiController
    {
        DataConnetion db = new DataConnetion();

        // GET: api/Patrimonio/ buscar Lista 
        [HttpGet]
         public IEnumerable<Patrimonio> GetPatrimonio()
        {
            try // pensado para tratamento de erro.
            {
                var lista = db.Patrimonio.ToList();
                return lista;

            }
            catch (Exception)
            {
                // metodo nõ implementado, mas pesado para eventuais erros de conexão ou busca de dados. 
                throw;
            }
            /*
            try
            {
                return Ok(new Patrimonio().GetAll());
            }
            catch (Exception)
            {

                throw;
            } */
        }
        
        // GET: api/Patrimonio/ buscar 1 elemento por id 
        [HttpGet]
        public IHttpActionResult GetPatrimonio(int id)
        {
            Patrimonio _returne = new Patrimonio(id);
            if (_returne.N_Tombo == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(_returne);
            }
        }

        // POST: api/Patrimonio/ insira elementos novos 
        [HttpPost]
        public IHttpActionResult PostPatrimonio([FromBody] Patrimonio pm)
        {
            try
            {
                pm.Insert();
            }
            catch (System.Exception)
            {

                throw;
            }
            return Ok();
        }

        // PUT: api/Patrimonio/ edita elementos 
        [HttpPut]
        public IHttpActionResult PutPatrimonio(int id, [FromBody]Patrimonio ptr)
        {
            Patrimonio pm = new Patrimonio(id);
            pm.Nome = ptr.Nome;
            pm.MarcaId = ptr.MarcaId;
            pm.Descricao = ptr.Descricao;
     
            try
            {
                pm.Update();
                pm.SaveChanges();

            }
            catch (System.Exception)
            {
                throw;
            }

            return Ok();
        }

        // DELETE: api/Patrimonio/ deleta elementos 
        [HttpDelete]
        public IHttpActionResult DeletePatrimonio(int id)
        {
            Patrimonio pm = new Patrimonio(id);
            try
            {
                pm.Delete();
                pm.SaveChanges();

            }
            catch (System.Exception)
            {

                throw;
            }
            return Ok();

        }
    }
}
