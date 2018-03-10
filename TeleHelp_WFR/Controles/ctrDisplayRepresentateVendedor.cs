using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleHelp_WFR.Controles
{
  

    public partial class ctrDisplayRepresentateVendedor : UserControl
    {
        public delegate void ButtonClickedEventHandler(object sender, EventArgs e);
        public event ButtonClickedEventHandler OnUserControlButtonClicked;
        public bool teste
        {
            set
            {
                if (value)
                {
                    btnSalvarPessoa.PerformClick();
                }
            }
        }
        public ctrDisplayRepresentateVendedor()
        {
            InitializeComponent();
            btnSalvarPessoa.Click += new EventHandler(OnButtonClicked);
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            // Delegate the event to the caller
            if (OnUserControlButtonClicked != null)
                OnUserControlButtonClicked(this, e);
        }

        private void btnSalvarPessoa_Click(object sender, EventArgs e)
        {

        }
    }
   
}
