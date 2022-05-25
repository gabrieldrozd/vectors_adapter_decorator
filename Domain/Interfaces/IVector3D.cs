namespace Domain.Interfaces;

public interface IVector3D : IVector
{
    public double Z { get; }

    public IVector3D Cross(IVector innerVector);
    public IVector GetSourceVector();
}