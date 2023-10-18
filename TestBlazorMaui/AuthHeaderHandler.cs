using Microsoft.Extensions.Configuration;

namespace TestBlazorMaui;

public class AuthHeaderHandler : DelegatingHandler
{
  private readonly IConfiguration _configuration;
  public AuthHeaderHandler(IConfiguration configuration) { _configuration = configuration; }

  protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
  {
    //request.Headers.Add("Ocp-Apim-Subscription-Key", _configuration["ApiMeta:OcpApimSubscriptionKey"]);

    return base.SendAsync(request, cancellationToken);
  }
}
