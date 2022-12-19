using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ItStep
{
    internal class Sborka
    {
        public async static void SborkaALL() 
        {
            foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
            {
                Console.WriteLine($"Name of assemblies: {asm.GetName().Name}");
            }

        }
        
           
        
    }
}
