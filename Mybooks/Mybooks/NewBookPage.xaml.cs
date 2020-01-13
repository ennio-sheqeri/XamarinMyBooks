using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mybooks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewBookPage : ContentPage
    {
        public NewBookPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                Name = nameEntry.Text,
                Author = authorEnrty.Text
            };

            //Insert the book in database 
          using  (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                //Create tabel method every click save but if the table was created one time the comand don't create a new tabel
                conn.CreateTable<Book>();
                // now we can insert into it.
                var numberofRows = conn.Insert(book);
                if (numberofRows > 0)
                {
                    DisplayAlert("Success", "Book successfully inserted", "Grate!");
                }
                else DisplayAlert("Failure", "Book failed to be Inserted", "Dang it!");
            }

            

        }
    }
}