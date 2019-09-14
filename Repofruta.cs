using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruta
{
    class Repofruta
    {
        int opc = 0;
        public void Venderfruta(Frutax[] fruitv)
        {
            Console.WriteLine("Cual fruta desea comprar?");
            for(int i = 0;i<fruitv.Length; i++)
            {
                Console.WriteLine(fruitv[i].Nombre);
            }


            opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        {
                            Console.WriteLine(fruitv[0].Id+"\n"+fruitv[0].Nombre+" \n"+fruitv[0].Precio );
                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine(fruitv[1]);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine(fruitv[2]);
                            break;
                        }


                }

                
               
            

        }
        public void Listarfruta(Frutax[] fruitl)
        {
            for(int i = 0; i < fruitl.Length; i++)
            {
                Console.WriteLine(fruitl[i].Id+","+fruitl[i].Nombre+","+ fruitl[i].Tipo+","+fruitl[i].Peso+","+fruitl[i].Precio);
            }
        }
        public void Mostrarfruta(Frutax fruitm)
        {
            Console.WriteLine(fruitm.Id+","+ fruitm.Nombre+","+ fruitm.Tipo+","+ fruitm.Peso+","+fruitm.Precio);

           

        }
    }
}
