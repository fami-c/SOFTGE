using SOFTGE.Data;
using SOFTGE.Models;

namespace SOFTGE.Views;

public partial class ProdutosPage : ContentPage
{
    private ProdutoDatabase _database;
    public ProdutosPage()
    {
        InitializeComponent();

        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "produtos.db3");
        _database = new ProdutoDatabase(dbPath);

        // Carregar os produtos ao iniciar a página
        LoadProdutos();
    }

    private async void LoadProdutos()
    {
        var produtos = await ProdutoDatabase.GetProdutosAsync();
        ProdutosCollectionView.ItemsSource = produtos;
    }
}