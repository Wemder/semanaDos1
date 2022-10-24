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
    public partial class loguin : ContentPage
    {
        public loguin()
        {
            InitializeComponent();
        }

        private async void  btnInicio_Clicked(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new Regristro(txtUsuario.Text, txtContraseña.Text));

            string usuario = "estudiante2022";
            string contrasena = "uisrael2022";
            string tusuario = txtUsuario.Text;
            string tcontrasena = txtContraseña.Text;

            if (usuario == tusuario & contrasena == tcontrasena) 
            {
                DisplayAlert("Alerta", "Usuario correcto", "Cerrar");
                
                
            }
            else
            {
               DisplayAlert("Alerta", "Usuario no existe", "Cerrar");

            }

        }
    }
}