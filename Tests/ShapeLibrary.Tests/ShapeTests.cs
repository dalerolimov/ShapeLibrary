using FluentAssertions;
using ShapeLibrary.Factories;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.Tests;

public class ShapeTests
{
    [Fact]
    public void CircleArea_CorrectRadius_ShouldReturnCorrectArea()
    {
        var circle = new Circle(5);

        var area = circle.GetArea();

        area.Should().BeApproximately(Math.PI * 25, precision: 1e-5);
    }

    [Fact]
    public void TriangleArea_ValidSides_ShouldReturnCorrectArea()
    {
        var triangle = new Triangle(3, 4, 5);

        var area = triangle.GetArea();

        area.Should().BeApproximately(6, precision: 1e-5);
    }

    [Fact]
    public void Triangle_IsRightTriangle_ShouldReturnTrue()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRight = triangle.IsRightTriangle();

        isRight.Should().BeTrue();
    }

    [Fact]
    public void ShapeFactory_ShouldCreateCircle()
    {
        var shape = ShapeFactory.CreateShape("circle", 5);

        shape.Should().BeOfType<Circle>();
        ((Circle)shape).Radius.Should().Be(5);
    }

    [Fact]
    public void ShapeFactory_ShouldCreateTriangle()
    {
        var shape = ShapeFactory.CreateShape("triangle", 3, 4, 5);

        shape.Should().BeOfType<Triangle>();
        var triangle = shape as Triangle;
        triangle.A.Should().Be(3);
        triangle.B.Should().Be(4);
        triangle.C.Should().Be(5);
    }
}