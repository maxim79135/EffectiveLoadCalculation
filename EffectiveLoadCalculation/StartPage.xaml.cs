using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Media;
using EffectiveLoadCalculation.CustomElements;
using Plugin.Media.Abstractions;

namespace EffectiveLoadCalculation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private async void OnEntryButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }

        private void OnEntryButton_Pressed(object sender, EventArgs e)
        {
            (sender as MyButton).BackgroundColor = Color.FromHex("274A66");
        }

        private void OnEntryButton_Released(object sender, EventArgs e)
        {
            (sender as MyButton).BackgroundColor = Color.Transparent;
        }

        async private void ForgotButton_Clicked(object sender, EventArgs e)
        {
            if (CrossMedia.Current.IsPickPhotoSupported)
            {
                MediaFile photo = await CrossMedia.Current.PickPhotoAsync();
            }
        }
    }
}