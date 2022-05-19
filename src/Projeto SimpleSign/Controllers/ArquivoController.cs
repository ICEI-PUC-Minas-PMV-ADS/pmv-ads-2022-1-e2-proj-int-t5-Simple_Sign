using Microsoft.AspNetCore.Mvc;
using SimpleSign.Data;
using SimpleSign.Models;
using System.Linq;

namespace SimpleSign.Controllers
{
    public class ArquivoController : Controller
    {
        BancoContent _arquivoContent;

        public ArquivoController(BancoContent arquivoContent)
        {
            _arquivoContent = arquivoContent;
        }
        public IActionResult Index()
        {
            var arquivos = _arquivoContent.Arquivos.ToList();
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

                ArquivoModel arqui = new ArquivoModel()
                {
                    Descricao = imagemCarregada.FileName,
                    Dados = ms.ToArray(),
                    ContentType = imagemCarregada.ContentType
                };

                _arquivoContent.Arquivos.Add(arqui);
                _arquivoContent.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Visualizar(int id)
        {
            var arquivosBanco = _arquivoContent.Arquivos.FirstOrDefault(a => a.Id == id);
            return File(arquivosBanco.Dados, arquivosBanco.ContentType);
        }
    }
}
