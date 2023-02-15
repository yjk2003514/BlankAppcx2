using BlankAppcx2.Model;
using BlankAppcx2.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
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
using static BlankAppcx2.ViewModels.KeyComponentsViewModel;

namespace BlankAppcx2.Views
{
    /// <summary>
    /// KeyComponentsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class KeyComponentsWindow : UserControl
    {
        public KeyComponentsWindow()
        {
            //InitializeComponent 是一个方法，用于初始化窗体的一些属性，比如窗体的大小，窗体的标题等等
            InitializeComponent();
            this.DataContext = new KeyComponentsViewModel();
        }
        public void Button_Click1(object sender, RoutedEventArgs e)
        {
            //这里可以看出Tag是object，可以存放任意数据类型
            int Id = Convert.ToInt32((sender as Button).Tag);
            HttpClient client = new HttpClient();
            string url = "https://localhost:44311/api/services/app/GearCaseTableService/Delete?Id=" + Id;
            var response = client.DeleteAsync(url);
            var responseString = response.Result.Content.ReadAsStringAsync();
            KeyComponentsViewModel viewModel = new KeyComponentsViewModel();
            viewModel.GetAll3();
        }

        public void Button_Click2(object sender, RoutedEventArgs e)
        {
            //这里可以看出Tag是object，可以存放任意数据类型

            int Id = Convert.ToInt32((sender as Button).Tag);
            HttpClient client = new HttpClient();
            string url = "https://localhost:44311/api/services/app/ElectricalMachineryTableService/Delete?Id=" + Id;
            var response = client.DeleteAsync(url);
            var responseString = response.Result.Content.ReadAsStringAsync();
            KeyComponentsViewModel viewModel = new KeyComponentsViewModel();
            viewModel.GetAll2();
        }

        public void Button_Click3(object sender, RoutedEventArgs e)
        {
            //这里可以看出Tag是object，可以存放任意数据类型
            int Id = Convert.ToInt32((sender as Button).Tag);
            HttpClient client = new HttpClient();
            string url = "https://localhost:44311/api/services/app/KeyComponentsAndTableService/Delete?Id=" + Id;
            var response = client.DeleteAsync(url);
            var responseString = response.Result.Content.ReadAsStringAsync();
            KeyComponentsViewModel viewModel = new KeyComponentsViewModel();
            viewModel.GetAll();
        }


    }
}
