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
    public partial class Ejercicio11 : ContentPage
    {

        /*
         11. ---App que identifique el carácter que ingrese el usuario 
         si es un numero mensaje que mencione
que es un “Numero” si es una vocal el mensaje que es una “Vocal” y 
si es cualquier otra letra
que mencione que es una “Consonante”.

             */
        public Ejercicio11()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double VarNum;
            char VarCaracter;
            VarCaracter = Convert.ToChar( EntryCaracter.Text);
            bool isNum = double.TryParse(EntryCaracter.Text, out VarNum);

            if (isNum)
            {
                DisplayAlert("Notificacion","El caracter ingresado es un numero","ok");
            }
            else
            {
                if(VarCaracter=='a' || VarCaracter == 'e' || VarCaracter == 'i' || VarCaracter == 'o' || VarCaracter == 'u')
                {
                    DisplayAlert("Notificacion", "El caracter ingresado es una vocal", "ok");
                }
                else
                {
                    DisplayAlert("Notificacion", "El caracter ingresado es una consonate", "ok");
                }
            }

        }
    }
}