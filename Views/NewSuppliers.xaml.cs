namespace SOFTGE.Views;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

public partial class NewSuppliers : ContentPage
{
    ObservableCollection<string> items;
    public NewSuppliers()
	{
		InitializeComponent();

        items = new ObservableCollection<string>();

        ItemsCollectionView.ItemsSource = items;

        // Transformar em uma fun��o para tirar da database
        OptionsPicker.Items.Add("Op��o 1");
        OptionsPicker.Items.Add("Op��o 2");
        OptionsPicker.Items.Add("Op��o 3");
        OptionsPicker.Items.Add("Op��o 4");
    }
    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        // Obter os valores dos campos
        var name = NameEntry.Text;
        var id = IdEntry.Text;

        // Validar os campos
        if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(id))
        {
            await DisplayAlert("Erro", "Por favor, preencha todos os campos.", "OK");
            return;
        }

        // Processar os dados (por exemplo, enviar para um servi�o ou exibir um alerta)
        await DisplayAlert("Dados Enviados", $"Nome: {name}\nID: {id}", "OK");

        // Limpar os campos ap�s o envio
        NameEntry.Text = string.Empty;
        IdEntry.Text = string.Empty;
    }
    private void OnAddClicked(object sender, EventArgs e)
    {
        // Obter o valor do campo de entrada
        var input = InputEntry.Text;

        // Verificar se o input n�o est� vazio
        if (!string.IsNullOrWhiteSpace(input))
        {
            // Adicionar o input � lista
            items.Add(input);

            // Limpar o campo de entrada
            InputEntry.Text = string.Empty;
        }
    }

    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        // Obter o nome inserido e a op��o selecionada
        string name = NameEntry.Text;
        string selectedOption = OptionsPicker.SelectedItem?.ToString() ?? "Nenhuma";

        // Exibir alerta com os dados inseridos
        await DisplayAlert("Dados Confirmados", $"Nome: {name}\nOp��o Selecionada: {selectedOption}", "OK");
    }
}