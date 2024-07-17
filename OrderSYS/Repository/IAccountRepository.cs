using OrderSYS.Models;
using System.Collections.Generic;

namespace OrderSYS.Repository
{
    public interface IAccountRepository
    {
        bool Login(int id, string password);
        bool Register(AccountModel account);
        void Update(AccountModel account);
        void Delete(AccountModel account);
        void Approve(AccountModel account);
        void Close(AccountModel account);
        void Block(AccountModel account);
        void Unlock(AccountModel account);
        IEnumerable<AccountModel> GetAll();

        AccountModel GetAccountById(int id); // New method declaration
    }
}
