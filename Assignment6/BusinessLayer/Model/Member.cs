using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBaseLayer;

namespace BusinessLayer.Model
{
    public class Member
    {
        /// <summary>
        /// Create Object of Data Layer
        /// </summary>
        public DataLayer objDataLayer = new DataLayer();

        /// <summary>
        /// message to validate property
        /// </summary>
        public const string msgString = "Please enter the required field";
        public const string msgInt = "Please enter the valid value";

        /// <summary>
        /// Private variable declaration
        /// </summary>
        private string _MemberName;
        private string _MemberAddress;
        private int _RoleId;
        private string _UserName;
        private string _Password;

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
        /// Method to validate integer property value 
        /// </summary>
        /// <param name="str">value</param>
        /// 
        public void ValidateIntProperty(int value)
        {
            if (value <= 0)
            {
                throw new Exception(msgInt);
            }
        }

        /// <summary>
        /// Public Properties Declaration
        /// </summary>
        /// 

        /// <summary>
        ///Public property for Member Name
        /// </summary> 
        
        public string MemberName {
            get
            { return _MemberName ;
            }
            set {
                ValidateStringProperty(value);
                _MemberName =value ;
                }
                                    }
        /// <summary>
        ///Public property for Member Address
        /// </summary> 
        
        public string MemberAddress
        {
            get
            { return _MemberAddress; }
            set
            {
                ValidateStringProperty(value);
                _MemberAddress = value;
            }
        }

        /// <summary>
        ///Public property for RoleId
        /// </summary> 
       
        public int RoleId {
            get
            {
               return _RoleId ;
            } 
            set
            {
                ValidateIntProperty(value);
                _RoleId = value;
            }
                            }

        /// <summary>
        ///Public property for UserName
        /// </summary> 
       
        public string UserName {
            get
            {
               return _UserName ;
            }
            set
            {
                ValidateStringProperty(value);
              _UserName = value;
            }
                                }
        /// <summary>
        ///Public property for Password
        /// </summary> 
        /// 
        public string Password {
            get
            {
                return _Password;
            }
            set
            {
                ValidateStringProperty(value);
                _Password = value;
            } 
                            }

        /// <summary>
        /// Load Members from database
        /// </summary>
        /// <returns>Members</returns>
        public Object LoadMembers()
        {
           return objDataLayer.LoadMembers();
        }

        /// <summary>
        /// Add Members to database
        /// </summary>
        /// <param name="memberName">Name of the Member</param>
        /// <param name="memberAddress">Address of the member</param>
        /// <param name="roleID">Role Id of the Member</param>
        /// <param name="userName">User Name of the member</param>
        /// <param name="password">Password of the member</param>
        public void AddMember(string memberName, string memberAddress, int roleID, string userName, string password)
        {
            MemberName = memberName;
            MemberAddress = memberAddress;
            RoleId = roleID;
            UserName = userName;
            Password = password;
            objDataLayer.AddMember(MemberName, MemberAddress, RoleId, UserName, Password);
        }

  
    }
}
