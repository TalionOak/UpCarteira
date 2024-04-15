using LiteDB;

namespace UpCarteira.Models;

internal class Transaction
{
    [BsonId]
    public int Id { get; set; }
    public TransactionType Type { get; set; }
    public string Name { get; set; }
    public DateTimeOffset Date { get; set; }
    public double Value { get; set; }
}
