using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MaquinaMoritifera.Model.Entidades;
using MaquinaMoritifera.Model.Repositorios;
using MaquinaMoritifera.Model.UI;

namespace MaquinaMoritifera.Model.Servicos
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioService(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public Task<long> Adicionar(UsuarioViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<long> Atualizar(UsuarioViewModel updateUserModel)
        {
            throw new NotImplementedException();
        }

        public Task<long> Excluir(long id)
        {
            throw new NotImplementedException();
        }

        public IList<Usuario> ListarTodos()
        {
            return _usuarioRepositorio.ObterTodos();
        }

        public Task<UsuarioViewModel> Obter(long id)
        {
            throw new NotImplementedException();
        }
    }
}
