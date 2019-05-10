using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckBehavior
{
    class Program
    {
        static void Main(string[] args)
        {
            var patka = TvornicaPataka.VratiDivlju();
            patka.Poleti();
            patka.Kvakni();
            patka.setLetenje(new Letenje.RaketniLet());
            patka.Poleti();
            var drvena = TvornicaPataka.VratiDrvenu();
            drvena.Poleti();
            drvena.Kvakni();
            var gumi = TvornicaPataka.VratiGumenu();
            gumi.Kvakni();
            gumi.Poleti();
            gumi.Plivaj();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
