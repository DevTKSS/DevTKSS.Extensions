using System.Numerics;

namespace DevTKSS.Extensions.Numerics;

/// <summary>
/// Bietet allgemeine trigonometrische Hilfsmethoden für generische numerische Typen.
/// </summary>
public static class Trigonometry
{
    /// <summary>
    /// Calculates the tangent of a value in degrees.
    /// </summary>
    public static TNumber TAN<TNumber>(TNumber value) where TNumber : struct, ITrigonometricFunctions<TNumber>
    {
        return TNumber.Tan(TNumber.DegreesToRadians(value));
    }

    /// <summary>
    /// Calculates the arctangent (inverse tangent) of a value in degrees.
    /// </summary>
    public static TNumber ATAN<TNumber>(TNumber value) where TNumber : struct, ITrigonometricFunctions<TNumber>
    {
        return TNumber.RadiansToDegrees(TNumber.Atan(value));
    }

    /// <summary>
    /// Calculates the cosine of a value in degrees.
    /// </summary>
    public static TNumber COS<TNumber>(TNumber value) where TNumber : struct, ITrigonometricFunctions<TNumber>
    {
        return TNumber.Cos(TNumber.DegreesToRadians(value));
    }

    /// <summary>
    /// Calculates the arccosine (inverse cosine) of a value in degrees.
    /// </summary>
    public static TNumber ACOS<TNumber>(TNumber value) where TNumber : struct, ITrigonometricFunctions<TNumber>
    {
        return TNumber.RadiansToDegrees(TNumber.Acos(value));
    }

    /// <summary>
    /// Calculates the sine of a value in degrees.
    /// </summary>
    public static TNumber SIN<TNumber>(TNumber value) where TNumber : struct, ITrigonometricFunctions<TNumber>
    {
        return TNumber.Sin(TNumber.DegreesToRadians(value));
    }

    /// <summary>
    /// Calculates the arcsine (inverse sine) of a value in degrees.
    /// </summary>
    public static TNumber ASIN<TNumber>(TNumber value) where TNumber : struct, ITrigonometricFunctions<TNumber>
    {
        return TNumber.RadiansToDegrees(TNumber.Asin(value));
    }
}
