using LiteDB;
using UpCarteira.Models;

namespace UpCarteira.Repositories;

internal class TransactionRepository
{
    private readonly LiteDatabase _database;
    private readonly ILiteCollection<Transaction> _transactions;

    public TransactionRepository(LiteDatabase database)
    {
        _database = database;
        _transactions = _database.GetCollection<Transaction>("transations");
    }

    public List<Transaction> GetAll()
    {
        return _transactions
            .Query()
            .OrderByDescending(x => x.Date)
            .ToList();
    }

    public void Add(Transaction transaction)
    {
        _transactions.Insert(transaction);
        _transactions.EnsureIndex(x => x.Date);
    }

    public void Update(Transaction transaction)
    {
        _transactions.Update(transaction);
    }

    public void Delete(Transaction transaction)
    {
        _transactions.Delete(transaction.Id);
    }
}
