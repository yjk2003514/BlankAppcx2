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

namespace BlankAppcx2.ViewModels
{
    public class KeyComponentsViewModel : ModelBase
    {
        /// <summary>
        /// 关键键采集显示
        /// </summary>
        private BindingList<KeyComponents> _people;

        public BindingList<KeyComponents> People
        {
            get { return _people ?? (_people = new BindingList<KeyComponents>()); }
            set { _people = value; OnPropertyChanged("People"); }
        }

        public KeyComponentsViewModel()
        {
            People = GetAll();
            People2 = GetAll2();
            People3 = GetAll3();
        }

        public BindingList<KeyComponents> GetAll()
        {
            var list = HttpHelper.Get("https://localhost:44311/api/services/app/KeyComponentsAndTableService/GetAll");
            var show = JsonConvert.DeserializeObject<Root4s>(list);
            var items = show.result.items;
            var bindingList = new BindingList<KeyComponents>(items);
            return bindingList;
        }

        /// <summary>
        /// 电机表的显示数据
        /// </summary>
        private BindingList<ElectricalMachineryModel> _people2;

        public BindingList<ElectricalMachineryModel> People2
        {
            get { return _people2 ?? (_people2 = new BindingList<ElectricalMachineryModel>()); }
            set { _people2 = value; OnPropertyChanged("People2"); }
        }
        
        public BindingList<ElectricalMachineryModel> GetAll2()
        {
            var list = HttpHelper.Get("https://localhost:44311/api/services/app/ElectricalMachineryTableService/GetAll");
            var show = JsonConvert.DeserializeObject<Root5s>(list);
            var items = show.result.items;
            var bindingList = new BindingList<ElectricalMachineryModel>(items);
            return bindingList;
        }

        /// <summary>
        /// 齿轮箱、码垛机器人页签
        /// </summary>
        private BindingList<GearCaseModel> _people3;

        public BindingList<GearCaseModel> People3
        {
            get { return _people3 ?? (_people3 = new BindingList<GearCaseModel>()); }
            set { _people3 = value; OnPropertyChanged("People3"); }
        }

        public BindingList<GearCaseModel> GetAll3()
        {
            var list = HttpHelper.Get("https://localhost:44311/api/services/app/GearCaseTableService/GetAll");
            var show = JsonConvert.DeserializeObject<Root6s>(list);
            var items = show.result.items;
            var bindingList = new BindingList<GearCaseModel>(items);
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
      
        /// <summary>
        /// 关键键采集添加
        /// </summary>
        private KeyComponents _person;
        
        public KeyComponents person
        {
            get { return _person ?? (_person = new KeyComponents()); }
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
            person.KeyComponentsAndTableDateTime = DateTime.Now;
            var jsonadd = JsonConvert.SerializeObject(person);

            //解释NewGetQuery参数作用 1.请求地址 2.请求参数 3.请求参数类型
            var i = HttpRequest.PostAsyncJson("https://localhost:44311/api/services/app/KeyComponentsAndTableService/Create", jsonadd);
            People.Add(person);
        }

        public bool CanAdd()
        {
            return People != null && person != null;
        }

        private ElectricalMachineryModel _person2;
        public ElectricalMachineryModel person2
        {
            get { return _person2 ?? (_person2 = new ElectricalMachineryModel()); }
            set { _person2 = value; OnPropertyChanged("person2"); }
        }

        /// <summary>
        /// 电机表添加
        /// </summary>
        private CustomCommand _addCmd2;
        //CustomCommand
        public CustomCommand AddCmd2
        {
            get { return _addCmd2 ?? (_addCmd2 = new CustomCommand(Add2, CanAdd2)); }
        }

        public void Add2()
        {
            person2.ElectricalMachineryTableDateTime = DateTime.Now;
            var jsonadd = JsonConvert.SerializeObject(person2);

            //解释NewGetQuery参数作用 1.请求地址 2.请求参数 3.请求参数类型
            var i = HttpRequest.PostAsyncJson("https://localhost:44311/api/services/app/GearCaseTableService/Create", jsonadd);
            People2.Add(person2);
        }

        public bool CanAdd2()
        {
            return People2 != null && person2 != null;
        }

        /// <summary>
        /// 齿轮箱、码垛机器人页签新增
        /// </summary>
        private GearCaseModel _person3;
        public GearCaseModel person3
        {
            get { return _person3 ?? (_person3 = new GearCaseModel()); }
            set { _person3 = value; OnPropertyChanged("person3"); }
        }
        private CustomCommand _addCmd3;
        //CustomCommand
        public CustomCommand AddCmd3
        {
            // get { return _addCmd3 ?? (_addCmd3 = new CustomCommand(Add3, CanAdd3)); } 解释:如果_addCmd3为空,则执行Add3,CanAdd3方法
            get { return _addCmd3 ?? (_addCmd3 = new CustomCommand(Add3, CanAdd3)); }
        }
        public void Add3()
        {
            //给时间赋值:当前时间
            person3.GearCaseTableTime = DateTime.Now;
            //jsonadd 为json格式的字符串
            var jsonadd = JsonConvert.SerializeObject(person3);

            //解释NewGetQuery参数作用 1.请求地址 2.请求参数 3.请求参数类型
            var i = HttpRequest.PostAsyncJson("https://localhost:44311/api/services/app/GearCaseTableService/Create", jsonadd);
            // People3.Add(person3) 解释:将person3添加到People3中
            People3.Add(person3);
        }

        public bool CanAdd3()
        {
            // return People3 != null && person3 != null 解释:People3和person3不为空时返回true
            return People3 != null && person3 != null;
        }
    }
}
