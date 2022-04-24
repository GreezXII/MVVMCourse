using MVVMCourse.Infrastructure.Commands.Base;
using System.Windows;
using System;

namespace MVVMCourse.Infrastructure.Commands
{
    class AboutCommand : Command
    {
        private string _About = string.Join(
            Environment.NewLine,
            "This is test MVVM project.",
            "Course author: Pavel Shmachiln.",
            "Student: me, lol.");

        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => MessageBox.Show(_About, "About program", MessageBoxButton.OK);
    }
}
