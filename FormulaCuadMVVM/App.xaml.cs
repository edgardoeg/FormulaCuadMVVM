using FormulaCuadMVVM.Views;

namespace FormulaCuadMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FormulaCuadView();
        }
    }
}
