using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fegyverarzenál
{
    class Program
    {
             enum fegyverek {apaökle, uzi, vipera, kézigránát, rpg7,revolver,bicska,};
        static void Main(string[] args)
        {
            //egy fegyvert csak egy példányban lehet eltárolni
            List<fegyverek> fegyvertár = new List<fegyverek>();
            Felpakol(fegyvertár); //összes fegyó be
            Kivesz(fegyvertár,fegyverek.vipera);  //egy fegyó ki
            Felvesz(fegyvertár, fegyverek.vipera); //egy fegyó a tár végére 
            Felvesz2(fegyvertár,2,fegyverek.bicska); //egy fegyvert beak a i. helyre

          
           
            Console.WriteLine("ennyi fegyver van a listában");
            int db = Fegyverszám(fegyvertár);
            Listázó(fegyvertár);
            
      
            Console.ReadKey();
        }

        private static void Listázó(List<fegyverek> fegyvertár)
        {
            foreach  (int fegyo in fegyvertár)
            {
                Console.Write($"{fegyo} ");
            }
            Listázó(fegyvertár);

        }

        private static int Fegyverszám(List<fegyverek> fegyvertár)
        {
            int db = fegyvertár.Count;

            return db;
           
        }

        private static void Felvesz2(List<fegyverek> fegyvertár, int i,fegyverek bicska)
        {
           
            if (!fegyvertár.Contains(bicska))
            {
                fegyvertár.Insert(i, fegyverek.bicska);
            }
            else
            {
                Console.WriteLine("bent van a fegyver már");
            }

            Listázó(fegyvertár);
        }

        private static void Felvesz(List<fegyverek> fegyvertár, fegyverek vipera)
        {
            if (!fegyvertár.Contains(vipera))
            {
                fegyvertár.Add(vipera);
            }
            else
            {
                Console.WriteLine("bent van a fegyver már");
            }

            Listázó(fegyvertár);
        }

        private static void Kivesz(List<fegyverek> fegyvertár, fegyverek vipera)
        {
            do
            {
                fegyvertár.Remove(vipera);

            } while (!fegyvertár.Contains(vipera));

            Listázó(fegyvertár);

        }

        private static void Felpakol(List<fegyverek> fegyvertár)
        {
            fegyvertár.Add(fegyverek.apaökle);
            fegyvertár.Add(fegyverek.bicska);
            fegyvertár.Add(fegyverek.kézigránát);
            fegyvertár.Add(fegyverek.revolver);
            fegyvertár.Add(fegyverek.rpg7);
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.vipera);

        }

    }
}
