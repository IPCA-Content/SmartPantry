

using SmartPantry.Models.Services;

namespace SmartPantry.ViewModels.Services
{
    class AuthService : IAuthService
    {
        public AuthService()
        {
            
        }


        public bool Register(string username, string password, string repeatPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatPassword))
            {
                return false;
            }

            if (password != repeatPassword)
            {
                return false;
            }

            // call the UserService to create the user
            UserService userService = new (); // temp
            return userService.CreateUser(username, password);
        }
    }
}
