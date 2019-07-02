using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GuiaEjercicios
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            /*
            var p = new NavigationPage(new tabbedEjercicios());
            Application.Current.MainPage = p;
            */
            Navigation.PushAsync(new tabbedEjercicios());

        }
    }
}
