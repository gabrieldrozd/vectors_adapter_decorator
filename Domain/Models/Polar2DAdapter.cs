using System.Numerics;
using Domain.Interfaces;

namespace Domain.Models;

public class Polar2DAdapter : IPolar2D, IVector
{
    private readonly Vector2D _srcVector;

    public Polar2DAdapter(double x, double y)
    {
        X = x;
        Y = y;
        _srcVector = new Vector2D(x, y);
    }

    // Props
    public double X { get; }
    public double Y { get; }

    // Methods
    public double GetAngle()
    {
        var dot = _srcVector.Cdot(new Vector2D(X, 0));

        var test = _srcVector.Abs() * Math.Sqrt(X * X + 0 * 0);

        var angleInRadians = Math.Acos(dot / test);

        var angle = angleInRadians * (180 / Math.PI); 

        return angle;
    }

    double IPolar2D.Abs()
    {
        return Math.Abs(Math.Sqrt(X * X + Y * Y));
    }

    double IVector.Abs()
    {
        return _srcVector.Abs();
    }

    public double Cdot(IVector innerVector)
    {
        return _srcVector.Cdot(innerVector);
    }

    public IEnumerable<double> GetComponents()
    {
        return _srcVector.GetComponents();
    }
}