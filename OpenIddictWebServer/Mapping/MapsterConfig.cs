using Mapster;
using OpenIddictWebServer.Models;
using OpenIddictWebServer.Models.ViewModels;

namespace OpenIddictWebServer.Mapping
{
    public static class MapsterConfig
    {
        public static void RegisterMappings()
        {
            // Register mappings here
            TypeAdapterConfig<RegisterViewModel, UserModel>.NewConfig()
                .Map(dest => dest.UserName, src => src.Email)
                .Ignore(dest => dest.Id);
        }
    }
}
