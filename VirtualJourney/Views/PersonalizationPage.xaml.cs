using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualJourney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonalizationPage : ContentPage
    {
        public PersonalizationPage()
        {
            InitializeComponent();
        }
        public async void OnImageNameTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AboutPage());
        }

        async void OnCorrectDrop(object sender, DropEventArgs e)
        {
            await DisplayAlert("Correct", "Congratulations!", "OK");
        }

        void OnIncorrectDragOver(object sender, DragEventArgs e)
        {
            e.AcceptedOperation = DataPackageOperation.None;
        }

        private void ShowButton_Clicked(object sender, EventArgs e)
        {
            if (selectableGrid.IsVisible = true)
            {
                showButton.Text = "Hide the Grid";
            }
            else
            {
                selectableGrid.IsVisible = false;
                showButton.Text = "Show the Grid";
            }

        }
        private void HideButton_Clicked(object sender, EventArgs e)
        {
            selectableGrid.IsVisible = false;
        }
        //This method is unknown for now
        //void OnDragOver(object sender, DragEventArgs e)
        //{
        //    e.AcceptedOperation = DataPackageOperation.None;
        //}
    }
}