using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlexSolorzanoExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if ((user == "Alex") && (pass == "12345"))
            {
                await Navigation.PushAsync(new Registro(user, pass));
                
            }
            else
            {
                DisplayAlert("Alerta", "Credenciales Incorectas", "cerrar");
            }

        }
    }
}
