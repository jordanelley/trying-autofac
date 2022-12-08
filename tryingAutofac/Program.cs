using System;
using Autofac;

namespace tryingAutofac
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<NzAgeCalc>().As<IAgeCalculator>();

            var container = containerBuilder.Build();
            var canUseZipChecker = container.Resolve<IAgeCalculator>();
            
            Console.WriteLine(canUseZipChecker.CanUseZip(18));
        }
    }
}