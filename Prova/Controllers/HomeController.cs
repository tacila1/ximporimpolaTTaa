using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prova.Controllers
{
    public class HomeController : Controller
    {
        BancoDataContext banco = new BancoDataContext();

        public ActionResult Index()
        {
            ProdutoModel p = new ProdutoModel();
            p.produtoASerAlterado = TempData["produtoEscolhido"] as ProdutoModel;
            p.listaProduto = banco.SELECT_PRODUTO().ToList();
            return View(p);
        }


        public ActionResult CadastrarProduto(int? id, string nome, decimal? preco)
        {
            if (id > 0)
            {
                banco.ATUALIZAR_PRODUTO(nome, preco, id);
            }
            else
            {
                banco.INSERIR_PRODUTO(nome, preco);
            }
            TempData["produtoEscolhido"] = null;

            return RedirectToAction("Index");
        }

        public ActionResult DeletarProduto(int id)
        {
            banco.DELETAR_PRODUTO(id);
            return RedirectToAction("Index");
        }

        public ActionResult AtualizarProduto(int? id, string nome, decimal? preco)
        {
            TempData["produtoEscolhido"] = new ProdutoModel(id, nome, preco);
            return RedirectToAction("Index");
        }







        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}