using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ToDoApplication.Commands
{
    public class RelayCommand : ICommand
    {
        #pragma warning disable 67
        public event EventHandler? CanExecuteChanged;
        #pragma warning restore 67

        private Action<object> _Execute { get; set; }
        private Predicate<object> _CanExecute { get; set; }

        public RelayCommand(Action<object> executeMethod, Predicate<object> canExecuteMethod)
        {
            _Execute = executeMethod;
            _CanExecute = canExecuteMethod;
        }

        public bool CanExecute(object? parameter)
        {
            return _CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _Execute(parameter);
        }
    }
}
