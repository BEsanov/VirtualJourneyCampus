using System;
using VirtualJourney.Services;
using VirtualJourney.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualJourney
{
    public partial class App : Application
    {

        public App()
        {
            Device.SetFlags(new string[] { "DragAndDrop_Experimental", "Shapes_Experimental" });
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
    }
}
