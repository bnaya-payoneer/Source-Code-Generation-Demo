using System.Text.Json.Serialization;

namespace Bnaya.Samples;

[JsonSerializable(typeof(Person1[]))]
internal partial class MyJsonContext : JsonSerializerContext { }
