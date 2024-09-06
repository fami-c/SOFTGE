namespace SOFTGE
{

    using Microsoft.Maui.Platform;
    using SOFTGE.Views;

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

        private async void NewItemClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SOFTGE.Views.NewItem());
        }

        private async void NewCatClicked(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Digite o valor:", "Cancelar", null, "Confirmar");
            if (!string.IsNullOrEmpty(result))
            {
                await DisplayAlert("Confirmado", $"Valor: {result}", "OK");
            }
        }

        private async void NewSupClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SOFTGE.Views.NewSuppliers());
        }

        private async void OnFindClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Procurar", "Digite palavra-chave", "OK");
        }


        private async void OnViewAllClicked(object sender, EventArgs e)
        {
            await DisplayAlert("Todos","teste", "Ok");
        }

        private async void OnViewProdClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SOFTGE.Views.ProdutosPage());
        }

        private async void ShowSellingHistory(object sender, EventArgs e)
        {
            await DisplayAlert("a", "a", "a");
        }
    }
}
