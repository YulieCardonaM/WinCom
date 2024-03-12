using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCom
{
    public partial class frmFormulario1 : Form
    {
        public frmFormulario1()
        {
            InitializeComponent();
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            wmpVideo.URL = @"C:\\Users\\clint\\source\\repos\\WinCom\\bin\\Debug\\HolaMundo.mp4";
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Application.StartupPath);
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Archivos PDF |* pdf";
            openFileDialog1.Title = "Selecciona archivo PDF";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string filePath = openFileDialog1.FileName; //Obtenemos la ruta del archivo seleccionado
                openFileDialog1.ShowDialog();
                LectorPDF.src = openFileDialog1.FileName;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmFormulario2 segundoFormulario = new frmFormulario2();
            segundoFormulario.Show();
        }
    }
}
