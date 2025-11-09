using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Drawing.Printing.PrinterSettings;

namespace Brows
{
    internal static class Model
    {
        public static List<string> favorites = [.. Properties.Settings.Default.favorites.Cast<string>()];
        public static double zoomFactor = Properties.Settings.Default.zoomfactor;
        public static string appName = Properties.Settings.Default.appName;
        public static int startUpIndex = Properties.Settings.Default.startUpIndex;
        

        public static void Save() 
        {
            Properties.Settings.Default.startUpIndex = startUpIndex;
            Properties.Settings.Default.appName = appName;
            Properties.Settings.Default.zoomfactor = zoomFactor;
            Properties.Settings.Default.favorites.Clear();
            Properties.Settings.Default.favorites.AddRange([.. favorites]);

            Properties.Settings.Default.Save();
        }
    }
}