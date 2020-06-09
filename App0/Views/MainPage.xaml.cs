using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace App0
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]

    public partial class MainPage : ContentPage
    {
        private void Loginbtn_Clicked(object sender, EventArgs e)
        {
            //null or empty field validation, check weather email and password is null or empty  
            if (string.IsNullOrEmpty(Email.Text) || string.IsNullOrEmpty(Password.Text))
                DisplayAlert("Credenciales Vacias", "Ingrese Email y Contraseña", "OK");
            else
            {
                if (Email.Text == "abc@gmail.com" && Password.Text == "1234")
                {
                    DisplayAlert("Login Correcto", "", "Ok");
                    //Navigate to Wellcom page after successfully login  
                    Navigation.PushAsync(new MasterDetailPage1());
                }
                else
                    DisplayAlert("Login Fallido", "Por favor ingrese el Email y Contraseña correctos", "OK");
            }

        }

        public MainPage()
        {
            InitializeComponent();
        }

    }

}
