namespace MVVMCourse.Infrastructure.Commands
{
    class CloseApplicationCommand : Base.Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => App.Current.Shutdown();
    }
}
