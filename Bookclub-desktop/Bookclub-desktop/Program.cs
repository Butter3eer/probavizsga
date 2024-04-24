using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Bookclub_desktop
{
    internal class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            if (args.Length == 1 && args[0] == "--stat") 
            {
                Console.WriteLine("Stats");
                Statisztika.Beolvasas();
            }
            else
            {
                new Application().Run(new MainWindow());
            }
        }
    }
}
