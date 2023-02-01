using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV___Ponto_de_Venda
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuFuncionario_Click(object sender, EventArgs e)
        {
            frmFuncionario frm = new frmFuncionario();
            frm.ShowDialog();
        }
    }
}
