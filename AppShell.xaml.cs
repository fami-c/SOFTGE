namespace SOFTGE
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void GoHomingPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void OnNewClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SOFTGE.Views.NewItem());
        }

        private async void OnFindClicked(object sender, EventArgs e)
        {
            // Ação para a opção "Ajuda"
            await DisplayAlert("Procurar", "Digite palavra-chave", "OK");
        }

        private async void OnViewAllClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Todos","teste", "Ok");
        }

        private async void ShowSellingHistory(object sender, EventArgs e)
        {
            await DisplayAlert("a", "a", "a");
        }
    }
}
