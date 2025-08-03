using System.Numerics;

namespace DevTKSS.Extensions.Numerics;
public static class NumericsExtensions
{
    /// <summary>
    /// Rounds a number up to the next multiple of the step value (only for floating-point types).
    /// </summary>
    public static TNumber RoundUpByStep<TNumber>(this TNumber number, TNumber step)
        where TNumber : IFloatingPoint<TNumber>
        => TNumber.Ceiling(number / step) * step;

    /// <summary>
    /// Rounds a value to the specified number of decimal places for supported floating-point types.
    /// </summary>
    [Obsolete("Use Regular IFloatingPoint<TNumber> Round method instead.")]
    public static TNumber RoundUpWithDigits<TNumber>(this TNumber value, int digits) where TNumber : IFloatingPoint<TNumber>
        => TNumber.Round(value, digits, MidpointRounding.AwayFromZero);
    /// <summary>
    /// Rounds a value to the specified number of decimal places for supported floating-point types.
    /// </summary>
    [Obsolete("Use Regular IFloatingPoint<TNumber> Round method instead.")]
    public static TNumber RoundDownWithDigits<TNumber>(this TNumber value, int digits) where TNumber : IFloatingPoint<TNumber>
        => TNumber.Round(value, digits, MidpointRounding.ToEven);
}
