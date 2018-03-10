using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Domain.DTO;
using TeleHelp.Domain.DTO.InterfacesDTO;

namespace TeleHelp_WFR.Injection
{
    public class DtoInjectModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUsuarioDTO>().To<UsuarioDTO>();
            Bind<IGrupoDTO>().To<GruposDTO>();
            Bind<ICargoDTO>().To<CargoDTo>();
        }
    }
}
