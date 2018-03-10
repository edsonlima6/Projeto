using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TeleHelp_WFR.Compartilhado;
using TeleHelp_WFR.Injection;
using TeleHelp_WFR.Modulos.Administrativo;
using TeleHelp_WFR.Modulos.Cliente;

namespace TeleHelp_WFR
{
    static class Program
    {
        public static IKernel _kernel;
        static INinjectModule[] modules;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //MÓDULOS DA INJEÇÃO DE DEPEDÊNCIA
            modules = new INinjectModule[]
            {
               new InjectModule(),
               new DtoInjectModule()
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _kernel = new StandardKernel(modules);

            Application.Run(_kernel.Get<frmCadCargo>());
        }

       
    }
}
