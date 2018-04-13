using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.Entities;

namespace MyBISolutions.Models.ClassesFuncionais
{
    public class SessionUser
    {
        readonly IUsuarioAplication _usuarioAplication;
        public SessionUser(IUsuarioAplication usuarioAplication)
        {
            _usuarioAplication = usuarioAplication;
        }

        public void ValidaSession(UsuarioModel usuarioModel)
        {
            try
            {
                var userDomain = _usuarioAplication.ValidaLogin(usuarioModel.Email, usuarioModel.Senha);


                if (userDomain != null)
                {

                }


            }
            catch (Exception ex)
            {
               throw ex;
            }
        }

        public void AddUser(UsuarioModel usuarioModel)
        {
            try
            {
                var usuarioDomain = Mapper.Map<UsuarioModel, Usuario>(usuarioModel);
                usuarioDomain.DataCadastro = DateTime.Now;
                usuarioDomain.Login = usuarioDomain.Email;
                _usuarioAplication.Add(usuarioDomain);
                _usuarioAplication.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}