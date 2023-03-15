using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SamsungWalletApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Device.SetFlags(new[] { "mediaElement_Experimental", "Brush_Experimental" });
            MainPage = new NavigationPage( new MainPage());
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
