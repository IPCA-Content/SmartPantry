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
    internal class LoginViewModel : BaseAuthViewModel
    {

        #region Properties

        /// <summary>
        /// Gets the command that opens the main window.
        /// </summary>
        public ICommand LoginCommand { get; }

        public ICommand RegisterCommand { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the login state and command.
        /// </summary>
        public LoginViewModel()
        {
            _username = "Gil Vicente";

            LoginCommand = new RelayCommand(Login);
            RegisterCommand = new RelayCommand(Register);
        }

        #endregion

    }
}
