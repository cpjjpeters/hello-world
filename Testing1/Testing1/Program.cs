using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
 
    class Program
    {
        static void Main(string[] args)
        {
            BerekenBTW1(100);
            float result=BerekenKostprijs(100, 5, true, 19);
            Console.WriteLine("Result=" +result);
        }

        static void BerekenBTW1(float bedrag)
         {
             const float BTW = 0.19F;
             float result = bedrag + (bedrag * BTW);

         }

        static float BerekenKostprijs(float Bedrag, int Aantal, bool MetBTW = false, float BTWPercentage = 0.0F)
        {
            Console.WriteLine("Bedrag= {0}, Aantal={1},MetBTW={2},BTWPercentage= {3}", Bedrag, Aantal, MetBTW, BTWPercentage);
            float TotaalBedrag = Bedrag * Aantal;
            Console.WriteLine("TotaalBedrag="+TotaalBedrag);
            if (MetBTW)
            {
                float BTWBedrag = TotaalBedrag * BTWPercentage / 100;
                Console.WriteLine("BTWBedrag=" + BTWBedrag);
                TotaalBedrag += BTWBedrag;
                Console.WriteLine("TotaalBedrag=" + TotaalBedrag);
            }

            return TotaalBedrag;
        }
    }
}
