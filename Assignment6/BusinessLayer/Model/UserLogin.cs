using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;

namespace BusinessLayer.Model
{
    public class UserLogin
    { 
        /// <summary>
        /// Object of database layer
        /// </summary>

        DataLayer objDataLayer = new DataLayer();

        /// <summary>
        /// message to validate property
        /// </summary>
        public const string msgString = "Please enter the required field";      

        /// <summary>
        /// Privatae variables
        /// </summary>
        
        private string _userName;
        private string _password;

        /// <summary>
        /// Method to validate string property value 
        /// </summary>
        /// <param name="str">value</param>
        /// 
        public void ValidateStringProperty(string str)
        {
            if (str == string.Empty)
            {
                throw new Exception(msgString);
            }
        }

        /// <summary>
        /// Public Properties
        /// </summary>

        /// <summary>
        ///Public property for User Name
        /// </summary> 
        
        public string UserName {
            get
            { 
                return _userName;
            }
            set
            {
               ValidateStringProperty(value);
              _userName = value;
            }
        }

        /// <summary>
        ///Public property for Password
        /// </summary> 
        /// 
        public string Password {
            get
            { 
                return _password;
            }
            set
            {
               ValidateStringProperty(value);
              _password = value;
            }
        }

      /// <summary>
      /// method to login
      /// </summary>
      /// <param name="userName">User Name of the User</param>
      /// <param name="password">Password f the User</param>
      /// <returns>returns bool value to authenticate the user</returns>
      
        public bool Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
           return objDataLayer.Login(UserName, Password);
        }

       /// <summary>
       /// method to get User Type
       /// </summary>
       /// <param name="userName">USer Name</param>
       /// <param name="password">Password</param>
       /// <returns>Returns User Type</returns>
       
        public string GetUserType(string userName, string password)
        {
            UserName = userName;
            Password = password;
            return objDataLayer.UserType(UserName, Password);
        }

        /// <summary>
        /// method to get User ID
        /// </summary>
        /// <param name="userName">User Name</param>
        /// <param name="password">Password</param>
        /// <returns>Returns current User's Id</returns>
        
        public int GetUserId(string userName, string password)
        {
            UserName = userName;
            Password = password;
            return objDataLayer.UserId(UserName, Password);
        }
    }
}
