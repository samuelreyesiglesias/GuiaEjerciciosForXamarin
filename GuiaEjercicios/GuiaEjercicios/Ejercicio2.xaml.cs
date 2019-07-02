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
	public partial class Ejercicio2 : ContentPage
	{
		public Ejercicio2 ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double VarHamburguesas, VarBebidas, VarTotal;
            VarBebidas = Convert.ToInt16(EntryBebidas.Text)*0.5;
            VarHamburguesas = Convert.ToInt16(EntryHamburguesas.Text)*1;
            VarTotal = VarBebidas + VarHamburguesas;
            DisplayAlert("Notificacion", "Gasto en Hamburguesas"+VarHamburguesas.ToString()+"Gasto en Bebidas:"+VarBebidas.ToString()+"El total gastado es:" + VarTotal.ToString(),"ok");
        }
    }
}