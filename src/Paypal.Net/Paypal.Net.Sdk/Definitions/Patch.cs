﻿using Newtonsoft.Json;

namespace Paypal.Net.Sdk.Definitions {

  public class Patch {

    [JsonProperty("op")]
    public string Op { get; set; }

    [JsonProperty("path")]
    public string Path { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }
  }

}