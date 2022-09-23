namespace BlazorSVGPaths.ViewModels;

public class Connection
{
    public DraggableObject From;
    public DraggableObject To;

    public Connection(DraggableObject from, DraggableObject to)
    {
        From = from;
        To = to;
    }
}