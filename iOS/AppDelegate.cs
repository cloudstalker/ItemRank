using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Foundation;
using UIKit;

namespace ItemRank.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App(FindPath()));

            return base.FinishedLaunching(app, options);
        }

        public string FindPath() { 

            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            string newDb = Path.Combine(libFolder, "Data.sqlite");
            string existDb = NSBundle.MainBundle.PathForResource("Data", "sqlite");
            if(!Directory.Exists(libFolder)){
                Directory.CreateDirectory(libFolder);
            }
            if(!File.Exists(newDb)){
                File.Copy(existDb, newDb);    
            }
            return newDb;
        }
    }
}
