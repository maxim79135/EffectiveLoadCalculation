using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EffectiveLoadCalculation.CustomElements;

namespace EffectiveLoadCalculation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void OnLoginButton_Pressed(object sender, EventArgs e)
        {
            (sender as MyButton).BackgroundColor = Color.FromHex("274A66");
        }

        private void OnLoginButton_Released(object sender, EventArgs e)
        {
            (sender as MyButton).BackgroundColor = Color.Transparent;
        }
    }
}