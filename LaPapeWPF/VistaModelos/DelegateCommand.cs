using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LaPapeWPF.VistaModelos
{
    class DelegateCommand : ICommand
    {
        private Action execute;
        private Func<bool> canExecute;

        public DelegateCommand(Action exec, Func<bool> canExec)
        {
            execute = exec;
            canExecute = canExec;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
                return true;
            return canExecute();
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (canExecute == null)
                execute();
        }

        public void OnCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(null, new EventArgs());
        }
    }
}
