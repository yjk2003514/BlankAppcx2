using BlankApp1.Conmmon;
using BlankAppcx2.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static BlankAppcx2.ViewModels.ViewModel;

namespace BlankAppcx2.ViewModels
{
    public class TestStationViewModel: ModelBase
    {
        private BindingList<ItemsItem> _people;
        //BindingList 是一个泛型类，它实现了 IList 接口，同时还实现了 IBindingList 接口，IBindingList 接口继承了 IList 接口，所以 BindingList 既是一个 IList，也是一个 IBindingList。
        public BindingList<ItemsItem> People
        {
            get { return _people ?? (_people = new BindingList<ItemsItem>()); }
            set { _people = value; OnPropertyChanged("People"); }
        }
        //ViewModel 是一个公共类，它的构造函数是公共的，所以可以在任何地方实例化它，这里在 MainWindow.xaml.cs 中实例化了它，然后把它赋值给了 DataContext 属性。
        public TestStationViewModel()
        {
            People = GetAll();
        }


        private TestStationQuery _personQuery;
        public TestStationQuery personQuery
        {
            get { return _personQuery ?? (_personQuery = new TestStationQuery()); }
            set { _personQuery = value; OnPropertyChanged("personQuery"); }
        }

        private CustomCommand _QueryCmd;
        //CustomCommand
        public CustomCommand QueryCmd
        {
            get { return _QueryCmd ?? (_QueryCmd = new CustomCommand(Query, CanAdd)); }
        }

        //查询
        public void Query()
        {

            People = GetAll();

        }

        public BindingList<ItemsItem> GetAll()
        {
            var jsonaddQuery = JsonConvert.SerializeObject(personQuery);

            var s = HttpHelper.HttpGet($"https://localhost:44311/api/services/app/APJTestStation/TestGetQuerycondition?testStationCoding={personQuery.testStationCoding}&testStationName={personQuery.testStationName}");

            var show = JsonConvert.DeserializeObject<Root3>(s);
            var items = show.result;
            var bindingList = new BindingList<ItemsItem>(items);
            return bindingList;
        }


        public class HttpHelper
        {
            public static string Get(string url)
            {
                //请求后台接口
                var result = HttpHelper.HttpGet(url);
                //返回结果
                return result;
            }

            public static string HttpGet(string url)
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "textml;charset=UTF-8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
        }

        //添加
        private ItemsItem _person;
        public ItemsItem person
        {
            get { return _person ?? (_person = new ItemsItem()); }
            set { _person = value; OnPropertyChanged("person"); }
        }


        private CustomCommand _addCmd;
        //CustomCommand
        public CustomCommand AddCmd
        {
            get { return _addCmd ?? (_addCmd = new CustomCommand(Add, CanAdd)); }
        }

        public void Add()
        {
            var jsonadd = JsonConvert.SerializeObject(person);

            //解释NewGetQuery参数作用 1.请求地址 2.请求参数 3.请求参数类型
            var i = HttpRequest.PostAsyncJson("https://localhost:44311/api/services/app/APJTestStation/Create", jsonadd);
            People.Add(person);
        }


        public bool CanAdd()
        {
            return People != null && person != null;
        }
    }
}
