using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMarconiInstanciaEvaluativa
{
    public partial class frmLogoEmpresa : Form
    {
        public frmLogoEmpresa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int contadorTiempo = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contadorTiempo += 1000;
            if (contadorTiempo > 3000)
            {
                this.Hide();
                frmLogin formularioLogin = new frmLogin();
                formularioLogin.Show();
                timer1.Enabled = false;
            }
        }
    }
}
