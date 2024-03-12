using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCom
{
    public partial class frmFormulario2 : Form
    {
        public frmFormulario2()
        {
            InitializeComponent();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            bcdBuscador.Enabled = true;
            bcdBuscador.Navigate("https://www.google.com/?hl=es");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close(); //Se cerrara el formulario secundario
        }
    }
}
