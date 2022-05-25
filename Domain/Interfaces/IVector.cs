namespace Domain.Interfaces;

public interface IVector
{
    double X { get; }
    double Y { get; }
    
    /// <summary>
    /// Oblicza moduł wektora
    /// </summary>
    /// <returns>Obliczony moduł</returns>
    double Abs();
    
    /// <summary>
    /// Oblicza iloczyn skalarny miedzy dwoma wektorami 
    /// </summary>
    /// <param name="innerVector">"this"</param>
    /// <returns>Iloczyn skalarny</returns>
    double Cdot(IVector innerVector);
    
    /// <summary>
    /// Zwraca wartości składowych wektora
    /// </summary>
    /// <returns>Składowe wektora</returns>
    IEnumerable<double> GetComponents();
}