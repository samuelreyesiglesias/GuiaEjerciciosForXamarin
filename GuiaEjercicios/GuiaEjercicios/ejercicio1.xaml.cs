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
	public partial class ejercicio1 : ContentPage
	{
		public ejercicio1 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double n1, n2, s,r,m,d;
            n1 = Convert.ToDouble(N1.Text);
            n2 = Convert.ToDouble(N2.Text);
            s = n1 + n2;
            r = n1 - n2;
            d = n1 / n2;
            m = n1 * n2;
            DisplayAlert("Operaciones basicas", "Suma:" + s.ToString() + " resta:" + r.ToString() + " multiplicacion :" + m.ToString() + " division:" + d.ToString(), "ok");
        }
    }
}