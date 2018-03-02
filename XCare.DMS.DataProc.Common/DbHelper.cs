using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace XCare.DMS.DataProc.Common
{
    public class DbHelper
    {
        private const string DEFAULT_APPLICATION_NAME = "xcare";
        private static readonly string XCareConnectionString;

        static DbHelper()
        {
            XCareConnectionString = ConfigurationManager.AppSettings["XCareConnectionString"];
            var builder = new SqlConnectionStringBuilder(XCareConnectionString);
            ApplicationName = string.IsNullOrWhiteSpace(ApplicationName)
                ? DEFAULT_APPLICATION_NAME
                : builder.ApplicationName;
        }

        public static string ApplicationName { get; set; }

        public static IDbConnection GetDbConnection()
        {
            var connection = new SqlConnection(XCareConnectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }
    }
}