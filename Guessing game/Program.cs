using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cjezbasharp
{
    class Program
    {
        static void Main(string[] args)
        {

            string golrijec = "Pogodak";
            string pokusaj = "";
            int brojpokusaja = 5;
            int trenutnibrojpokusaja = 0;
            bool maxpokusaja = false;

            while (pokusaj != golrijec && maxpokusaja == false)
            {
                if (trenutnibrojpokusaja < brojpokusaja)
                {

                    Console.WriteLine("Pokusajte pogoditi rijec: ");
                    pokusaj = Console.ReadLine();

                    trenutnibrojpokusaja++;


                }
                else
                {
                    maxpokusaja = true;

                }
            }
            if (maxpokusaja)
            {
                Console.WriteLine("Niste pogodili rijec u 5 pokusaja");
            }
            else
            {
                Console.WriteLine("Pogodili ste rijec");
            }
            Console.ReadLine();
        }



    }
}