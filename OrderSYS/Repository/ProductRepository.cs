using OrderSYS.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace OrderSYS.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly string _sqlConnectionString;

        public ProductRepository(string sqlConnectionString)
        {
            _sqlConnectionString = sqlConnectionString;
        }

        public void Add(ProductModel product)
        {
            using (OracleConnection connection = new OracleConnection(_sqlConnectionString))
            {
                string query = "INSERT INTO PRODUCTS (BRAND, MODEL, DESCRIPTION, PRICE, STOCK, STATUS, CATEGORY) " +
                               "VALUES (:Brand, :Model, :Description, :Price, :Stock, :Status, :Category)";

                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":Brand", OracleDbType.Varchar2).Value = product.Brand;
                command.Parameters.Add(":Model", OracleDbType.Varchar2).Value = product.Model;
                command.Parameters.Add(":Description", OracleDbType.Varchar2).Value = product.Description;
                command.Parameters.Add(":Price", OracleDbType.Decimal).Value = Convert.ToDecimal(product.Price);
                command.Parameters.Add(":Stock", OracleDbType.Int32).Value = product.Stock;
                command.Parameters.Add(":Status", OracleDbType.Varchar2).Value = product.Status;
                command.Parameters.Add(":Category", OracleDbType.Varchar2).Value = product.Category;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected <= 0)
                {
                    throw new Exception("Failed to add product.");
                }
            }
        }

        public void Discontinue(ProductModel product)
        {
            Discontinue(product.Id);
        }

        public void Discontinue(int productId)
        {
            using (OracleConnection connection = new OracleConnection(_sqlConnectionString))
            {
                string query = "DELETE FROM PRODUCTS WHERE PRODUCT_ID = :ProductId";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":ProductId", OracleDbType.Int32).Value = productId;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected <= 0)
                {
                    throw new Exception("Failed to delete product.");
                }
            }
        }

        public IEnumerable<ProductModel> GetAll()
        {
            List<ProductModel> products = new List<ProductModel>();

            using (OracleConnection connection = new OracleConnection(_sqlConnectionString))
            {
                string query = "SELECT * FROM PRODUCTS";
                OracleCommand command = new OracleCommand(query, connection);

                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductModel product = new ProductModel
                    {
                        Id = Convert.ToInt32(reader["PRODUCT_ID"]),
                        Brand = reader["BRAND"].ToString(),
                        Model = reader["MODEL"].ToString(),
                        Description = reader["DESCRIPTION"].ToString(),
                        Price = Convert.ToDecimal(reader["PRICE"]),
                        Stock = Convert.ToInt32(reader["STOCK"]),
                        Status = reader["STATUS"].ToString(),
                        Category = reader["CATEGORY"].ToString()
                    };
                    products.Add(product);
                }
            }

            return products;
        }

        public IEnumerable<ProductModel> GetAvailable()
        {
            List<ProductModel> products = new List<ProductModel>();

            using (OracleConnection connection = new OracleConnection(_sqlConnectionString))
            {
                string query = "SELECT * FROM PRODUCTS WHERE STOCK > 0";
                OracleCommand command = new OracleCommand(query, connection);

                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductModel product = new ProductModel
                    {
                        Id = Convert.ToInt32(reader["PRODUCT_ID"]),
                        Brand = reader["BRAND"].ToString(),
                        Model = reader["MODEL"].ToString(),
                        Description = reader["DESCRIPTION"].ToString(),
                        Price = Convert.ToDecimal(reader["PRICE"]),
                        Stock = Convert.ToInt32(reader["STOCK"]),
                        Status = reader["STATUS"].ToString(),
                        Category = reader["CATEGORY"].ToString()
                    };
                    products.Add(product);
                }
            }

            return products;
        }

        public ProductModel GetById(int productId)
        {
            using (OracleConnection connection = new OracleConnection(_sqlConnectionString))
            {
                string query = "SELECT * FROM PRODUCTS WHERE PRODUCT_ID = :ProductId";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":ProductId", OracleDbType.Int32).Value = productId;

                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ProductModel product = new ProductModel
                    {
                        Id = Convert.ToInt32(reader["PRODUCT_ID"]),
                        Brand = reader["BRAND"].ToString(),
                        Model = reader["MODEL"].ToString(),
                        Description = reader["DESCRIPTION"].ToString(),
                        Price = Convert.ToDecimal(reader["PRICE"]),
                        Stock = Convert.ToInt32(reader["STOCK"]),
                        Status = reader["STATUS"].ToString(),
                        Category = reader["CATEGORY"].ToString()
                    };
                    return product;
                }
                else
                {
                    throw new Exception("Product not found.");
                }
            }
        }

        public IEnumerable<ProductModel> SearchByName(string productName)
        {
            List<ProductModel> products = new List<ProductModel>();

            using (OracleConnection connection = new OracleConnection(_sqlConnectionString))
            {
                string query = "SELECT * FROM PRODUCTS WHERE UPPER(BRAND) LIKE UPPER(:ProductName)";
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":ProductName", OracleDbType.Varchar2).Value = "%" + productName + "%";

                connection.Open();
                OracleDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ProductModel product = new ProductModel
                    {
                        Id = Convert.ToInt32(reader["PRODUCT_ID"]),
                        Brand = reader["BRAND"].ToString(),
                        Model = reader["MODEL"].ToString(),
                        Description = reader["DESCRIPTION"].ToString(),
                        Price = Convert.ToDecimal(reader["PRICE"]),
                        Stock = Convert.ToInt32(reader["STOCK"]),
                        Status = reader["STATUS"].ToString(),
                        Category = reader["CATEGORY"].ToString()
                    };
                    products.Add(product);
                }
            }

            return products;
        }

        public void Update(ProductModel product)
        {
            using (OracleConnection connection = new OracleConnection(_sqlConnectionString))
            {
                string query = "UPDATE PRODUCTS SET BRAND = :Brand, MODEL = :Model, DESCRIPTION = :Description, " +
                               "PRICE = :Price, STOCK = :Stock, STATUS = :Status, CATEGORY = :Category " +
                               "WHERE PRODUCT_ID = :ProductId";

                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(":Brand", OracleDbType.Varchar2).Value = product.Brand;
                command.Parameters.Add(":Model", OracleDbType.Varchar2).Value = product.Model;
                command.Parameters.Add(":Description", OracleDbType.Varchar2).Value = product.Description;
                command.Parameters.Add(":Price", OracleDbType.Decimal).Value = Convert.ToDecimal(product.Price);
                command.Parameters.Add(":Stock", OracleDbType.Int32).Value = product.Stock;
                command.Parameters.Add(":Status", OracleDbType.Varchar2).Value = product.Status;
                command.Parameters.Add(":Category", OracleDbType.Varchar2).Value = product.Category;
                command.Parameters.Add(":ProductId", OracleDbType.Int32).Value = product.Id;

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected <= 0)
                {
                    throw new Exception("Failed to update product.");
                }
            }
        }
    }
}
