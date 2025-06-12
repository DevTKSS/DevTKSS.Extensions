namespace DevTKSS.Extensions.Uno.Storage.Enumerables;
public static class EnumerableExtensions
{
    /// <summary>
    /// Selects string typed items from the input collection based on the specified ranges.
    /// </summary>
    /// <param name="source">The collection of string typed items to select from.</param>
    /// <param name="ranges">
    /// A collection of ranges, where each range is a tuple containing a start and end index.
    /// The start index specifies the first item to include, and the end index specifies the last item to include.
    /// </param>
    /// <returns>
    /// An enumerable collection of strings, where each string represents the items within a specified range.
    /// If a range is invalid (e.g. start is greater than the last one), an empty string is returned for that range.
    /// </returns>
    public static IEnumerable<string> SelectItemsByRanges(this IEnumerable<string> source, IEnumerable<(int Start, int End)> ranges, bool nullBased = true)
    {
        if (ranges == null || !ranges.Any()) yield return string.Empty;
        else
        {
            foreach (var range in ranges)
            {
                yield return source.GetItemsWithinRange(range, nullBased);
            }
        }
    }

    /// <summary>
    /// Retrieves a single string containing the concatenated items within the specified range.
    /// </summary>
    /// <param name="source">The collection to select from.</param>
    /// <param name="range">
    /// A tuple containing the start and end indices of the range.
    /// The start index specifies the first item to include, and the end index specifies the last item to include.
    /// </param>
    /// <param name="nullBased">set to false if providing a known 1-based Enumerable</param>
    /// <returns>
    /// A string containing the string typed items of <paramref name="source"/> within the specified range, joined by the system's newline character.
    /// </returns>
    public static string GetItemsWithinRange(this IEnumerable<string> source, (int Start, int End) range, bool nullBased = true)
    {
        if (source == null || !source.Any()) return string.Empty;
        var startIndex = Math.Clamp(
            value: range.Start - (nullBased ? 0 : 1),
            min: 0,
            max: source.Count());

        var endIndex = Math.Clamp(
            value: range.End,
            min: startIndex,
            max: source.Count()); // Ensure 'End' does not exceed available lines

        return source.Skip(startIndex)
                     .Take(endIndex - startIndex)
                     .JoinBy(Environment.NewLine);
    }
}
