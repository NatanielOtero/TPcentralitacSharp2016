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

            Telefonica = Telefonica + Localuno;
            //Console.WriteLine("Local");
            Console.Write(Localuno.ToString());
            Telefonica = Telefonica + provUno;
            //Console.WriteLine("Provincial");
            Console.Write(provUno.ToString());
            Telefonica = Telefonica + localdos;
            //Console.WriteLine("Local");
            Console.Write(localdos.ToString());
            Telefonica = Telefonica + provDos;
            //Console.WriteLine("Provincial");
            Console.Write(provDos.ToString());



            Console.Write(Telefonica.ToString());
            Telefonica.OrdenarLlamadas();
            Console.WriteLine("Se ordenaron las llamadas");
            Console.Write(Telefonica.ToString());
            Console.ReadKey();

            

        }
    }
}
