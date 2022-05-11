﻿using SimpleSign.Models;

namespace SimpleSign.Repositorio
{
    public interface IDocumentoRepositorio
    {
        List<DocumentoModel> BuscarTodos();
        DocumentoModel ListarPorId(int id);

        DocumentoModel Adicionar(DocumentoModel documento);
        DocumentoModel Atualizar(DocumentoModel documento);
        bool Apagar(int id);
    }
}
