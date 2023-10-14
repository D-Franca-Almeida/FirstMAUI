namespace AppNumeroDaSorte
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //CurrentPage(Página Atual), ou seja, a página apresentada no momento. 
            MainPage = new MainPage(); // MainPage e propriedade do app e o segundo MainPage é uma propriedade da classe 
        }
    }
}