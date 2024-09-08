using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace WpfApp1.SubViewModel;

public class DashBoardViewModel :INotifyPropertyChanged
{
    public SeriesCollection SeriesCollection { get; set; }
    public SeriesCollection LastHourSeries { get; set; }
    public SeriesCollection LastHourSeries1 { get; set; }
    public string[] Labels { get; set; }
    public Func<double,string> Formatter { get; set; }
    public DashBoardViewModel()
    {
        //Get data chart
        SeriesCollection = new SeriesCollection
        {
            new StackedColumnSeries
            {
                Values = new ChartValues<double> {25,52,61,89},
                StackMode = StackMode.Values,
                DataLabels = true
            },
            new StackedColumnSeries
            {
                Values = new ChartValues<double> {-15,-75,-16,-49},
                StackMode = StackMode.Values,
                DataLabels = true
            }
        };
        
        LastHourSeries = new SeriesCollection
        {
            new LineSeries
            {
                AreaLimit = -10,
                Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(3),
                    new ObservableValue(1),
                    new ObservableValue(9),
                    new ObservableValue(4),
                    new ObservableValue(5),
                    new ObservableValue(3),
                    new ObservableValue(1),
                    new ObservableValue(2),
                    new ObservableValue(3),
                    new ObservableValue(7),
                }
            }
        };
        LastHourSeries1 = new SeriesCollection
        {
            new LineSeries
            {
                AreaLimit = -10,
                Values = new ChartValues<ObservableValue>
                {
                    new ObservableValue(13),
                    new ObservableValue(11),
                    new ObservableValue(9),
                    new ObservableValue(14),
                    new ObservableValue(5),
                    new ObservableValue(3),
                    new ObservableValue(12),
                    new ObservableValue(2),
                    new ObservableValue(3),
                    new ObservableValue(7),
                }
            }
        };
        
        Labels = new[] { "Feb 7", "Feb 8", "Feb 9", "Feb 10" };
        Formatter = value => value.ToString();
        
        string imgCartoon = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString()}\\Images\\cartoon-woman-pretty.png";
        string imgavatar = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString()}\\Images\\avatar1.jpg";
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