using OrderSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Repository
{
    public interface IAccountRepository
    {
        bool Login(int accountId, string password);
        void Register(AccountModel account);
        void Update(AccountModel account);
        void Delete(AccountModel account);
        void Approve(AccountModel account);
        void Close(AccountModel account);
        void Block(AccountModel account);
        void Unlock(AccountModel account);
        IEnumerable<AccountModel> GetAll();
        IEnumerable<ProductModel> SearchBy(string productName);
    }

}
