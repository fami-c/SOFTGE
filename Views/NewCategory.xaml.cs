namespace SOFTGE.Views;

public partial class NewCategory : ContentPage
{
    public string Result { get; private set; }
    public bool IsConfirmed { get; private set; }
    
    public NewCategory()
	{
		InitializeComponent();
	}

    private async void OnConfirmClicked(object sender, EventArgs e)
    {
        Result = InputEntry.Text;
        IsConfirmed = true;
        await Navigation.PopModalAsync();
    }
}