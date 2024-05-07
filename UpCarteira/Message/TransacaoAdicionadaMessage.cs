using CommunityToolkit.Mvvm.Messaging.Messages;
using UpCarteira.Models;

namespace UpCarteira.Message;

internal class TransacaoAdicionadaMessage : ValueChangedMessage<Transaction>
{
    public TransacaoAdicionadaMessage(Transaction value) : base(value){}
}
