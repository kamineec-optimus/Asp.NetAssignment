//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment32
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public partial class UserDetail
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MobileNo { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
    
        public virtual UserRole UserRole { get; set; }

        /// <summary>
        /// method to perform login 
        /// </summary>
        /// <param name="userName">User Name of the User</param>
        /// <param name="password">Password of the User</param>
        public int UserLogin(string userName, string password)
        {
            //object of EntityFrameworkEntities class 
            var context = new EntityFrameworkEntities();  
            //match username and password
            var query = context.UserDetails.Where(p => p.UserName == userName && p.Password== password ).FirstOrDefault();
            //if username password match then retrive the roleId
            if (query != null)
            {
                return query.RoleId;
            }
            else
            {
                return 0;
            }         
          }    
             
    }
}
