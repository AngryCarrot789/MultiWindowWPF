using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MultiWindowWPF.Core {
    public abstract class BaseViewModel {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Triggers the given propertyName to be updated in the UI, and set the ref field to newValue
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="field"></param>
        /// <param name="newValue"></param>
        /// <param name="propertyName"></param>
        public void RaisePropertyChanged<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null) {
            field = newValue;
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
