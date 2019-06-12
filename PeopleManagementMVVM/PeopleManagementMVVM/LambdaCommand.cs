using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PeopleManagementMVVM
{
    public class LambdaCommand : ICommand
    {
        private readonly Action action;

        public event EventHandler CanExecuteChanged;

        public LambdaCommand(Action action)
        {
            this.action = action;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.action.Invoke();
        }
    }
}
