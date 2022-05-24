using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UploadArquivo.Data;
using UploadArquivo.Models;

namespace UploadArquivo.Controllers
{
    public class ArquivosController : Controller
    {
        BancoContexto _bancoContexto;
        public ArquivosController(BancoContexto bancoContexto)
        {
            _bancoContexto = bancoContexto;
        }
        public IActionResult Index()
        {
            var arquivos = _bancoContexto.Arquivos.ToList();
            return View(arquivos);
        }

        [HttpPost]
        public IActionResult UploadImagem(IList<IFormFile> arquivos)
        {
            IFormFile imagemCarregada = arquivos.FirstOrDefault();
            if (imagemCarregada != null)
            {
                MemoryStream ms = new MemoryStream();
                imagemCarregada.OpenReadStream().CopyTo(ms);

                Arquivos arqui = new Arquivos()
                {
                    Descricao = imagemCarregada.FileName,
                    Dados = ms.ToArray(),
                    ContentType = imagemCarregada.ContentType
                };

                _bancoContexto.Arquivos.Add(arqui);
                _bancoContexto.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Visualizar(int id)
        {
            var arquivosBanco = _bancoContexto.Arquivos.FirstOrDefault(a => a.Id == id);
            return File(arquivosBanco.Dados, arquivosBanco.ContentType);
        }
    }
}
