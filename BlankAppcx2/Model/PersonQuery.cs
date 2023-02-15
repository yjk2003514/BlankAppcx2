using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlankAppcx2.Model
{
    public class PersonQuery: ModelBase
    {
        
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
        public string MaterialAllocationTableTab
        {
            get { return materialallocationtabletab; }
            set { materialallocationtabletab = value; OnPropertyChanged("MaterialAllocationTableTab"); }
        }

        
    }
}
