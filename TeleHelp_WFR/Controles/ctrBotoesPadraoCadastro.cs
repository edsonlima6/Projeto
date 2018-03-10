using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleHelp.Domain.Enums.Comuns;

namespace TeleHelp_WFR.Controles
{
    public partial class ctrBotoesPadraoCadastro : UserControl
    {
        SistemaEnuns.MenuBaseGravar _cmdMenuGravar;

        public ctrBotoesPadraoCadastro()
        {
            InitializeComponent();
            
        }

        private void ctrBotoesPadraoCadastro_Load(object sender, EventArgs e)
        {
            _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.DEFAULT;
            HabilitaBotao();
        }
        public bool disableBtnCancelar
        {
            set
            {
                if (value)
                {
                    _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.CANCELAR;
                    HabilitaBotao();
                    return;
                }
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.DEFAULT;
                HabilitaBotao();
            }
        }
        public bool disableBtnExcluir
        {
            set
            {
                if (value)
                {
                    _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.EXCLUIR;
                    HabilitaBotao();
                    return;
                }
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.DEFAULT;
                HabilitaBotao();
            }
        }
        public bool disableBtnAlterar
        {
            set
            {
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

        public bool disableBtnNovo
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
        public bool disableBtnGravar
        {
            set
            {
                if (value)
                {
                    _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.GRAVAR;
                    HabilitaBotao();
                    return;
                }
                _cmdMenuGravar = SistemaEnuns.MenuBaseGravar.DEFAULT;
                HabilitaBotao();
            }
        }

        private void HabilitaBotao()
        {
            btnAlterar.Enabled = ( _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.GRAVAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.CANCELAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.DEFAULT);
            btnCancelar.Enabled = (_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.INCLUIR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.ALTERAR);
            btnNovo.Enabled = (_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.EXCLUIR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.GRAVAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.CANCELAR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.DEFAULT);
            btnGravar.Enabled = (_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.INCLUIR || _cmdMenuGravar == SistemaEnuns.MenuBaseGravar.ALTERAR);
            btnExcluir.Enabled = (_cmdMenuGravar == SistemaEnuns.MenuBaseGravar.ALTERAR);

        }

        private void btnGravar_MouseHover(object sender, EventArgs e)
        {
            btnGravar.BackColor = Color.LightBlue;
        }

        private void btnGravar_MouseLeave(object sender, EventArgs e)
        {
            btnGravar.BackColor = Color.Transparent;
        }

        private void btnAlterar_MouseHover(object sender, EventArgs e)
        {
            btnAlterar.BackColor = Color.LightBlue;
        }

        private void btnAlterar_MouseLeave(object sender, EventArgs e)
        {
            btnAlterar.BackColor = Color.Transparent;
        }

        private void btnNovo_MouseHover(object sender, EventArgs e)
        {
            btnNovo.BackColor = Color.LightBlue;
        }

        private void btnNovo_MouseLeave(object sender, EventArgs e)
        {
            btnNovo.BackColor = Color.Transparent;
        }

        private void btnExcluir_MouseHover(object sender, EventArgs e)
        {
            btnExcluir.BackColor = Color.LightBlue;
        }

        private void btnExcluir_MouseLeave(object sender, EventArgs e)
        {
            btnExcluir.BackColor = Color.Transparent;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.LightBlue;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Transparent;
        }
    }
}
