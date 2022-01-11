using FlexLayoutSample.Models;
using FlexLayoutSample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;

namespace FlexLayoutSample
{
    public partial class MainPage : ContentPage
    {
        public MainViewModel ViewModel { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            ViewModel = App.Instance.Services.GetService<MainViewModel>();

            LoadPlaces();
        }

        void LoadPlaces()
        {
            try
            {
                FlexLayout flexLayout = new FlexLayout
                {
                    Padding = 12,
                    Wrap = FlexWrap.Wrap,
                    JustifyContent = FlexJustify.SpaceAround,
                    Direction = FlexDirection.Row
                };

                foreach (Place place in ViewModel.GetPlaces())
                {
                    StackLayout stackLayout = new StackLayout
                    {
                        Spacing = 8
                    };

                    Image placeImage = new Image
                    {
                        HeightRequest = 100,
                        WidthRequest = 100,
                        Aspect = Aspect.AspectFill,
                        Source = ImageSource.FromUri(new Uri(place.ImageUrl))
                    };

                    Label titleLabel = new Label
                    {
                        HorizontalOptions = LayoutOptions.Center,
                        Text = place.Title
                    };

                    stackLayout.Children.Add(placeImage);
                    stackLayout.Children.Add(titleLabel);

                    flexLayout.Children.Add(stackLayout);
                }


                this.Content = new ScrollView { Content = flexLayout };
            }
            catch { }
        }
    }
}
