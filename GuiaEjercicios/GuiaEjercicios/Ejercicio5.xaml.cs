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
	public partial class Ejercicio5 : ContentPage
	{
		public Ejercicio5 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(EntryCantidad.Text);
            //billetes de 20, 10, 5, 1
            //hacer una division
            // X >=1
            double modulo = cantidad % 20;
            int de20 = 0;
            if (cantidad > 20)
            {
                de20 = (int)Math.Floor(cantidad / 20);
            }
            DisplayAlert("Denominaciones", "De 20:" + de20.ToString(), "ok");
        }
    }
}