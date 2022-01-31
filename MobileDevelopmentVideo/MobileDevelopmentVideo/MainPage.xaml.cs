using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace MobileDevelopmentVideo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            slider.Value = 0.5;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    this.Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    this.Padding = new Thickness(0, 20, 20, 0);
                    break;
                case Device.UWP:
                    this.Padding = new Thickness(10, 10, 10, 10);
                    break;
                default:
                    // This is just an example. You wouldn't actually need to do this, since Padding is already 0 by default.
                    this.Padding = new Thickness(0);
                    break;
            }
            var i = new OnPlatform<Thickness>
            {
                Default = new Thickness(0, 20, 0, 0),
                iOS = new Thickness(0, 20, 0, 0),
                Android = new Thickness(0, 20, 0, 0),
            };
         



        }
    }
}
