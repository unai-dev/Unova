using Unova.App.Contracts.Common;

namespace Unova.App.Contracts;

public interface IResourceService : IUnovaContract<ResourceReadDto, ResourceDetailDto, ResourceCreateDto>
{
    Task<string> GetRsc(string code);
}
