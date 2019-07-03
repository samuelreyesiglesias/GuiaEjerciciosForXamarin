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
    public partial class Ejercicio7 : ContentPage
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //ejercicio 4
            //mayor de tres numeros
            int n1, n2, n3;
            n1 = Convert.ToInt32(N1.Text);
            n2 = Convert.ToInt32(N2.Text);
            n3 = Convert.ToInt32(N3.Text);
            //asignar variables
  



            if (n1 < n2 && n2 < n3)
            {
                DisplayAlert("notificación", "El segundo es el Numero medio["+n2.ToString()+"]", "ok");
            }
            else if (n2 < n1 && n3 > n1)
            {
                DisplayAlert("notificación", "El Primero es el Numero medio[" + n1.ToString() + "]", "ok");
            }
            else
            {
                DisplayAlert("notificación", "El 3ro es el medio[" + n3.ToString() + "]", "ok");
            }
        }
    }
}