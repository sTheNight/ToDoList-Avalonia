using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ToDoList.Views;

public partial class EditTodo : Window
{
    public EditTodo()
    {
        InitializeComponent();
    }

    public void CloseWindows(object sender, RoutedEventArgs e)
    {
        this.Close(); 
    }
}