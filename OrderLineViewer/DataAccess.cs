using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLineViewer
{
    class DataAccess
    {
        string connectionString = "Server=localhost;Port=3306;Database=classicmodels;Uid=ClassicModelsAdmin;Pwd=tB847512963";

        public List<String> GetProductLines()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string sql = $"SELECT productLine FROM productlines";
                var productLines = connection.Query<String>(sql).ToList();
                return productLines;
            }
        }


        public Photo GetNewImage(String name)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                var parameters = new { _name = name };
                var newImage = connection.Query<Photo>("cm_getRandomPhoto", parameters, commandType: System.Data.CommandType.StoredProcedure).FirstOrDefault();
                return newImage;
            }
        }
    }
}
