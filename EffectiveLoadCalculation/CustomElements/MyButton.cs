using Xamarin.Forms;

namespace EffectiveLoadCalculation.CustomElements
{
    public class MyButton : Button
    {
        public MyButton()
        {
            FontSize = 20;
            FontAttributes = FontAttributes.Bold;
            HeightRequest = 50;
            CornerRadius = 10;
            Margin = new Thickness(20, 0, 20, 0);
            HorizontalOptions = LayoutOptions.Fill;
            BackgroundColor = Color.Transparent;
            TextColor = Color.White;
        }
    }
}
