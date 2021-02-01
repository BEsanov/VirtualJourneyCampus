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
    public partial class NewsPage : ContentPage
    {
        public NewsPage()
        {
            InitializeComponent();
        }

        private void ShowNewsCategory_Clicked(object sender, EventArgs e)
        {
            newsCategoryGrid.IsVisible = true;
            hideNewsCategory.IsVisible = true;
        }

        private void hideNewsCategory_Clicked(object sender, EventArgs e)
        {
            hideNewsCategory.IsVisible = false;
            newsCategoryGrid.IsVisible = false;
        }
    }
}