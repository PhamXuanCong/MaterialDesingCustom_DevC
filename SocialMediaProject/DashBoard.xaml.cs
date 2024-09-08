using System.Windows.Controls;
using WpfApp1.SubViewModel;

namespace WpfApp1;

public partial class DashBoard : UserControl
{
    public DashBoard()
    {
        InitializeComponent();
        DataContext = new DashBoardViewModel();
    }
}