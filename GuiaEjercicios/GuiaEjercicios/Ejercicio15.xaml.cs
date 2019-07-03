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
    public partial class Ejercicio15 : ContentPage
    {
        int intentos = 0;
        public Ejercicio15()
        {
            /*
             * 15. +++App que simule un Loggin que permita que el usuario tenga 3 oportunidades de ingresar la
contraseña correcta
             */
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(EntryUser.Text=="Sam" && EntryPass.Text == "12345")
            {
                DisplayAlert("Logeado con exito","Presiona ok para continuar","ok");
            }
            else
            {
                DisplayAlert("Login incorrecto", "Presiona ok para continuar", "ok");
                intentos++;
            }
            if (intentos > 3)
            {
                System.Environment.Exit(0);
            }
        }
    }
}