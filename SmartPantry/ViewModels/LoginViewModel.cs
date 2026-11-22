using CommunityToolkit.Mvvm.Input;
using SmartPantry.ViewModels.Common;
using System.Windows;
using System.Windows.Input;
using System.Linq;
using SmartPantry.Views;

namespace SmartPantry.ViewModels
{
    /// <summary>
    /// Holds login state and opens the main window when login is requested.
    /// </summary>
    internal class LoginViewModel : BaseViewModel
    {
        #region Fields

        private string _username = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// Gets the command that opens the main window.
        /// </summary>
        public ICommand LoginCommand { get; }

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

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the login state and command.
        /// </summary>
        public LoginViewModel()
        {
            _username = "Gil Vicente";

            LoginCommand = new RelayCommand(Login);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Opens the main window and closes the login window if it is open.
        /// </summary>
        private void Login()
        {
            Window? loginWindow = Application.Current.Windows.OfType<LoginWindow>().FirstOrDefault();

            MainWindow mainWindow = new()
            {
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            mainWindow.Show();

            loginWindow?.Close();
        }

        #endregion
    }
}
