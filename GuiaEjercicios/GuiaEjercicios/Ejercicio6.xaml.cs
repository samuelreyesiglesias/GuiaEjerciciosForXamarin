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
    public partial class Ejercicio6 : ContentPage
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //Ejercicio 6: Calc. sueldo considerando horas trabajadas a $10. 
            //Bono si tiene 3 o más hijos y es de $25 por cada hijo si la cantidad de hijos 
            //es menor solo recibe un bono de $15 por C/hijo.
            double sueldo;
            int varHoras, varHijos;
            varHoras = Convert.ToInt32(EntryHorasTrabajadas.Text);
            varHijos = Convert.ToInt32(EntryCANTIDAD_HIJOS.Text);
            sueldo = varHoras * 10;
            if (varHijos >= 3) {
                sueldo += (25*varHijos);
            }
            else
            {
                sueldo += (15 * varHijos);
            }
            DisplayAlert("Notificacion", "El sueldo del empleado es:" + sueldo, "ok");
        }
    }
}