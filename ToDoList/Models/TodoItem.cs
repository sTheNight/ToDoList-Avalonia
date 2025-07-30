namespace ToDoList.Models;

public class TodoItem
{
    public string Title { get; set; }
    public bool IsDone { get; set; }

    public TodoItem(string title, bool isDone)
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