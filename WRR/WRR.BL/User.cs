using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRR.BL
{
    public class User
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string FullName
        {
            get {
                if(string.IsNullOrWhiteSpace(LastName))
                {
                    return FirstName;
                }
                else if (string.IsNullOrWhiteSpace(FirstName))
                {
                    return LastName;
                }
                return FirstName+" "+LastName; 
            }
        }

        public static int InstanceCount { get; set; }
        public DateTime Created { get; set; }

        /// <summary>
        /// Validate the user data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Username)) isValid = false;
            if (string.IsNullOrWhiteSpace(Email)) isValid = false;

            return isValid;
        }
    }
}
