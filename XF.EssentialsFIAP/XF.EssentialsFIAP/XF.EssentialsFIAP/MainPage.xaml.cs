using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace XF.EssentialsFIAP
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            lblInfo.Text = AppInfo.PackageName.ToString();
            lblDevice.Text = DeviceInfo.Model.ToString();


        }

        private async void Ligar_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOnAsync();
        }

        private async void Desligar_Clicked(object sender, EventArgs e)
        {
            await Flashlight.TurnOffAsync();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://www.microsoft.com", BrowserLaunchMode.SystemPreferred);

        }
    }
}
