using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fegyverarzenál
{
    class Program
    {
             enum fegyverek {apaökle, uzi, vipera, AK47, rpg7,};
        static void Main(string[] args)
        {
            fegyverek kezemben = fegyverek.apaökle;
            List<fegyverek> fegyvertár = new List<fegyverek>();
            fegyvertár.Add(fegyverek.uzi);
            fegyvertár.Add(fegyverek.vipera);
            foreach (fegyverek fegyver in fegyvertár)
            {
                Console.Write($"{fegyver} ");
            }

            Console.ReadKey();
        }
    }
}
