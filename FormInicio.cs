namespace TelaInicial
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();

            // o "botão" é um painel com imagem e texto dentro,
            // então o clique precisa ser ligado em todos
            panel1.Click += AbrirAprender;
            tableLayoutPanel1.Click += AbrirAprender;
            pictureBox1.Click += AbrirAprender;
            label5.Click += AbrirAprender;
        }

        private void AbrirAprender(object? sender, EventArgs e)
        {
            var tela = new FormAprender();
            tela.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonSobre_Click(object sender, EventArgs e)
        {

        }
    }
}
