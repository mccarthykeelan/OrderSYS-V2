using OrderSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Repository
{
    public class AccountRepository : IAccountRepository
    {
        public void Approve(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public void Block(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public void Close(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public void Delete(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Login(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public void Register(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> SearchBy(string productName)
        {
            throw new NotImplementedException();
        }

        public void Unlock(AccountModel account)
        {
            throw new NotImplementedException();
        }

        public void Update(AccountModel account)
        {
            throw new NotImplementedException();
        }
    }
}
