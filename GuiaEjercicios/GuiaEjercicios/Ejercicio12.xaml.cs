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
    public partial class Ejercicio12 : ContentPage
    {/*12. /// App que calcule la tabla de multiplicar que el usuario ingrese
*/
        public Ejercicio12()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            int VarTabla;

            VarTabla = Convert.ToInt16(EntryTabla.Text);
            int i = 1;
            string VarTablaMultiplicar = "";
            while (++i <= 10)
            {
                VarTablaMultiplicar += "\n" + VarTabla + "*" + i + "=" + VarTabla * i;
            }
            DisplayAlert("Tabla de multiplicar del:" + VarTabla, VarTablaMultiplicar, "Ok");
        }
    }
}