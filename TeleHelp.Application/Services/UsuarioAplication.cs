using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.DTO.InterfacesDTO;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Services;

namespace TeleHelp.Application.Services
{
    public class UsuarioAplication : AplicationBase<Usuario>, IUsuarioAplication
    {
        private readonly IUsuarioService _usuarioservice;

        public UsuarioAplication(IUsuarioService _Usuarioservice) : base(_Usuarioservice)
        {
            _usuarioservice = _Usuarioservice;
        }


       
    }
}
