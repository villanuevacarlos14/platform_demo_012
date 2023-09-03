namespace PlatformDemo.Models;

public class Selectable<T> where T: class
{
    public T Item { get; set; }
    public bool IsSelected { get; set; }
}