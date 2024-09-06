namespace SOFTGE.Views;
using Microsoft.Maui.Controls;
using SOFTGE.Models;
using SOFTGE.Data;

public partial class NewItem : ContentPage
{
    private ProdutoDatabase _database;
    public NewItem()
    {
        InitializeComponent();


        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "produtos.db3");
        _database = new ProdutoDatabase(dbPath);

        // Carregar os produtos ao iniciar a página
        LoadProdutos();
    }

    private async void LoadProdutos()
    {
        List<Produto> produtos = await ProdutoDatabase.GetProdutosAsync();
        ProdutosCollectionView.ItemsSource = produtos;
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        try
        {
            string nome = NomeEntry.Text;
            string categoria = CategoriaEntry.Text;
            DateTime validade = ValidadePicker.Date;
            string fornecedor = FornecedorEntry.Text;
            string locacao = LocacaoEntry.Text;
            int quantidade = int.Parse(QuantidadeEntry.Text);
            decimal valor = decimal.Parse(ValorEntry.Text);

            if (!string.IsNullOrWhiteSpace(nome) && !string.IsNullOrWhiteSpace(categoria))
            {
                Produto newProduto = new Produto
                {
                    Nome = nome,
                    Categoria = categoria,
                    Validade = validade,
                    Fornecedor = fornecedor,
                    Locacao = locacao,
                    Quantidade = quantidade,
                    Valor = valor
                };

                int result = await ProdutoDatabase.SaveProdutoAsync(newProduto);

                if (result > 0)
                {
                    await DisplayAlert("Sucesso", "Produto adicionado com sucesso!", "OK");
                }
                else
                {
                    await DisplayAlert("Erro", "Falha ao adicionar o produto.", "OK");
                }

                // Limpar campos de entrada
                NomeEntry.Text = string.Empty;
                CategoriaEntry.Text = string.Empty;
                FornecedorEntry.Text = string.Empty;
                LocacaoEntry.Text = string.Empty;
                QuantidadeEntry.Text = string.Empty;
                ValorEntry.Text = string.Empty;

                // Recarregar os produtos
                LoadProdutos();
            }
            else
            {
                await DisplayAlert("Erro", "Por favor, insira o nome e a categoria do produto.", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"Ocorreu um erro: {ex.Message}", "OK");
        }
    }
}