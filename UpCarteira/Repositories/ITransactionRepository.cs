using UpCarteira.Models;

namespace UpCarteira.Repositories;

internal interface ITransactionRepository
{
    void Add(Transaction transaction);
    void Delete(Transaction transaction);
    List<Transaction> GetAll();
    void Update(Transaction transaction);
}