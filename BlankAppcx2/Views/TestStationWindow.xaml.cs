using BlankAppcx2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlankAppcx2.Views
{
    /// <summary>
    /// TestStationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class TestStationWindow : UserControl
    {
        public TestStationWindow()
        {
            //InitializeComponent 解释：在 TestStationWindow.xaml.cs 代码文件中，必须调用 InitializeComponent() 方法。
            InitializeComponent();
            this.DataContext = new TestStationViewModel();
        }
    }
////:Application
//{
//    //protected override Window CreateShell()
//    //{
//    //    return Container.Resolve<MainWindow>();
//    //}

//    private void TestStationWindow(object sender, StartupEventArgs e)
//    {
//        Application.Current.StartupUri = new Uri("Viess/TestStationWindow.xaml", UriKind.Relative);
//    }
//}
}

