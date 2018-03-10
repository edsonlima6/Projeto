using System;
using System.Windows.Forms;
using TeleHelp.Application.Interface;
using Encrypt;
using Telerik.WinControls;
using Ninject;
using System.Collections.Generic;

namespace TeleHelp_WFR
{
    public partial class frmLogin : Telerik.WinControls.UI.RadForm
    {
        readonly IUsuarioAplication _iuser;

        string erros;
        Cryptex cryptex;
        string _login;
        String _senha;
        public String senha
        {
            get
            {
                return cryptex.Desencriptar(_senha);
            }
            set
            {
                _senha = cryptex.Encriptar(value.ToUpper());
            }
        }

        public frmLogin(IUsuarioAplication _User)
        {
            _iuser = _User;
            InitializeComponent();
            cryptex = new Cryptex();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
            }
            if (keyData == Keys.Enter)
            {
                ValidaAcesso();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            ValidaAcesso();
        }

        private void ValidaAcesso()
        {
            IList<string> listaErros;
            senha = txtSenha.Text;
            _login = txtLogin.Text;
            try
            {
                erros = null;
                listaErros = _iuser.ValidaLogin(_login, _senha);
                if (listaErros.Count == 0)
                {
                    MainForm frmMenu = new MainForm();
                    this.Hide();
                    frmMenu.Show();
                }
                else
                {
                    foreach (var item in listaErros)
                    {
                        erros += item;
                    }
                    MessageBox.Show(erros);
                }
                    
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
