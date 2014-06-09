using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoDServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        private static void LocalizationTest()
        {
            Resource.Naming.Culture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(Resource.Naming.ShadowlessSpear);
            Resource.Naming.Culture = new System.Globalization.CultureInfo("ko-KR");
            Console.WriteLine(Resource.Naming.ShadowlessSpear);
        }
    }
}
