using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace DapperInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection connection = new MySqlConnection(connString);

            var repo = new DapperProductRepository(connection);

            repo.CreateProduct("newstuff", 20, 1);

            var products = repo.GetAllProducts();

            foreach(var prod in products)
            {
                Console.WriteLine($"{prod.ProductID} {prod.Name}");
            }

        }
    }
}

