using CommunityToolkit.Mvvm.Messaging;
using UpCarteira.Message;
using UpCarteira.Repositories;

namespace UpCarteira.Views.Transactions;

public partial class TransactionList : ContentPage
{
    public TransactionList()
    {
        InitializeComponent();


        var repository = ServiceHelper.GetService<ITransactionRepository>();
        //CollectionTransacoes.ItemsSource = repository.GetAll();

        WeakReferenceMessenger.Default.Register<TransacaoAdicionadaMessage>(this, (r, m) =>
        {
            OnMessageReceived(m.Value);
        });
    }

    private void OnMessageReceived(string value)
    {
        DisplayAlert("Mensagem!", $"Mensagem recebida de listagem! {value}", "Ok");
    }

    private void ButtonAdicionarTransacao_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TransactionAdd());
    }

    private void ButtonEditarTransacao_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TransactionEdit());
    }
}