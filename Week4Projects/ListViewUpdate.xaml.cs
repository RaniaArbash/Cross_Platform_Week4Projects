using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Week4Projects
{
    public partial class ListViewUpdate : ContentPage
    {
        ObservableCollection<Contact> contacts;
        public ListViewUpdate()
        {
            InitializeComponent();

            contacts = new ObservableCollection<Contact>
            {
                new Contact(){name = "Roman", number="1234" , image="https://images.freeimages.com/images/small-previews/5da/coloured-paper-1421280.jpg"},
                new Contact(){name = "Conrad", number="33333", image="https://images.freeimages.com/images/small-previews/0cf/tulips-1-1377350.jpg"},
                new Contact(){name = "Nesa", number="4444" , image="https://images.freeimages.com/images/small-previews/48d/marguerite-1372118.jpg"}
            };
            mylist.ItemsSource = contacts;

        }

        void mylist_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Contact c = e.SelectedItem as Contact;
            updatedName.Text = c.name;
            updatedNumber.Text = c.number;
           
        }

        void call_Clicked(System.Object sender, System.EventArgs e)
        {
            var menu = sender as MenuItem;
            DisplayAlert("Calling  ", (menu.CommandParameter as Contact).name, "OK");
        }

        void delete_Clicked(System.Object sender, System.EventArgs e)
        {
            var todelete = ((sender as MenuItem).CommandParameter as Contact);
            contacts.Remove(todelete);
        }

        void Update_Clicked(System.Object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(updatedName.Text) ||
                (string.IsNullOrEmpty(updatedNumber.Text) ||
                mylist.SelectedItem == null))
            {
                DisplayAlert("Error  ", "Missing Values", "OK");
            }
            else
            {
                (mylist.SelectedItem as Contact).name = updatedName.Text;
                (mylist.SelectedItem as Contact).number = updatedNumber.Text;

            }

        }

    }
}
