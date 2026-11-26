using SmartPantry.Views;
using System.Windows;

namespace SmartPantry.ViewModels.Common
{
    /// <summary>
    /// Provides property change notifications for view models.
    /// </summary>
    internal abstract class BaseAuthViewModel : BaseViewModel
    {
        #region Fields

        protected string _username = string.Empty;

        protected string _password = string.Empty;

        protected string _password_repeat = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the username entered for login.
        /// </summary>
        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
                //ValidateProperty(nameof(Username), value);
            }
        }

        /// <summary>
        /// Gets or sets the username entered for login.
        /// </summary>
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
                //ValidateProperty(nameof(Password), value);
            }
        }

        /// <summary>
        /// Gets or sets the username entered for login.
        /// </summary>
        public string PasswordRepeat
        {
            get => _password_repeat;
            set
            {
                _password_repeat = value;
                OnPropertyChanged(nameof(PasswordRepeat));
                //ValidateProperty(nameof(PasswordRepeat), value);
            }
        }

        #endregion


        #region Methods

        /// <summary>
        /// Opens the main window and closes the login window if it is open.
        /// </summary>
        protected void Login()
        {
            Window? loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();

            MainWindow mainWindow = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            mainWindow.Show();

            loginWindow?.Close();
        }

        /// <summary>
        /// Opens the registration window and closes the login window if it is open.
        /// </summary>
        protected void Register()
        {
            Window? loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();

            RegisterWindow registerWindow = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            registerWindow.Show();

            loginWindow?.Close();
        }

        /// <summary>
        /// Opens the registration window and closes the login window if it is open.
        /// </summary>
        protected void RegisterLogin()
        {
            Window? registerWindow = Application.Current.Windows.OfType<RegisterWindow>().FirstOrDefault();

            LoginWindow loginWindow = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            loginWindow.Show();

            registerWindow?.Close();
        }


        #endregion
    }
}
