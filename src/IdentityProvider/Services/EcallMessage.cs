﻿using System.Text.Json.Serialization;

namespace IdentityProvider.Services;

public class EcallMessage
{
    [JsonPropertyName("channel")]
    public string Channel { get; set; } = "sms";
    [JsonPropertyName("from")]
    public string From { get; set; } = "test";
    [JsonPropertyName("to")]
    public string To { get; set; } = null!;
    [JsonPropertyName("content")]
    public EcallContent Content { get; set; } = new EcallContent();
}
