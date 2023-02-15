using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankAppcx2.Model
{
    public class ItemsItem:ModelBase
    {
        /// <summary>
        /// 
        /// </summary>
        public string testStationCoding;
        public string TestStationCoding
        {
            get { return testStationCoding; }
            set { testStationCoding = value; OnPropertyChanged("TestStationCoding"); }
        }
        /// <summary>
        /// 
        /// </summary>
        public string testStationName;
        public string TestStationName
        {
            get { return testStationName; }
            set { testStationName = value; OnPropertyChanged("TestStationName"); }
        }

        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
    }

    public class Result2
    {
        /// <summary>
        /// 
        /// </summary>
        public int totalCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<ItemsItem> items { get; set; }
    }

    public class Root2
    {
        /// <summary>
        /// 
        /// </summary>
        public Result2 result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string targetUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unAuthorizedRequest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string __abp { get; set; }
    }

    public class Root3
    {
        /// <summary>
        /// 
        /// </summary>
        public List<ItemsItem> result { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string targetUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string success { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string error { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string unAuthorizedRequest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string __abp { get; set; }
    }
}
