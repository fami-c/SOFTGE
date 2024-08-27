namespace SOFTGE;

public partial class Products : ContentPage
{
	public Products()
	{
		InitializeComponent();
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

        // Processar os dados (por exemplo, enviar para um serviço ou exibir um alerta)
        await DisplayAlert("Dados Enviados", $"Nome: {name}\nID: {id}", "OK");

        // Limpar os campos após o envio
        NameEntry.Text = string.Empty;
        IdEntry.Text = string.Empty;
    }
}