using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ToDoList.Models;

namespace ToDoList.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<TodoItem> TodoItems { get; set; }
    [ObservableProperty] private string _newItemTitle = "";

    public MainWindowViewModel()
    {
        TodoItems = new ObservableCollection<TodoItem>()
        {
            new TodoItem("test",true),
            new TodoItem("test 2",true),
            new TodoItem("test 3",false)
        };
    }

    [RelayCommand]
    public void AddItem()
    {
        TodoItems.Add(new TodoItem(NewItemTitle));
        NewItemTitle = "";
        OnPropertyChanged();
    }
    [RelayCommand]
    public void RemoveItem(TodoItem item)
    {
        TodoItems.Remove(item);
    }
}