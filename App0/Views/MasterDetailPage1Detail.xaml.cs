using App0.ViewModels;
using App0.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App0
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        private void jardin_clicked(object sender, EventArgs e)
        {
            //Navigate to Wellcom page after successfully login  
            Navigation.PushAsync(new Mapa());
        }

        private void plomero_clicked(object sender, EventArgs e)
        {
            //Navigate to Wellcom page after successfully login  
            Navigation.PushAsync(new Mapa());
        }

        private void electricista_clicked(object sender, EventArgs e)
        {
            //Navigate to Wellcom page after successfully login  
            Navigation.PushAsync(new Mapa());
        }

        public MasterDetailPage1Detail()
        {
            InitializeComponent();
        }

    }
}