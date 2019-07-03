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
    public partial class Ejercicio8 : ContentPage
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string diaSeleccionado;
            diaSeleccionado = "";
            switch (EntryDiaSemana.Text)
            {
                case "1":
                    diaSeleccionado = "Lunes";
                    break;
                case "2":
                    diaSeleccionado = "Martes";
                    break;
                case "3":
                    diaSeleccionado = "Miercoles";
                    break;
                case "4":
                    diaSeleccionado = "Jueves";
                    break;
                case "5":
                    diaSeleccionado = "Viernes";
                    break;
                case "6":
                    diaSeleccionado = "Sabado";
                    break;
                case "7":
                    diaSeleccionado = "Domingo";
                    break;
            }
            DisplayAlert("Dia seleccionado:", diaSeleccionado, "ok");
        }
    }
}