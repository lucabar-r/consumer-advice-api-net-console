using System.Text.Json.Serialization;

namespace ConsumerAdviceApi.Models;

public class Slip
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("advice")]
    public string? Advice { get; set; }
}

public class AdviceResponse
{
    [JsonPropertyName("slip")]
    public Slip? Slip { get; set; }
}