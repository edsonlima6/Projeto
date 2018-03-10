using System;
using Telerik.WinControls;
using TeleHelp.Domain.Enums.Comuns;

namespace TeleHelp_WFR.Compartilhado
{
    public partial class frmBase : Telerik.WinControls.UI.RadForm
    {
        SistemaEnuns.MenuBaseGravar _cmdMenuGravar;

        public frmBase() :base()
        {
            InitializeComponent();
            _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.DEFAULT;
            HabilitaBotao();
            cbeMenuGravar.OverflowButton.Visibility = ElementVisibility.Collapsed;
        }
        
        protected bool novoBotao
        {
            set
            {
                if (value)
                {
                    _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.INCLUIR;
                    HabilitaBotao();
                    return;
                }
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.DEFAULT;
                HabilitaBotao();
            }

        }

        bool _alteraBotao;
        protected bool alteraBotao
        {
            set
            {
                _alteraBotao = value;
                if (value)
                {
                    _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.ALTERAR;
                    HabilitaBotao();
                    return;
                }
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.DEFAULT;
                HabilitaBotao();
            }

        }

        public bool enableHideMenu
        {
            set
            {
                if ( value)
                {
                    cbeMenuGravar.Visibility = ElementVisibility.Hidden;
                    return;
                }
                cbeMenuGravar.Visibility = ElementVisibility.Visible;
            }
        }
        protected virtual bool Gravar()
        {
            return true;
        }
        protected virtual bool Alterar()
        {
            return true;
        }
        protected virtual bool Cancelar()
        {
            return true;
        }
        protected virtual bool Incluir()
        {
            return true;
        }
        protected virtual bool Excluir()
        {
            return true;
        }

        private void HabilitaBotao()
        {
            btnAlterar.Enabled = (/*_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.EXCLUIR ||*/ _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.GRAVAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.CANCELAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.DEFAULT);
            btnCancelar.Enabled = (_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.INCLUIR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.ALTERAR);
            btnNovo.Enabled = (_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.ALTERAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.EXCLUIR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.GRAVAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.CANCELAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.DEFAULT);
            btnSalvar.Enabled = (_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.INCLUIR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.ALTERAR);
            btnExcluir.Enabled = (_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.ALTERAR);
            
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Gravar())
            {
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.GRAVAR;
                HabilitaBotao();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (Alterar())
            {
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.ALTERAR;
                HabilitaBotao();
            }
        }
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (Incluir())
            {
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.INCLUIR;
                HabilitaBotao();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (Cancelar())
            {
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.CANCELAR;
                HabilitaBotao();
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (Excluir())
            {
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.EXCLUIR;
                HabilitaBotao();
            }
        }
    }
}
