using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItStep
{
    internal class ImageThread
    {
        public static async void ImageThread1() 
        {
           
            new Task(() => Process.Start(new ProcessStartInfo(@"C:\Users\garif\source\repos\ItStep\uzESA0sFus8.jpg") { UseShellExecute = true })).Start();

        }
    }
}
