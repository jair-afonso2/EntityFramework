using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PrimeiroEF.Dados;
using PrimeiroEF.Models;

namespace PrimeiroEF.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        Cliente cliente = new Cliente();

        /// <summary>
        /// readOnly = Somente Leitura
        /// </summary>
        readonly ClienteContexto contexto;


        public ClienteController(ClienteContexto contexto)
        {
            this.contexto = contexto;
        }


        [HttpGet]
        public IEnumerable<Cliente> Listar()
        {
            return contexto.ClienteBase.ToList();
        }

        [HttpGet("{id}")]
        public Cliente Listar(int id)
        {
            return contexto.ClienteBase.Where(x => x.Id == id).FirstOrDefault();
        }


        [HttpPost]
        public void Cadastrar([FromBody] Cliente cli)
        {
            contexto.ClienteBase.Add(cli);
            contexto.SaveChanges();
        }
    }
}