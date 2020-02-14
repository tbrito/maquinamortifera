using MaquinaMoritifera.Model.Entidades;
using MaquinaMoritifera.Model.UI;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaquinaMoritifera.Model.Servicos
{
    public interface IUsuarioService
    {
        Task<long> Adicionar(UsuarioViewModel model);

        Task<long> Excluir(long id);

        Task<UsuarioViewModel> Obter(long id);

        IList<Usuario> ListarTodos();

        Task<long> Atualizar(UsuarioViewModel updateUserModel);
    }
}
