using BlazorSVGPaths.ViewModels;

namespace BlazorSVGPaths.Services;

public interface IPositioningService
{
    public DraggableObject? GetObjectAtPosition(double x, double y);
    public void AddConnection(Connection connection);
    public void OnHover(DraggableObject? draggableObject);
    public void OnHoverDown();
}