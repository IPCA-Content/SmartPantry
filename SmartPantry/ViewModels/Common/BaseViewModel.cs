using System.ComponentModel;

namespace SmartPantry.ViewModels.Common
{
    /// <summary>
    /// Provides property change notifications for view models.
    /// </summary>
    internal abstract class BaseViewModel : INotifyPropertyChanged
    {
        #region Events

        /// <summary>
        /// Occurs when a property value changes.
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        #endregion

        #region Methods

        /// <summary>
        /// Notifies listeners that a property value has changed.
        /// </summary>
        /// <param name="propertyName">The name of the changed property.</param>
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
