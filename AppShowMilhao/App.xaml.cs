using AppShowMilhao.Models;

namespace AppShowMilhao
{
    public partial class App : Application
    {
        List<Pergunta> perguntas_faceis = new()
        {
            new Pergunta
            {
                Id = 1,
                Enunciado = "Qual é o nome dado ao estado da água em forma de gelo?"
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
