using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita Telefonica = new Centralita("Telefonica");
            Local Localuno = new Local("Jorge",30,"Carlos",2.65f);
            Provincial provUno = new Provincial("JorgeProv", 21, "Carlosprov", Franja.Franja_1);
            Local localdos = new Local("Roberto", 45, "JoseLuis", 1.99f);
            Provincial provDos = new Provincial(Franja.Franja_3, provUno);

            Telefonica.Llamadas.Add(Localuno);
            //Console.WriteLine("Local");
            Localuno.Mostrar();
            Telefonica.Llamadas.Add(provUno);
            //Console.WriteLine("Provincial");
            provUno.Mostrar();
            Telefonica.Llamadas.Add(localdos);
            //Console.WriteLine("Local");
            localdos.Mostrar();
            Telefonica.Llamadas.Add(provDos);
            //Console.WriteLine("Provincial");
            provDos.Mostrar();



            Telefonica.Mostrar();
            Telefonica.OrdenarLlamadas();
            Console.WriteLine("Se ordenaron las llamadas");
            Telefonica.Mostrar();
            Console.ReadKey();

            

        }
    }
}
