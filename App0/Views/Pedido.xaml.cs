using System;
using App0.Views;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App0.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pedido : ContentPage
    {


        public Pedido()
        {
            InitializeComponent();
            if (Application.Current.Properties.ContainsKey("Calle"))
            {
                var calle = Application.Current.Properties["Calle"] as string;
                Pedido pedido = this;
                BindingContext = pedido;
            }

        }

    }
}