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
    public partial class Ejercicio9 : ContentPage
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {


            string VarEstadoCivil = "";
            switch (EntryEstadoCivil.Text)
            {
                case "s":
                    VarEstadoCivil = "Soltero";
                    break;
                case "c":
                    VarEstadoCivil = "Casado";
                    break;
                case "a":
                    VarEstadoCivil = "Acompañado";
                    break;
                case "v":
                    VarEstadoCivil = "Viudo";
                    break;

                default:
                    VarEstadoCivil = "Error al seleccionar estado civil";
                    break;
            }
            DisplayAlert("Estado civil:", VarEstadoCivil, "ok");

        }
    }
}