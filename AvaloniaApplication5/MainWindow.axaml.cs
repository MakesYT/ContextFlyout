using System.Collections.ObjectModel;
using Avalonia;
using Avalonia.Controls;
using Core.SDKs.CustomScenario;
using NodifyM.Avalonia.ViewModelBase;

namespace AvaloniaApplication5;

public partial class MainWindow : Window
{
    public ObservableCollection<PointItem> nodes
    {
        get;
        set;
    } = new();
    public MainWindow()
    {
        DataContext= this;
        InitializeComponent();
        var pointItem = new PointItem()
        {
            Location = new Point(100, 100),
            Title = "T",
        };
        pointItem.Input = new ()
        {
            new ConnectorItem()
            {
                Source = pointItem,
                Type = typeof(string),
                Title = "流输入",
                TypeName = "节点"
            },
            new ConnectorItem()
            {
                Source = pointItem,
                Type = typeof(string),
                RealType = typeof(string),
                InputObject = "",
                Title = "本地项目",
                TypeName = "字符串",
                IsSelf = true
            }
        };
        nodes.Add(pointItem);
    }
}