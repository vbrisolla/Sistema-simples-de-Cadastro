using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC1.Models
{
    public class UserManager
    {

        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>() { new User() { Email = "juca@gmail.com", Name = "Juca Louco" }, new User() { Email = "vini@gmail.com", Name = "Vini Briso" }, new User() { Email = "Mari@gmail.com", Name = "Mari Dance" } };

        public static ObservableCollection<User> GetUsers()
        {
            return _DatabaseUsers;
        }

        public static void AddUser(User user)
        {
            _DatabaseUsers.Add(user);
        }




    }
}
