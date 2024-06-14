using System.Text.Json.Serialization;

namespace Bnaya.Samples;

[JsonSerializable(typeof(Fellow[]))]
internal partial class MyJsonContext : JsonSerializerContext { }
