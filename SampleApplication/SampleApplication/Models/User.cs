
using System.ComponentModel.DataAnnotations;
namespace SampleApplication.Models
{
    /// <summary>
    /// User Class will have the user information
    /// </summary>
    public class User
    {
        /// <summary>
        /// Public properties
        /// </summary>        
        public string FirstName { get; set; }       
        public string UserName { get; set; }        
        public string Password { get; set; }        
        public string EmailId { get; set; }
    }
}