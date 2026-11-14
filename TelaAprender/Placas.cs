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
    public partial class Placas : Form
    {
        public Placas()
        {
            InitializeComponent();
            Navegacao.Configurar(this, button5);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pedestre tela = new pedestre();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAprender tela = new FormAprender();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Travessia tela = new Travessia();
            tela.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ajuda tela = new ajuda();
            tela.Show();
        }
    }
}
