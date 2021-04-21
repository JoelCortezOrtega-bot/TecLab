using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labtec
{
    public partial class FrRecuperarClave : Form
    {
        public FrRecuperarClave()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            Operaciones op = new Operaciones();
            op.Correo1 = txtCorreo.Text;
            op.RecuperarCorreo();
        }
    }
}
