using System;
using System.Windows.Input;
using JetBrains.Annotations;

namespace Brainy.Framework
{
    [UsedImplicitly]
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;
        [UsedImplicitly]

        public RelayCommand(Action execute)
        {
            _execute = execute;
            _canExecute = () => true;
        }
        [UsedImplicitly]
        public RelayCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged;
    }
}