using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruta
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // instanciacion
            Frutax fruta1 = new Frutax();

            fruta1.Id = 5;
            fruta1.Nombre = "Mango";
            fruta1.Tipo = "...";
            fruta1.Peso = 50;
            fruta1.Precio = 20.00m;

            Frutax fruta2 = new Frutax();

            fruta2.Id = 2;
            fruta2.Nombre = "manzana";
            fruta2.Tipo = "...";
            fruta2.Peso = 10;
            fruta2.Precio = 5.00m;

            Frutax fruta3 = new Frutax();

            fruta3.Id = 6;
            fruta3.Nombre = "naranja";
            fruta3.Tipo = "...";
            fruta3.Peso = 12;
            fruta3.Precio = 8.00m;


            

            Repofruta Rf = new Repofruta();
            Rf.Mostrarfruta(fruta1);
            Console.WriteLine("--------------------------------------------");
            Frutax[] frutas = { fruta1,fruta2,fruta3 };

            Rf.Listarfruta(frutas);
            Console.WriteLine("------------------------------------------------");
            Rf.Venderfruta(frutas);


            Console.ReadKey();

        }
    }
}
