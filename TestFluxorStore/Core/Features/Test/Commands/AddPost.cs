
using TestFluxorStore.Core.Features.Test.DTOs;

namespace TestFluxorStore.Core.Features.Test.Commands;
public class AddPost
{
  public Post Post { get; set; }

  public AddPost(
      Post post)
  {
    Post = post;
  }
}
