using CommunityToolkit.Mvvm.Input;
using SmartPantry.ViewModels.Common;
using System.Windows.Input;

namespace SmartPantry.ViewModels
{
    /// <summary>
    /// Represents the registration window's view model.
    /// </summary>
    internal class RegisterViewModel : BaseAuthViewModel
    {
        #region Properties

        /// <summary>
        /// Gets the command that opens the main window.
        /// </summary>
        public ICommand? LoginCommand { get; }

        /// <summary>
        /// Gets the command that opens the windows.
        /// </summary>
        public ICommand? RegisterCommand { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the login state and command.
        /// </summary>
        public RegisterViewModel()
        {
            _username = "Gil Vicente - Register";

            RegisterCommand = new RelayCommand(RegisterLogin);

        }

        #endregion
    }
}
