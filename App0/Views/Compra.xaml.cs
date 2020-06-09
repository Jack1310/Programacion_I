using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App0.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Mapa : ContentPage
    {
        private void Comprabtn_Clicked(object sender, EventArgs e)
        {
            //null or empty field validation, check weather email and password is null or empty  
            if (string.IsNullOrEmpty(Calle.Text) || (IndustryTypePicker1.SelectedIndex == -1) || (string.IsNullOrEmpty(Descripcion.Text)) || (IndustryTypePicker2.SelectedIndex == -1))
                DisplayAlert("Credenciales Vacías", "Es obligatorio llenar todos los campos", "OK");
            else
            {
                // Store all  Values  
                Application.Current.Properties["Calle"] = Calle.Text;
                Application.Current.Properties["Descripción: "] = Descripcion.Text;
                Application.Current.Properties["IsMVP: "] = IndustryTypePicker1.Title;
                var calle = Calle.Text;
                var descripcion = Descripcion.Text;
                DisplayAlert("¡Se ha completado el pedido!", "Por favor espere a que lleguen para atenderlo.\nTiempo estimado: 5 min", "OK");
                Application.Current.SavePropertiesAsync();
            }

        }



        public Mapa()
        {
            InitializeComponent();
        }
    }
}