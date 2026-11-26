using SmartPantry.ViewModels;
using System.Windows;

namespace SmartPantry.Views
{
    /// <summary>
    /// Displays the registration interface.
    /// </summary>
    public partial class RegisterWindow : Window
    {
        #region Constructors

        /// <summary>
        /// Initializes the registration window.
        /// </summary>
        public RegisterWindow()
        {
            RegisterViewModel registerViewModel = new();
            DataContext = registerViewModel;
            InitializeComponent();
        }

        #endregion
    }
}
