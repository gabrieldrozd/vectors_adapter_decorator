using Domain.Interfaces;

namespace Domain.Models;

public class Vector2D : IVector
{
    public Vector2D(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X { get; }
    public double Y { get; }

    public double Abs()
    {
        return Math.Abs(Math.Sqrt(X * X + Y * Y));
    }

    public double Cdot(IVector innerVector)
    {
        return X * innerVector.X + Y * innerVector.Y;
    }

    public IEnumerable<double> GetComponents()
    {
        return new[] {X, Y};
    }
}