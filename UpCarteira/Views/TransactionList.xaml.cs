using UpCarteira.Repositories;

namespace UpCarteira.Views;

public partial class TransactionList : ContentPage
{
	public TransactionList()
	{
		InitializeComponent();

        var repository = ServiceHelper.GetService<ITransactionRepository>();
        CollectionTransacoes.ItemsSource = repository.GetAll(); 
	}

    private void ButtonAdicionarTransacao_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new TransactionAdd());
    }

    private void ButtonEditarTransacao_Clicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new TransactionEdit());
    }
}