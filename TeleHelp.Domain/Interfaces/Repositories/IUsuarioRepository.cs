using TeleHelp.Domain.Entities;

namespace TeleHelp.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository : IRepositoryBase<Usuario>
    {
        bool ValidaLogin(string login, string senha);
        Usuario AddUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
    }
}
