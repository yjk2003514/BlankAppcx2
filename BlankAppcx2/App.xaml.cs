using BlankAppcx2.Views;
using Prism.Ioc;
using System.Windows;

namespace BlankAppcx2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<YeMian>();
            //物料配置页维护-测试工位-BS  TestStationWindow//物料配置页维护-BS  MainWindow
            //1.3关键键采集-CS  KeyComponentsWindow
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
