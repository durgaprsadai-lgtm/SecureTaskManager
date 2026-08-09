using SecureTaskManager.Models;

namespace SecureTaskManager.Services
{
    public class UserService
    {
        private readonly List<User> _users = new();

        public User? ValidateUser(string username, string password)
        {
            return _users.FirstOrDefault(u => u.Username == username && u.Password == password);
        }

        public void Register(User user)
        {
            _users.Add(user);
        }
    }
}
