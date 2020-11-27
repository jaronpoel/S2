using Interfaces.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Context;

namespace Logic
{
    public class UserCollection
    {
        private UserSqlContext userSqlContext { get; } = new UserSqlContext();
        
        public void SignUp(string username, string password, string email)
        {
            userSqlContext.SignUp(username, password, email);
        }

        public User SignIn(string username, string password)
        {
            UserDto userdto = userSqlContext.SignIn(username, password);
            User user = new User(userdto.Id, userdto.Username);
            return user;
        }

        public User MakingTeam()
        {
            throw new NotImplementedException();
        }
    }
}
