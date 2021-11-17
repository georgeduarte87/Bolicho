using Bolicho.Data;
using Bolicho.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bolicho.Controllers
{
    public class OLDProdutoController : Controller
    {
        private readonly ApplicationDbContext _contexto;

        public OLDProdutoController(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var produto1 = new Produto
            {
                Nome = "Caderno",
                Descicao = "Caderno blablabla",
                Valor = 10,
                Estoque = 5

            };

            _contexto.Produtos.Add(produto1);
            _contexto.SaveChanges();

            var produto2 = _contexto.Produtos.Find(produto1.Id);
            var produto3 = _contexto.Produtos.FirstOrDefault(p => p.Nome == "Caderno");

            produto1.Nome = "Caneta";
            _contexto.Produtos.Update(produto1);
            _contexto.SaveChanges();

            _contexto.Produtos.Remove(produto1);
            _contexto.SaveChanges();

            return View();
        }
    }
}
