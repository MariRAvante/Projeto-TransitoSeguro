using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaInicial
{
    public partial class pedestre : Form
    {
        public pedestre()
        {
            InitializeComponent();
            Navegacao.Configurar(this, button5);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Placas tela = new Placas();
            tela.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            escolar tela = new escolar();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
