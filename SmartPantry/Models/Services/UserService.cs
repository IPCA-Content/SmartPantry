
using SmartPantry.Models.Entities;
using System.IO;
using System.Text.Json;

namespace SmartPantry.Models.Services
{
    public class UserService
    {
        string basePath = Path.Combine("." +  Path.DirectorySeparatorChar, "Data");

        public UserService()
        {
            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
            }
        }

        public bool CreateUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false;
            }

            User newUser = new User
            {
                Username = username,
                Password = password,
                CreatedAt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                string userString = JsonSerializer.Serialize(newUser, options);
                File.WriteAllText(Path.Combine(basePath, "users.json"), userString);
            }
            catch (IOException ex)
            {
                // Handle io exception log diff
                return false;
            }
            catch (Exception ex)
            {
                // Handle exception
                return false;
            }

            return true;
        }
    }
}
