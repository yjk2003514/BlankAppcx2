using BlankAppcx2.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace BlankAppcx2.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : UserControl
    {
        //MainWindow 解释：MainWindow.xaml.cs 代码文件中的类名必须与 XAML 文件中的类名相同。
        public MainWindow()
        {
            //InitializeComponent 解释：在 MainWindow.xaml.cs 代码文件中，必须调用 InitializeComponent() 方法。
            InitializeComponent();
            this.DataContext = new ViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //this.DataContext = new TestStationViewModel();
            TestStationWindow login1 = new TestStationWindow();   //Login为窗口名，把要跳转的新窗口实例化
           
        }
    }
}
