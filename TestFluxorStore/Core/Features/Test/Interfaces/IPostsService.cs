using Refit;

using TestFluxorStore.Core.Features.Shared.DTOs;

using TestFluxorStore.Core.Features.Test.DTOs;

namespace TestFluxorStore.Core.Features.Test.Interfaces;

[Headers("Content-Type: application/json")]

public interface IPostsService
{
  [Get("/posts")]
  Task<GetResponseEnvelop<List<Post>>> GetPostsAsync();

  [Post("/posts")]
  Task<Post> AddNewPostAsync(Post request);
}
