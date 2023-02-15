using BlankAppcx2.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlankAppcx2.PageModel
{
    public class PageItemModel : NotifyBaseModel
    {
        private bool _isSelected;
        public bool IsSelected
        {
            get { return _isSelected; }
            set { SetProperty(ref _isSelected, value); }
        }
        public string Header { get; set; }
        public object PageView { get; set; }

        public ICommand CloseTabCommand { get; set; }
    }
}
