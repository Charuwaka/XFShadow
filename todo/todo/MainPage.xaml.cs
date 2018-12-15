using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcessLayer;
using Xamarin.Forms;

namespace todo
{
    public partial class MainPage : ContentPage
    {
        TodoItem _item;
        public MainPage()
        {
            InitializeComponent();
            _item = new TodoItem { Name = "Charwaka", Notes = "I'm Done" };
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            await App.Database.SaveItemAsync(_item);
            var s= await App.Database.GetItemAsync(1);
         }
    }
}
