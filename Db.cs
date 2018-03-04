using System.Data;
using System.Data.SqlClient;

namespace dapperapi
{
    public class Db
    {
        public static IDbConnection GetOpenConnection()
        {
            var connString = "server=gofix-aurora-cluster.cluster-cagxvjjculzx.us-east-1.rds.amazonaws.com;uid=gofix;database=dev;pwd=q1w2e3r4";

            var connection = new MySql.Data.MySqlClient.MySqlConnection(connString);

            connection.Open();
            return connection;
        }
    }
}