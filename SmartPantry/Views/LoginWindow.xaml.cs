using SmartPantry.ViewModels;
using System.Windows;

namespace SmartPantry.Views
{
    /// <summary>
    /// Displays the login interface.
    /// </summary>
    public partial class LoginWindow : Window
    {
        #region Constructors

        /// <summary>
        /// Initializes the login window and its view model.
        /// </summary>
        public LoginWindow()
        {
            LoginViewModel loginViewModel = new();
            DataContext = loginViewModel;
            InitializeComponent();
        }

        #endregion
    }
}
