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
    public partial class Ejercicio10 : ContentPage
    {
        /* 10. ---
         * App que muestre la calificación actitudinal de un estudiante ejemplo 10 equivale a
“Excelente” y 1 a “Necesita Mejorar”; rangos 1 – 4 “Necesita Mejorar”, 5 – 6 “Bueno” 7 – 9 “Muy
Bueno” y 10 “Excelente” el usuario ingresara su nota y la aplicación mostrara su resultado
actitudinal. */
        public Ejercicio10()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double VarNota;
            string VarNotaAptitudinal = "";
            VarNota = Convert.ToDouble(EntryNota.Text);

            if (VarNota == 10)
            {
                VarNotaAptitudinal = "Excelente";
            }
            else if (VarNota == 1)
            {
                VarNotaAptitudinal = "Necesita Mejorar";
            }
            else if (VarNota >= 1 && VarNota <= 4)
            {
                VarNotaAptitudinal = "Necesita Mejorar";
            }
            else if (VarNota >= 5 && VarNota <= 6)
            {
                VarNotaAptitudinal = "Bueno";
            }
            else if (VarNota >= 7 && VarNota <= 9)
            {
                VarNotaAptitudinal = "Muy Bueno";
            }
            DisplayAlert("La calificacion aptitudinal es:", VarNotaAptitudinal, "ok");

        }
    }
}