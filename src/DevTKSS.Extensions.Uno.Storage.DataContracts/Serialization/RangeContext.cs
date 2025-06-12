using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace DevTKSS.Extensions.Enumerable.DataContracts.Serialization;
[JsonSerializable(typeof(Ranges))]
[JsonSerializable(typeof(Ranges[]))]
[JsonSerializable(typeof(IEnumerable<Ranges>))]
[JsonSerializable(typeof(IImmutableList<Ranges>))]
[JsonSerializable(typeof(ImmutableList<Ranges>))]
[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
public partial class RangesContext : JsonSerializerContext
{
}
