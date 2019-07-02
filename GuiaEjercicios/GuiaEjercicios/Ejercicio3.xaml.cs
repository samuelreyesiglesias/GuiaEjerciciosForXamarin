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
	public partial class Ejercicio3 : ContentPage
	{
		public Ejercicio3 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = Convert.ToInt32(N1.Text);
            n2 = Convert.ToInt32(N2.Text);
            if (n1>n2)
            {
                DisplayAlert("Mayor de 2 numeros"," El mayor numero es el primero[:" + n1.ToString()+"]", "Ok");
            }
            else
            {
                DisplayAlert("Mayor de 2 numeros", " El mayor numero es el segundo[:" + n1.ToString() + "]", "Ok");
            }
        }
    }
}