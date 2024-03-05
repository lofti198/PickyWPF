using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PickyWPF.Models
{
    public class ActionCommand : ICommand
    {
        private readonly Action<object> _execute;

        public ActionCommand(Action<object> execute)
        {
            _execute = execute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // This can be used to define custom logic for enabling/disabling the command
            // For example, return true if certain conditions are met.
            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
