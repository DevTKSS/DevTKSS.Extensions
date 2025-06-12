using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DevTKSS.Extensions.DataTables;

public static class DataTableExtensions
{
#if NET9_0_OR_GREATER // collection expressions are available in .NET 9.0 and later
    /// <summary>
    /// Retrieves column titles from a DataTable, optionally excluding the <paramref name="exceptKeyed"/> identified column.
    /// </summary>
    /// <param name="oTable">The DataTable to extract column names from.</param>
    /// <param name="exceptKeyed">Optional column name to exclude from the result.</param>
    /// <returns>An array of column titles.</returns>
    public static IEnumerable<string> GetTitles(this DataTable oTable, string? exceptKeyed = null)
    {
        ArgumentNullException.ThrowIfNull(oTable);
        return [.. oTable.Columns.Cast<DataColumn>()
                                 .Where(col => string.IsNullOrEmpty(exceptKeyed) || col.ColumnName != exceptKeyed)
                                 .Select(col => col.ColumnName)];
    }

    /// <summary>
    /// Retrieves content from a DataTable for the given column titles.
    /// </summary>
    /// <param name="oTable">The DataTable to extract data from.</param>
    /// <param name="oTitles">The column titles to include in the output.</param>
    /// <returns>An array of string values representing the table contents.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="oTable"/> or <paramref name="oTitles"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentOutOfRangeException">If there are no elements in <paramref name="oTitles"/>.</exception>
    public static IEnumerable<string> GetContents(this DataTable oTable, IEnumerable<string> oTitles)
    {
        ArgumentNullException.ThrowIfNull(oTable);
        ArgumentNullException.ThrowIfNull(oTitles);
        if (!oTitles.Any()) throw new ArgumentOutOfRangeException(nameof(oTitles));
        return [.. oTable.AsEnumerable()
                         .SelectMany(row => oTitles
                             .Select(title => row[title]?.ToString() ?? string.Empty))];
    }
#else
    /// <summary>
    /// Retrieves column titles from a DataTable, optionally excluding the <paramref name="exceptKeyed"/> identified column.
    /// </summary>
    /// <param name="oTable">The DataTable to extract column names from.</param>
    /// <param name="exceptKeyed">Optional column name to exclude from the result.</param>
    /// <returns>An array of column titles.</returns>
    public static IEnumerable<string> GetTitles(this DataTable oTable, string? exceptKeyed = null)
    {
        ArgumentNullException.ThrowIfNull(oTable);
        return oTable.Columns.Cast<DataColumn>()
                             .Where(col => string.IsNullOrEmpty(exceptKeyed) || col.ColumnName != exceptKeyed)
                             .Select(col => col.ColumnName);
    }

    /// <summary>
    /// Retrieves content from a DataTable for the given column titles.
    /// </summary>
    /// <param name="oTable">The DataTable to extract data from.</param>
    /// <param name="oTitles">The column titles to include in the output.</param>
    /// <returns>An array of string values representing the table contents.</returns>
    /// <exception cref="ArgumentNullException">If <paramref name="oTable"/> or <paramref name="oTitles"/> is <see langword="null"/>.</exception>
    /// <exception cref="ArgumentOutOfRangeException">If there are no elements in <paramref name="oTitles"/>.</exception>
    public static IEnumerable<string> GetContents(this DataTable oTable, IEnumerable<string> oTitles)
    {
        ArgumentNullException.ThrowIfNull(oTable);
        ArgumentNullException.ThrowIfNull(oTitles);
        if (!oTitles.Any()) throw new ArgumentOutOfRangeException(nameof(oTitles));
        return oTable.AsEnumerable()
                     .SelectMany(row => oTitles
                         .Select(title => row[title]?.ToString() ?? string.Empty));
    }
#endif
}
