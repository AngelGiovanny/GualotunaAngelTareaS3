using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GualotunaAngelTareaS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inicio : ContentPage
    {
        public inicio()
        {
            InitializeComponent();


        }

        private async void btnAcceder_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (txtUsuario.Text == "estudiante2021" && txtClave.Text == "uisrael2021")
                {
                    //almacenando en variables loque usuario ingresa
                    string usuario = txtUsuario.Text;
                    string password = txtClave.Text;

                    await Navigation.PushAsync(new MainPage(usuario));
                }
                else
                {
                    await DisplayAlert("Error", "Datos incorrectos", "OK");
                }

               
            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje De Alerta", ex.Message, "Salir");
            }
        }
    }
}