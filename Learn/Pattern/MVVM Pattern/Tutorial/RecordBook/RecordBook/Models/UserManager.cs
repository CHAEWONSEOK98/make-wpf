using System.Collections.ObjectModel;

namespace RecordBook.Models
{
    public class UserManager
    {
        public static ObservableCollection<User> _DatabaseUsers = new ObservableCollection<User>()
        {
            new User() {Email="user1@gmail.com", Name="user1"},
            new User() {Email="user2@gmail.com", Name="user2"},
            new User() {Email="user3@gmail.com", Name="user3"},
            new User() {Email="user4@gmail.com", Name="user4"},
        };

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
