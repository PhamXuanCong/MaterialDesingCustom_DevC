using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Microsoft.Xaml.Behaviors.Core;

namespace WpfApp1;

public class SocialViewModel:INotifyPropertyChanged
{

    #region RelayCommand

    public ICommand CloseCmd { get; set; }
    

    #endregion
    public SocialViewModel(MainWindow mainView)
    {
        CloseCmd = new ActionCommand(x => { mainView.Close(); });
    }
    
    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}