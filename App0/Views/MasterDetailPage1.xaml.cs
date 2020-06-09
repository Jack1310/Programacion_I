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
    public partial class MasterDetailPage1 : MasterDetailPage
    {
        public MasterDetailPage1()
        {
            NavigationPage.SetHasNavigationBar(this, false); 
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterDetailPage1MasterMenuItem;
            if (item == null)
                return;

            if(item.Title == "Tus Pedidos")
            {
                Navigation.PushAsync(new Pedido());
            }

            if (item.Title == "Configuración")
            {
                Navigation.PushAsync(new Configuracion());
            }

            if (item.Title == "Cerrar Sesión")
            {
                Navigation.PushAsync(new MainPage());
            }

            IsPresented = true;


            MasterPage.ListView.SelectedItem = null;
        }
    }
}