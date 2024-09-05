using SOFTGE.Data;
using SOFTGE.Models;

namespace SOFTGE.Views;

public partial class ListItems : ContentPage
{
    private Database _database;
    public ListItems()
	{
		InitializeComponent();

        string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "items.db3");
        _database = new Database(dbPath);

        LoadItems();
    }

    private async void LoadItems()
    {
        List<Item> items = await _database.GetItemsAsync();
        ItemsCollectionView.ItemsSource = items;
    }
}