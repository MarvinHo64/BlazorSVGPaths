namespace BlazorSVGPaths.ViewModels;

public class DraggableObject
{
    public double X;
    public double Y;
    public double RootX => X + 100;
    public double RootY => Y + 25;
    
    public int Id;
    public double ConnectX => X;
    public double ConnectY => Y +25;
    
    public IList<DraggableObject> ConnectOut { get; set; } = new List<DraggableObject>();
    public IList<DraggableObject> ConnectIn { get; set; } = new List<DraggableObject>();
}