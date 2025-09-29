using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Odonto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuDentista_Click(object sender, EventArgs e)
        {
            frmCadDentista frm = new frmCadDentista();
            frm.ShowDialog();
        }

        private void menuAgDentistas_Click(object sender, EventArgs e)
        {
            frmConDentista frm = new frmConDentista();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
