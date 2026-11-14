namespace TelaInicial
{
    /// <summary>
    /// Navegação entre a tela inicial e as telas do Aprender.
    /// </summary>
    internal static class Navegacao
    {
        /// <summary>
        /// Liga o botão "Início" da tela e faz o X da janela encerrar o aplicativo.
        /// </summary>
        public static void Configurar(Form tela, Button botaoInicio)
        {
            botaoInicio.Cursor = Cursors.Hand;
            botaoInicio.Click += (s, e) => VoltarParaInicio(tela);

            // Fechar pelo X encerra o app. Fechar por código (Close) ao navegar não encerra.
            tela.FormClosed += (s, e) =>
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    Application.Exit();
            };
        }

        public static void VoltarParaInicio(Form atual)
        {
            FormInicio? inicio = Application.OpenForms.OfType<FormInicio>().FirstOrDefault();
            if (inicio != null)
            {
                inicio.Show();
                inicio.Activate();
            }
            atual.Close();
        }
    }
}
