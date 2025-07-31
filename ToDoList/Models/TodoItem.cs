using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ToDoList.Models
{
    public partial class TodoItem : ObservableObject
    {
        [ObservableProperty]
        private string title;

        [ObservableProperty]
        private bool isDone;

        public TodoItem(string title, bool isDone = false)
        {
            this.Title = title;
            this.IsDone = isDone;
        }
        public TodoItem(string title)
        {
            this.Title = title;
            this.IsDone = false;
        }
    }
}