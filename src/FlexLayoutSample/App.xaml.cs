using FlexLayoutSample.Services;
using FlexLayoutSample.Services.Contracts;
using FlexLayoutSample.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using Xamarin.Forms;

namespace FlexLayoutSample
{
    public partial class App : Application
    {
        public App()
        {
            Services = ConfigureServices();

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }


        #region DI Services Initialization

        /// <summary>
        /// Gets the current instance in use
        /// </summary>
        public static App Instance => (App)Application.Current;

        /// <summary>
        /// Gets the IService provider instance to resolve application services
        /// </summary>
        public IServiceProvider Services { get; }

        /// <summary>
        /// Configures the services for the application
        /// </summary>
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // Services
            services.AddScoped<IImageService, ImageService>();

            // ViewModels
            services.AddScoped<MainViewModel>();

            return services.BuildServiceProvider();
        }

        #endregion
    }
}
