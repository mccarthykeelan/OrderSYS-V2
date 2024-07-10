using Oracle.ManagedDataAccess.Client;
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
        private readonly string connectionString;

        public AccountRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

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

        public bool Login(int accountId, string password)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM ACCOUNTS WHERE ACCOUNT_ID = :AccountId AND PASSWORD = :Password";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":AccountId", OracleDbType.Int32).Value = accountId;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = password;

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public bool Register(AccountModel account)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "INSERT INTO ACCOUNTS (ACCOUNT_ID, FIRIST_INITIAL, SURNAME, EMAIL, PHONE, PHONE, ADDRESS1, ADDRESS2, CITY, COUNTY, EIRCODE, STATUS, TYPE, PASSWORD) " +
                               "VALUES (:AccountId, :Title, :FirstInitial, :Surname, :Phone, :Email, :Address1, :Address2, :City, :County, :Eircode, :Password)";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":AccountId", OracleDbType.Int32).Value = account.Id;
                command.Parameters.Add(":Title", OracleDbType.Varchar2).Value = account.Title;
                command.Parameters.Add(":FirstInitial", OracleDbType.Varchar2).Value = account.FirstInitial;
                command.Parameters.Add(":Surname", OracleDbType.Varchar2).Value = account.Surname;
                command.Parameters.Add(":Phone", OracleDbType.Varchar2).Value = account.Phone;
                command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = account.Email;
                command.Parameters.Add(":Address1", OracleDbType.Varchar2).Value = account.Address1;
                command.Parameters.Add(":Address2", OracleDbType.Varchar2).Value = account.Address2;
                command.Parameters.Add(":City", OracleDbType.Varchar2).Value = account.City;
                command.Parameters.Add(":County", OracleDbType.Varchar2).Value = account.County;
                command.Parameters.Add(":Eircode", OracleDbType.Varchar2).Value = account.Eircode;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = account.Password;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
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
