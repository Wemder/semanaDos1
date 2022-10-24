using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace semanaDos1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Regristro : ContentPage
    {
        public Regristro(string usuario, string contrasena)
        {
            InitializeComponent();
            lblUsuarario.Text = "El usuarios es " + usuario + "La contraseña es " + contrasena;


        }

        private void btnInformacion_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            double nota1 = Convert.ToDouble(txtNotaParcialUno.Text);
            double nota2 = Convert.ToDouble(txtNotaParcialdos.Text);
            double nota =(nota1+nota2)/2;

               Resultado.Text=nota.ToString();


            if (nota>=7)
            {
                DisplayAlert("Mensaje de alerta", "Tu nombre es" + nombre + "\n Tu Apellido" + apellido + "\n Aprobastes con "+nota, "Cerrar");
            }
            else
            {
                DisplayAlert("Mensaje de alerta", "Tu nombre es" + nombre + "tu Apellido" + apellido + "Reprobastes con "+nota, "Cerrar");

            }
        }
    }
}