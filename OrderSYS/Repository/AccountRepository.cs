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
                string query = "SELECT COUNT(*) FROM Accounts WHERE AccountId = :AccountId AND Password = :Password";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":AccountId", OracleDbType.Int32).Value = accountId;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = password;

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public bool Register(int accountId, string title, string firstInitial, string surname, string phone, string email, string address1, string address2, string city, string county, string eircode, string password)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "INSERT INTO Accounts (AccountId, Title, FirstInitial, Surname, Phone, Email, Address1, Address2, City, County, Eircode, Password) " +
                               "VALUES (:AccountId, :Title, :FirstInitial, :Surname, :Phone, :Email, :Address1, :Address2, :City, :County, :Eircode, :Password)";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":AccountId", OracleDbType.Int32).Value = accountId;
                command.Parameters.Add(":Title", OracleDbType.Varchar2).Value = title;
                command.Parameters.Add(":FirstInitial", OracleDbType.Varchar2).Value = firstInitial;
                command.Parameters.Add(":Surname", OracleDbType.Varchar2).Value = surname;
                command.Parameters.Add(":Phone", OracleDbType.Varchar2).Value = phone;
                command.Parameters.Add(":Email", OracleDbType.Varchar2).Value = email;
                command.Parameters.Add(":Address1", OracleDbType.Varchar2).Value = address1;
                command.Parameters.Add(":Address2", OracleDbType.Varchar2).Value = address2;
                command.Parameters.Add(":City", OracleDbType.Varchar2).Value = city;
                command.Parameters.Add(":County", OracleDbType.Varchar2).Value = county;
                command.Parameters.Add(":Eircode", OracleDbType.Varchar2).Value = eircode;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = password;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
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
