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
    public partial class Ejercicio4 : ContentPage
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //ejercicio 4
            //mayor de tres numeros
            double n1, n2, n3;
            n1 = Convert.ToDouble(N1.Text);
            n2 = Convert.ToDouble(N2.Text);
            n3 = Convert.ToDouble(N3.Text);
            //asignar variables
            if (n1 > n2 && n1 > n3) {
                DisplayAlert("notificación", "El primero es el mayor", "ok");
            } else if(n2 > n1 && n2 > n3) {
                DisplayAlert("notificación", "El 2do es el mayor", "ok");
            }else{
                DisplayAlert("notificación", "El 3ro es el mayor", "ok");
            }
        }
    }
}