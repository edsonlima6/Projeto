﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleHelp.Application.Interface;
using TeleHelp.Domain.Entities;
using TeleHelp.Domain.Interfaces.Services;

namespace TeleHelp.Application.Services
{
    public class TelaApplication : AplicationBase<Tela>, ITelaApplication
    {
        readonly ITelaService telaService;
        public TelaApplication(ITelaService _telaService):base(_telaService)
        {
            telaService = _telaService;
        }
    }
}
