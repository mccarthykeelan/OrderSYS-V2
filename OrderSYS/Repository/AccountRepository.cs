using Oracle.ManagedDataAccess.Client;
using OrderSYS.Models;
using System;
using System.Collections.Generic;

namespace OrderSYS.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly string connectionString;

        public AccountRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Register(AccountModel account)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "INSERT INTO ACCOUNTS (ACCOUNT_ID, TITLE, FIRST_INITIAL, SURNAME, PHONE, EMAIL, ADDRESS1, ADDRESS2, CITY, COUNTY, EIRCODE, STATUS, TYPE, PASSWORD) " +
                               "VALUES (:AccountId, :Title, :FirstInitial, :Surname, :Phone, :Email, :Address1, :Address2, :City, :County, :Eircode, :Status, :Type, :Password)";
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
                command.Parameters.Add(":Status", OracleDbType.Varchar2).Value = account.Status;
                command.Parameters.Add(":Type", OracleDbType.Varchar2).Value = account.Type;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = account.Password;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
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

        public void Update(AccountModel account)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "UPDATE ACCOUNTS SET TITLE = :Title, FIRST_INITIAL = :FirstInitial, SURNAME = :Surname, " +
                               "PHONE = :Phone, EMAIL = :Email, ADDRESS1 = :Address1, ADDRESS2 = :Address2, CITY = :City, " +
                               "COUNTY = :County, EIRCODE = :Eircode, STATUS = :Status, TYPE = :Type, PASSWORD = :Password " +
                               "WHERE ACCOUNT_ID = :AccountId";
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
                command.Parameters.Add(":Status", OracleDbType.Varchar2).Value = account.Status;
                command.Parameters.Add(":Type", OracleDbType.Varchar2).Value = account.Type;
                command.Parameters.Add(":Password", OracleDbType.Varchar2).Value = account.Password;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(AccountModel account)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "DELETE FROM ACCOUNTS WHERE ACCOUNT_ID = :AccountId";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":AccountId", OracleDbType.Int32).Value = account.Id;

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<AccountModel> GetAll()
        {
            List<AccountModel> accounts = new List<AccountModel>();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "SELECT * FROM ACCOUNTS";
                OracleCommand command = new OracleCommand(query, connection);

                connection.Open();
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AccountModel account = new AccountModel
                    {
                        Id = Convert.ToInt32(reader["ACCOUNT_ID"]),
                        Title = reader["TITLE"].ToString(),
                        FirstInitial = reader["FIRST_INITIAL"].ToString(),
                        Surname = reader["SURNAME"].ToString(),
                        Phone = reader["PHONE"].ToString(),
                        Email = reader["EMAIL"].ToString(),
                        Address1 = reader["ADDRESS1"].ToString(),
                        Address2 = reader["ADDRESS2"].ToString(),
                        City = reader["CITY"].ToString(),
                        County = reader["COUNTY"].ToString(),
                        Eircode = reader["EIRCODE"].ToString(),
                        Status = reader["STATUS"].ToString(),
                        Type = reader["TYPE"].ToString(),
                        Password = reader["PASSWORD"].ToString()
                    };

                    accounts.Add(account);
                }

                reader.Close();
            }

            return accounts;
        }

        public AccountModel GetAccountById(int id)
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "SELECT * FROM ACCOUNTS WHERE ACCOUNT_ID = :AccountId";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":AccountId", OracleDbType.Int32).Value = id;

                connection.Open();
                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    AccountModel account = new AccountModel
                    {
                        Id = Convert.ToInt32(reader["ACCOUNT_ID"]),
                        Title = reader["TITLE"].ToString(),
                        FirstInitial = reader["FIRST_INITIAL"].ToString(),
                        Surname = reader["SURNAME"].ToString(),
                        Phone = reader["PHONE"].ToString(),
                        Email = reader["EMAIL"].ToString(),
                        Address1 = reader["ADDRESS1"].ToString(),
                        Address2 = reader["ADDRESS2"].ToString(),
                        City = reader["CITY"].ToString(),
                        County = reader["COUNTY"].ToString(),
                        Eircode = reader["EIRCODE"].ToString(),
                        Status = reader["STATUS"].ToString(),
                        Type = reader["TYPE"].ToString(),
                        Password = reader["PASSWORD"].ToString()
                    };

                    reader.Close();
                    return account;
                }
                else
                {
                    reader.Close();
                    throw new Exception("Account not found");
                }
            }
        }

        public IEnumerable<AccountModel> SearchBy(string searchCriteria)
        {
            List<AccountModel> accounts = new List<AccountModel>();

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                string query = "SELECT * FROM ACCOUNTS WHERE TITLE LIKE '%' || :SearchCriteria || '%' " +
                               "OR FIRST_INITIAL LIKE '%' || :SearchCriteria || '%' " +
                               "OR SURNAME LIKE '%' || :SearchCriteria || '%'";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":SearchCriteria", OracleDbType.Varchar2).Value = searchCriteria;

                connection.Open();
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    AccountModel account = new AccountModel
                    {
                        Id = Convert.ToInt32(reader["ACCOUNT_ID"]),
                        Title = reader["TITLE"].ToString(),
                        FirstInitial = reader["FIRST_INITIAL"].ToString(),
                        Surname = reader["SURNAME"].ToString(),
                        Phone = reader["PHONE"].ToString(),
                        Email = reader["EMAIL"].ToString(),
                        Address1 = reader["ADDRESS1"].ToString(),
                        Address2 = reader["ADDRESS2"].ToString(),
                        City = reader["CITY"].ToString(),
                        County = reader["COUNTY"].ToString(),
                        Eircode = reader["EIRCODE"].ToString(),
                        Status = reader["STATUS"].ToString(),
                        Type = reader["TYPE"].ToString(),
                        Password = reader["PASSWORD"].ToString()
                    };

                    accounts.Add(account);
                }

                reader.Close();
            }

            return accounts;
        }

        public void Approve(AccountModel account)
        {
            // Implement approval logic here if needed
            throw new NotImplementedException();
        }

        public void Block(AccountModel account)
        {
            // Implement blocking logic here if needed
            throw new NotImplementedException();
        }

        public void Close(AccountModel account)
        {
            // Implement closing logic here if needed
            throw new NotImplementedException();
        }

        public void Unlock(AccountModel account)
        {
            // Implement unlocking logic here if needed
            throw new NotImplementedException();
        }
    }
}
