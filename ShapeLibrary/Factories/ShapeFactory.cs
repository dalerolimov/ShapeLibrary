using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.Factories;

public static class ShapeFactory
{
    public static IShape CreateShape(string shapeType, params double[] parameters)
    {
        return shapeType.ToLower() switch
        {
            "circle" => new Circle(parameters[0]),
            "triangle" => new Triangle(parameters[0], parameters[1], parameters[2]),
            _ => throw new ArgumentException("Unknown shape type.")
        };
    }
}