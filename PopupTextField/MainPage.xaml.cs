using CommunityToolkit.Maui.Views;

namespace PopupTextField
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var popup = new LoginPopup();
            this.ShowPopup(popup);
        }
    }

}
