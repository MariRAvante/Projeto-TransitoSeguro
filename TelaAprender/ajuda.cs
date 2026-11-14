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
    public partial class ajuda : Form
    {
        public ajuda()
        {
            InitializeComponent();
            Navegacao.Configurar(this, button5);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Placas tela = new Placas();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Travessia tela = new Travessia();
            tela.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAprender tela = new FormAprender();
            tela.Show();
        }
    }
}
