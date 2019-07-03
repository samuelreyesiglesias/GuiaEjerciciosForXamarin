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
    public partial class Ejercicio13 : ContentPage
    {
        public Ejercicio13()
        {

            /*13. /// App que sume los números impares del límite del número que el usuario establezca.
*/
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            int suma,limite,i;
            limite = Convert.ToInt32(EntryLimite.Text);
            suma = 0;
            i = 1;
            while (i<=limite) {
                suma += i;
                i += 2;
            }
            DisplayAlert("Sumatoria es:", suma.ToString(), "ok");
        }
    }
}