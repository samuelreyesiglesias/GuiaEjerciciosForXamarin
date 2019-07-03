using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GuiaEjercicios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ejercicio5_ : ContentPage
    {
        public Ejercicio5_()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(EntryCantidad.Text);
            //billetes de 20, 10, 5, 1
            //hacer una division
            // X >=1
            int de20=0 , de10=0 , de5=0 , de1 = 0;
            if (cantidad > 20)
            {
                de20 = (int)Math.Floor(cantidad / 20);
                cantidad = cantidad % 20;
            }
            if (cantidad > 10)
            {
                de10 = (int)Math.Floor(cantidad / 10);
                cantidad = cantidad % 10;
            }
            if (cantidad > 5)
            {
                de5 = (int)Math.Floor(cantidad / 5);
                cantidad = cantidad % 5;
            }
            if (cantidad > 1)
            {
                de1 = (int)Math.Floor(cantidad / 1);
                cantidad = cantidad % 1;
            }
            DisplayAlert("Denominaciones", 
                "Denominaciones Billetes:\nDe 20:" 
                + de20.ToString()+" billete"+
                "\nDe 10:" + de10.ToString()+ " billete" +
                "\nDe 5:" + de5.ToString()+ " billete" +
                "\nDe 1:" + de1.ToString()+ " billete"
                , "ok");
        }
    }
}