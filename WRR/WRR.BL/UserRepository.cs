using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRR.BL
{
    public class UserRepository
    {
        public User Retrieve(int userId)
        {
            User user = new User(userId);

            if(userId == 1)
            {
                user.Email = "hamidkhbl@gmail.com";
                user.FirstName = "Hamid";
                user.LastName = "Khbl";
            }

            return user;
        }

        public bool Save(User user)
        {
            return true;
        }
    }
}
