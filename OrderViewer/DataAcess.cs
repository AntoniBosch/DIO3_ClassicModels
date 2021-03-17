using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderViewer
{
    class DataAcess
    {
        string connectionString = "Server=localhost;Port=3306;Database=classicmodels;Uid=ClassicModelsAdmin;Pwd=tB847512963";

        public List<OrderDetail> GetOrderDetail(int orderNumber)
        {
            
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT orderNumber, orderDate, requiredDate, shippedDate, status" +
                    $" FROM orderdetails " +
                    $" NATURAL JOIN products " +
                    $" NATURAL JOIN orders " +
                    $" where orderNumber = {orderNumber}";
                var orderDetail = connection.Query<OrderDetail>(sql).ToList();
                return orderDetail;
            }             
        }

        public List<OrderLine> GetOrdersLines(int orderNumber)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT productName, quantityOrdered, priceEach, image " +
                    $" FROM productlines " +
                    $" NATURAL JOIN products " +
                    $" NATURAL JOIN orderdetails " +
                    $" WHERE orderNumber = {orderNumber}";

                var orderLines = connection.Query<OrderLine>(sql).ToList();
                return orderLines;
            }
        }
    }
}
