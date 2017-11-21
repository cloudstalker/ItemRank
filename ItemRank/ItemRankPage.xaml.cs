using Xamarin.Forms;
using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;

namespace ItemRank
{
    public partial class ItemRankPage : ContentPage
    {
        public ItemRankPage()
        {
            InitializeComponent();
            //string resourcePath = "";
            //if(Device.RuntimePlatform == Device.Android){
            //    resourcePath = "ItemRank.Droid.";
            //}
            //if(Device.RuntimePlatform == Device.iOS){
            //    resourcePath = ;
            //}
            SQLiteConnection con = new SQLiteConnection("Data Source="+ path);
            ObservableCollection<Hero> heroes = new ObservableCollection<Hero>(con.Query<Hero>("select * from Heroes"));
        }
    }
}
