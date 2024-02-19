using System.ComponentModel;
using System.Runtime.CompilerServices;


namespace StepperBindingIncrement.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void RaisePropertyChanged([CallerMemberName] string property = null)
           => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        public bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string property = null)
        {
            if (object.Equals(storage, value))
                return false;

            storage = value;
            RaisePropertyChanged(property);
            return true;
        }
    }
}
