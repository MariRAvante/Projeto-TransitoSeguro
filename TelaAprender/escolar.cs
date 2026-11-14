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
    public partial class escolar : Form
    {
        public escolar()
        {
            InitializeComponent();
            Navegacao.Configurar(this, button5);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pedestre tela = new pedestre();
            tela.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            proibido tela = new proibido();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
