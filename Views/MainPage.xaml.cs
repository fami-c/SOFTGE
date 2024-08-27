using Microsoft.Maui.Controls;

namespace SOFTGE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnWidgetTapped(object sender, EventArgs e)
        {
            // Ação quando um widget é clicado
            DisplayAlert("Widget Tapped", "Você clicou em um widget!", "OK");
        }
    }

}
