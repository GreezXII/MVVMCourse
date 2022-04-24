using MVVMCourse.ViewModels.Base;
using MVVMCourse.Infrastructure.Commands;
using System.Windows;
using System.Windows.Input;

namespace MVVMCourse.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        #region Title
        /// <summary> Window title </summary>
        private string _Title = "Анализ статистики";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        #region Status
        /// <summary> Program status in status bar </summary>
        private string _Status = "Готов!";
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion

        #region Commands
        #region CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecute(object p) => true;
        private void OnCloseApplicationCommandExecuted(object p) => App.Current.Shutdown();
        #endregion
        #endregion

        public MainWindowViewModel()
        {
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
        }
    }
}