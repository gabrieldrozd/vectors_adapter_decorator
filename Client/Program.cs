using Domain.Interfaces;
using Domain.Models;

// IVector v1 = new Vector2D(10, 2);
// IVector v2 = new Vector2D(5, 3);
// var v1v2 = v1.Cdot(v2);

// Console.WriteLine(v1.Abs());
// Console.WriteLine(v1v2);
// Console.WriteLine("{0}", string.Join(", ", v1.GetComponents().Select(x => x)));

// Console.WriteLine();
// Console.WriteLine();
// IPolar2D v3 = new Polar2DAdapter(10, 4);

// Console.WriteLine(v3.GetAngle());

// Cross product

// 2D Vector
IVector v1 = new Vector2D(5, 3);
var v1Polar = new Polar2DAdapter(v1.X, v1.Y);

// 3D Vector
IVector3D v2 = new Vector3DDecorator(new Vector2D(1, 2), 3);


// Cross product between v2 and v1
var crossProduct = v2.Cross(v1);
Console.WriteLine($"newVector = [{crossProduct.X} {crossProduct.Y} {crossProduct.Z}]");