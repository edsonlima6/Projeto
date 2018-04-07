using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Repositories;


namespace TeleHelp.Infraestrutura.Data.Repositorio
{
    public class UsuarioRespository : RepositoryBase<Usuario>, IUsuarioRepository
    {
     
        public bool ValidaLogin(string login, string senha)
        {
            try
            {
                return true;// Db.Usuarios.Where(u => u.Login == login && u.Senha == senha).Count().Equals(0) ? false : true;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public Usuario AddUsuario(Usuario usuario)
        {
            try
            {
                Db.Usuarios.Add(usuario);
                Db.SaveChanges();
                return usuario;
            }
            catch (DbUpdateException erroDbUpdateException)
            {
                throw erroDbUpdateException;
            }
            catch (Exception exAddUser)
            {
                throw exAddUser;
            }
        }

        public void UpdateUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                var UsuarioBD = GetById(usuario.IdUsuario);
                UsuarioBD.Nome = usuario.Nome;
                UsuarioBD.Email = usuario.Email;
                UsuarioBD.Foto = usuario.Foto;
                UsuarioBD.HorarioEntrada = usuario.HorarioEntrada;
                UsuarioBD.HorarioSaida = usuario.HorarioSaida;
                UsuarioBD.IdCargo = usuario.IdCargo;
                UsuarioBD.IdDepartamento = usuario.IdDepartamento;
                UsuarioBD.IdTipoAtendimento = usuario.IdTipoAtendimento;
                UsuarioBD.IdTipoUsuario = usuario.IdTipoUsuario;
                UsuarioBD.Login = usuario.Login;
                UsuarioBD.Matricula = usuario.Matricula;
                UsuarioBD.Senha = usuario.Senha;
                UsuarioBD.SenhaExtra = usuario.SenhaExtra;
               // UsuarioBD.Turno = usuario.Turno;
                Update(UsuarioBD);
                SaveChanges();
                return;
            }
        }
    }
}
