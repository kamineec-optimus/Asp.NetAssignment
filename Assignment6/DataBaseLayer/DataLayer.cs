using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace DataBaseLayer
{
    public class DataLayer
    {
        /// <summary>
        /// Connection string
        /// </summary>
        private string ConnectionString = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;

        /// <summary>
        /// Sql Queries
        /// </summary>
        public const string InsertBooks = "insert into Books(Book_Name,Author_Name,Price,Quantity)values('{0}','{1}',{2},{3})";
        public const string SelectBook = "select * from Books";
        public const string SelectMembers = "select Id,Name,Address,RoleId from Members";
        public const string InsertMember = "Insert into Members(Name,Address,RoleId,UserName,Password) values('{0}','{1}',{2},'{3}','{4}')";
        public const string LoginMember = "select count(*) from Members where UserName='{0}' and Password= '{1}'";
        public const string GetUserType = "select Role.Role from  Role inner join Members on Role.RoleId = Members.RoleId where Members.UserName= '{0}' and Members.Password= '{1}'  ";
        public const string GetUserId = "select Id from Members where UserName= '{0}' and Password = '{1}'";
        public const string IssueBooks = "insert into IssueBook values('{0}', '{1}',{2})";
        public const string IssuedBook = "select * from IssueBook where Id = {0}";
        public const string UpdateIssuedBook =  "Update Books set Quantity= Quantity-1 where Book_Name='{0}' and Author_Name='{1}'";
        public const string RemoveReturnedBook = " delete from IssueBook where Book_Name='{0}'and Author_Name = '{1}'";
        public const string UpdateReturnedBook = "Update Books set Quantity= Quantity+1 where Book_Name='{0}' and Author_Name='{1}'";
        
        /// <summary>
        /// method to create conection for all delete, update and insert operation
        /// </summary>
        /// <param name="strQuery">databse query</param>
        public void InsertUpdateDelete(string strQuery)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(strQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// method to fetch data from database
        /// </summary>
        /// <param name="strQuery">database query</param>
        /// <returns></returns>
        public object ExecuteSQLString(string strQuery)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand(strQuery, con);
            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            dr.Fill(ds);
            return ds;
        }
        /// <summary>
        /// Method to create connection and return a value
        /// </summary>
        /// <param name="str">Sql Query</param>
        /// <returns>Returns values from the back end</returns>

        public object GetSqlConnection(string str)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand(str, con);
            object value = cmd.ExecuteScalar();
            con.Close();
            return value;
        }
        
        /// <summary>
        /// Method to load Books from Database
        /// </summary>
        /// <returns>Returns a data set containing books</returns>
        
        public object LoadBooks()
        {
            DataSet ds = new DataSet();
            string str = SelectBook;
            ds = (DataSet)ExecuteSQLString(str);
            return ds;
        }

       /// <summary>
        /// Method to load Books from Database
       /// </summary>
       /// <param name="bookName">BLibraryBook Name</param>
       /// <param name="author">Author of the book</param>
       /// <param name="price">Price of each book</param>
       /// <param name="quantity">Quantity of the books</param>
       
        public void AddNewBook(string bookName, string author, int price, int quantity)
        {
            string str = string.Format(InsertBooks, bookName, author, price, quantity);
            InsertUpdateDelete(str);
        }

        /// <summary>
        /// Method to return Members
        /// </summary>
        /// <returns>Returns members from database</returns>
        
        public object LoadMembers()
        {
            DataSet ds = new DataSet();
            string str = SelectMembers;
            ds = (DataSet)ExecuteSQLString(str);
            return ds;
        }

        /// <summary>
        /// Method to add members to database
        /// </summary>
        /// <param name="memberName">Name of the Member</param>
        /// <param name="memberAddress">Address of the member</param>
        /// <param name="roleID">RoleId of the member</param>
        /// <param name="userName">User Name of the member</param>
        /// <param name="password">Password of the Member</param>
        
        public void AddMember(string memberName, string memberAddress, int roleID, string userName, string password)
        {
            string str = string.Format(InsertMember, memberName, memberAddress, roleID, userName, password);
            InsertUpdateDelete(str);
        }

        /// <summary>
        /// Method to login
        /// </summary>
        /// <param name="userName"> User Name of the user</param>
        /// <param name="password">Password of the user</param>
        /// 
        
        public bool Login(string userName, string password)
        {
            string str = string.Format(LoginMember, userName, password);
            int Count = Convert.ToInt32(GetSqlConnection(str));                 
            if (Count >= 1)
            return true;
            else
            return false;                   
        }

        /// <summary>
        /// Method to get the type of User
        /// </summary>
        /// <param name="userName">UserName of the User</param>
        /// <param name="password">Password Of the User</param>
        /// <returns>User Type</returns>

     
        public string UserType(string userName, string password)
        {
            string str = string.Format(GetUserType, userName, password);
            return GetSqlConnection(str).ToString();             

        }

        /// <summary>
        /// Method to get the User Ids
        /// </summary>
        /// <param name="userName">UserName of the User</param>
        /// <param name="password">Password Of the User</param>
        /// <returns>Id of the Current User</returns>
       
        public int UserId(string userName, string password)
        {
            string str = string.Format(GetUserId, userName, password);
            return Convert.ToInt32(GetSqlConnection(str));   
        }

        /// <summary>
        /// Methos to insert issued book
        /// </summary>
        /// <param name="bookName">Book Name</param>
        /// <param name="authorName">Author Name</param>
        /// <param name="id">Id of the current loggedin User</param>
        
        public void InsertIssueBook(string bookName, string authorName, int id)
        {
            string str = string.Format(IssueBooks, bookName, authorName, id);
            InsertUpdateDelete(str);
        }

        /// <summary>
        /// Method to load Issued book 
        /// </summary>
        /// <returns>Returns issued book</returns>
         
        public object LoadIssuedBook(int id)
        {
            DataSet ds = new DataSet();
            string str = string.Format(IssuedBook, id);
            ds = (DataSet)ExecuteSQLString(str);
            return ds;
        }

        /// <summary>
        /// Metod to Remove book from Library
        /// </summary>
        /// <param name="bookName">Name of the Book</param>
        /// <param name="authorName">Author Name of the Book</param>
       
        public void UpdateIssuedBooks(string bookName, string authorName)
        {
            string str = string.Format(UpdateIssuedBook, bookName, authorName);
            InsertUpdateDelete(str);
        }

        /// <summary>
        /// Add issued book to library 
        /// </summary>
        /// <param name="bookName">Book Name</param>
        /// <param name="authorName">Author Name</param>
        
        public void RemoveReturnedBooks(string bookName, string authorName)
        {
            string str = string.Format(RemoveReturnedBook, bookName, authorName);
            InsertUpdateDelete(str);
        }

        /// <summary>
        /// Method to update quantity of the issued book
        /// </summary>
        /// <param name="bookName">BLibraryBook Name</param>
        /// <param name="authorName">Author Name</param>
         
        public void UpdateReturnedBooks(string bookName, string authorName)
        {
            string str = string.Format(UpdateReturnedBook, bookName, authorName);
            InsertUpdateDelete(str);
        }

       
    }
}
