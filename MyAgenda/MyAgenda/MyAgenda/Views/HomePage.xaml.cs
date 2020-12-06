using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAgenda.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyAgenda.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public List<Contacts> Contactos = new List<Contacts>();

        public HomePage()
        {
            InitializeComponent();
            this.Contactos = new List<Contacts>();
            Contacts contacto = new Contacts()
            {
                Name = "Lara",
                Number = "555 555 555",
                Email = "lara@test.com"
            };
            this.Contactos.Add(contacto);
            this.contactos.ItemsSource = this.Contactos;
        }

        private async void AddContact_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewContact());

        }
    }
}