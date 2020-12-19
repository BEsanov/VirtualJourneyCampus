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
    public partial class SettingsViewPage : ContentPage
    {
        
        public SettingsViewPage()
        {
            InitializeComponent();
            
        }

        private void pickerCampus_SelectedIndexChanged(object sender, EventArgs e)
        {
            //pickerCampus.SelectedIndex = Color.Red;
        }
    }
}