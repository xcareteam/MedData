using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace XCare.DMS.DataProc.DAL
{
    internal class DbHelper
    {
        private static readonly string XCareConnectionString = ConfigurationManager.AppSettings["XCareConnectionString"];

        public static IDbConnection GetDbConnection()
        {
            var connection = new SqlConnection(XCareConnectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }
    }
}