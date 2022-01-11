using System.Collections.Generic;

namespace FlexLayoutSample.Services.Contracts
{
    public interface IImageService
    {
        List<string> FetchImages();
    }
}
