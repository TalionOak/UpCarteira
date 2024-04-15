using System.Text;
using UpCarteira.Models;
using UpCarteira.Repositories;

namespace UpCarteira.Views;

public partial class TransactionAdd : ContentPage
{
	public TransactionAdd()
	{
		InitializeComponent();

	}

    private void TappedTocouNoX(object sender, TappedEventArgs e)
    {
		Navigation.PopModalAsync();
    }

    private void ButtonSalvar_Clicked(object sender, EventArgs e)
    {
        if (isValidData() == false)
            return;

        Transaction transaction = new()
        {
            Type = RadioIncome.IsChecked ? TransactionType.Income : TransactionType.Expenses,
            Name = EntryName.Text,
            Date = DatePickerDate.Date,
            Value = double.Parse(EntryValor.Text),
        };

        var repository = ServiceHelper.GetService<ITransactionRepository>();
        repository.Add(transaction);

        Navigation.PopModalAsync();
        var contagemTransacoes = repository.GetAll().Count;
        DisplayAlert("Mensagem!", $"Existem {contagemTransacoes} transações no banco!", "Ok");
    }

    private bool isValidData()
    {
        bool valid = true;
        StringBuilder sb = new StringBuilder();

        if (string.IsNullOrEmpty(EntryName.Text) || string.IsNullOrWhiteSpace(EntryName.Text))
        {
            valid = false;
            sb.AppendLine("O campo 'Nome' deve se preenchido!");
        }

        if (string.IsNullOrEmpty(EntryValor.Text) || string.IsNullOrWhiteSpace(EntryValor.Text))
        {
            valid = false;
            sb.AppendLine("O campo 'Valor' deve se preenchido!");
        }

        double result;
        if (!string.IsNullOrEmpty(EntryValor.Text) && !double.TryParse(EntryValor.Text, out result))
        {
            valid = false;
            sb.AppendLine("O campo 'Valor' é invalido!");
        }

        if(valid == false)
        {
            LabelError.Text = sb.ToString();
            LabelError.IsVisible = true;
        } else
        {
            LabelError.IsVisible = false;
        }
        return valid;
    }
}