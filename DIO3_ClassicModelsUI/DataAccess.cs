using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DIO3_ClassicModelsUI
{
    class DataAccess
    {
        string connectionString = "Server=localhost;Port=3306;Database=classicmodels;Uid=ClassicModelsAdmin;Pwd=";

        public List<Customer> getClientNames(String data)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                var parameters = new { _name = data };
                var clientNames = connection.Query<Customer>("cm_getNames", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                
                return clientNames;
            }
        }

        public List<Order> getOrdersByName(String customerName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                var parameters = new { _name = customerName };                
                var orders = connection.Query<Order>("cm_getOrdersByName", parameters, commandType: System.Data.CommandType.StoredProcedure).ToList();
                return orders;
            }
        }
    }
}
