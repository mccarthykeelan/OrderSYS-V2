using OrderSYS.Models;
using System.Collections.Generic;

namespace OrderSYS.Repository
{
    public interface IAccountRepository
    {
        bool Login(int id, string password);
        bool Register(Account account);
        void Update(Account account);
        void Delete(Account account);
        void Approve(Account account);
        void Close(Account account);
        void Block(Account account);
        void Unlock(Account account);
        IEnumerable<Account> GetAll();

        Account GetAccountById(int id);
    }
}
