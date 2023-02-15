using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankAppcx2.Model
{
    public class Person : ModelBase
    {
        /// <summary>
        /// 物料配置id
        /// </summary>
        private int Id;
        public int ID
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged("ID"); } }
        /// <summary>
        /// 物料配置描述
        /// </summary>
        private string materialallocationtabledescribe;
        public string MaterialAllocationTableDescribe
        {
            get { return materialallocationtabledescribe; }
            set { materialallocationtabledescribe = value; OnPropertyChanged("MaterialAllocationTableDescribe"); }}
        /// <summary>
        /// 物料配置编码
        /// </summary>
        private string materialallocationtablecoding;
        public string MaterialAllocationTableCoding
        {
            get { return materialallocationtablecoding; }
            set { materialallocationtablecoding = value; OnPropertyChanged("MaterialAllocationTableCoding"); }
        }

        /// <summary>
        /// 物料配置页签
        /// </summary>
        private string materialallocationtabletab;
        public string MaterialAllocationTableTab {
            get { return materialallocationtabletab; }
            set { materialallocationtabletab = value; OnPropertyChanged("MaterialAllocationTableTab"); }
        }

        /// <summary>
        /// 物料配置轴
        /// </summary>
        private int materialallocationtableaxle;
        public int MaterialAllocationTableAxle {
            get { return materialallocationtableaxle; }
            set { materialallocationtableaxle = value; OnPropertyChanged("MaterialAllocationTableAxle"); }
        }

        /// <summary>
        /// 物料配置注油标准值
        /// </summary>
        private string materialallocationtablestandard;
        public string MaterialAllocationTableStandard {
            get { return materialallocationtablestandard; }
            set { materialallocationtablestandard = value; OnPropertyChanged("MaterialAllocationTableStandard"); }
        }

        /// <summary>
        /// 物料配置注油偏差值
        /// </summary>
        private string materialallocationtabledeviation;
        public string MaterialAllocationTableDeviation {
            get { return materialallocationtabledeviation; }
            set { materialallocationtabledeviation = value; OnPropertyChanged("MaterialAllocationTableDeviation"); }
        }
    }
    public class Result
    {
        /// <summary>
        /// 
        /// </summary>
        public int totalCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Person> items { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public Result result { get; set; }
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

    public class Root1
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Person> result { get; set; }
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
