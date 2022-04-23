using MVVMCourse.ViewModels.Base;

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
    }
}