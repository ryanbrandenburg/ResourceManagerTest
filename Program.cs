using System;
using System.Resources;
using System.Globalization;
using System.Reflection;

namespace ResourceManagerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourceManager = new ResourceManager(
                "ResourceManagerTest.Resources.Program",
                typeof(Program).GetTypeInfo().Assembly
            );

            var french = new CultureInfo("fr-FR");

            CultureInfo.CurrentCulture = french;
            CultureInfo.CurrentUICulture = french;

            Console.WriteLine(resourceManager.GetString("Hello"));
        }
    }
}
