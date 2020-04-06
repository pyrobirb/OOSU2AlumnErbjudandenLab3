using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFLayer
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> _executeAction;

        public event EventHandler CanExecuteChanged;

        public DelegateCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
        }

        public void Execute(object parameter) => _executeAction(parameter);

        public bool CanExecute(object parameter) => true;

    }
}
