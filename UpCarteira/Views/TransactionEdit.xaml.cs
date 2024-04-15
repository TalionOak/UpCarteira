namespace UpCarteira.Views;

public partial class TransactionEdit : ContentPage
{
	public TransactionEdit()
	{
		InitializeComponent();
	}

    private void TappedTocouNoX(object sender, TappedEventArgs e)
    {
        Navigation.PopModalAsync();
    }
}