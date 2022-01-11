using FlexLayoutSample.Services.Contracts;
using FlexLayoutSample.Utils;
using System.Collections.Generic;

namespace FlexLayoutSample.Services
{
    public class ImageService : IImageService
    {
        public List<string> FetchImages()
        {
            List<string> photos = new List<string>();

            try
            {
                return new List<string>(Constants.Photos);
            }
            catch { }

            return photos;
        }
    }
}
