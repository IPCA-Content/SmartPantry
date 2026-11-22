using SmartPantry.Views;
using System.Windows;

namespace SmartPantry
{
    /// <summary>
    /// Starts the application and displays the login window.
    /// </summary>
    public partial class App : Application
    {
        #region Startup

        /// <summary>
        /// Displays the login window when the application starts.
        /// </summary>
        /// <param name="sender">The source of the startup event.</param>
        /// <param name="e">The startup event data.</param>
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            LoginWindow loginWindow = new();
            loginWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            loginWindow.ShowDialog();
        }

        #endregion
    }

}
