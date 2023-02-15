using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankAppcx2.Model
{
    public class TestStationModel: ModelBase
    {
        /// <summary>
        /// 测试工位id自增
        /// </summary>
        private int Id;
        public int ID
        {
            get { return Id; }
            set { Id = value; OnPropertyChanged("ID"); }
        }
        /// <summary>
        /// 测试工位编码
        /// </summary>
        private string teststationcoding;
        public string TestStationCoding
        {
            get { return teststationcoding; }
            set { teststationcoding = value; OnPropertyChanged("TestStationCoding"); }
        }
        /// <summary>
        /// 测试工位名称
        /// </summary>
        private string teststationname;
        public string TestStationName
        {
            get { return teststationname; }
            set { teststationname = value; OnPropertyChanged("TestStationName"); }
        }
    }
}
