using Newtonsoft.Json;

namespace TestFluxorStore.Core.Features.Shared.DTOs;

public class GetResponseEnvelop<T>
{
  [JsonProperty("result")]
  public T Result { get; set; }

  [JsonProperty("errorCode")]
  public string ErrorCode { get; set; }

  [JsonProperty("errorMessage")]
  public string ErrorMessage { get; set; }

  [JsonProperty("invalidField")]
  public object InvalidField { get; set; }

  [JsonProperty("timeGenerated")]
  public DateTime TimeGenerated { get; set; }
}
