using FlexLayoutSample.Models;
using FlexLayoutSample.Services.Contracts;
using System.Collections.Generic;

namespace FlexLayoutSample.ViewModels
{
    public class MainViewModel
    {
        IImageService _imageService;

        public MainViewModel(IImageService imageService)
        {
            _imageService = imageService;
        }

        public List<Place> GetPlaces()
        {
            List<string> photos = _imageService.FetchImages();
            List<Place> places = new List<Place>();

            foreach (var photo in photos)
            {
                places.Add(new Place
                {
                    ImageUrl = photo,
                    Title = "Test"
                });
            }

            return places;
        }
    }
}
