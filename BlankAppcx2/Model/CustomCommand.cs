using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BlankAppcx2.Model
{
    //CustomCommand 解释：自定义命令类，实现 ICommand 接口
    public class CustomCommand : ICommand
    {
        //_executeMethod 解释：定义一个 Action 委托类型的字段，用于存储命令的执行方法
        private Action _executeMethod;
        //_canExecuteMethod 解释：定义一个 Func<bool> 委托类型的字段，用于存储命令的执行条件
        private Func<bool> _canExecuteMethod;
        
        public CustomCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            if (executeMethod == null)
            {
                throw new ArgumentNullException("executeMethod");
            }
            _executeMethod = executeMethod;
            _canExecuteMethod = canExecuteMethod;
        }
        //EventHandler 解释：事件处理程序委托
        public event EventHandler CanExecuteChanged;
        //CanExecute 解释：判断命令是否可以执行
        public bool CanExecute(object parameter)
        {
            if (_canExecuteMethod == null) return true;
            return _canExecuteMethod();
        }
        public void Execute(object parameter)
        {
            if (_executeMethod != null)
                _executeMethod();
        }
    }
}
