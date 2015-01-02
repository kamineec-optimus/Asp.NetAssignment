using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace AdoDotNetObjectCaching
{
    /// <summary>
    /// This Class will handle the database connections and operations
    /// </summary>
    public class DataBaseOperation
    {
        public const string getEmployeeData="select Id,First_Name,Salary from Employee";
        /// <summary>
        /// Connection string
        /// </summary>
        private string connectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        /// <summary>
        /// Using DataSet for objects caching 
        /// </summary>
        /// <returns>DataSet containing Employee information</returns>
        public DataSet GetData()
        {            
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            DataSet employeeDataSet = new DataSet();
            SqlCommand sqlCommand = new SqlCommand(getEmployeeData, sqlConnection);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(employeeDataSet);
            sqlConnection.Close();     
            return employeeDataSet;            
        }

        
    }
}