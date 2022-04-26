using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AlexSolorzanoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Resumen : ContentPage
    {

        public Resumen(string nombre, string user, string fina)
        {
            InitializeComponent();
            lbluser1.Text =  user;
            lbluser.Text = nombre;
            txtFinal.Text = fina;

        }

    }
}