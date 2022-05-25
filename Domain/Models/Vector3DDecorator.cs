using Domain.Interfaces;

namespace Domain.Models;

public class Vector3DDecorator : IVector3D
{
    private readonly IVector _srcVector;

    public Vector3DDecorator(IVector srcVector, double z)
    {
        _srcVector = srcVector;
        X = srcVector.X;
        Y = srcVector.Y;
        Z = z;
    }

    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    // Vector3D
    public IVector3D Cross(IVector innerVector)
    {
        // Y * 
        var vectorX = Y * 0 - Z * innerVector.Y;
        var vectorY = Z * innerVector.X - X * 0;
        var vectorZ = X * innerVector.Y - Y * innerVector.X;

        var vector3D = new Vector3DDecorator(new Vector2D(vectorX, vectorY), vectorZ);

        return vector3D;
    }

    public IVector GetSourceVector()
    {
        return _srcVector;
    }

    // Vector2D
    public double Abs()
    {
        return Math.Abs(Math.Sqrt(X * X + Y * Y + Z * Z));
    }

    public double Cdot(IVector innerVector)
    {
        return X * innerVector.X + Y * innerVector.Y + Z * 0;
    }

    public IEnumerable<double> GetComponents()
    {
        return new[] {X, Y, Z};
    }
}