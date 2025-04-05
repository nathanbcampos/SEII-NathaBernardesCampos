namespace Aula_Basica
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BTNOla_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Aviso", "Olá Mundo!", "OK");
        }
    }

}
