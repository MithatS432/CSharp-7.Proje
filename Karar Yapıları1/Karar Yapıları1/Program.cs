using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karar_Yapıları1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Notunuzu giriniz (0-100): ");
            int not = int.Parse(Console.ReadLine());
            if(not<0 || not>100)
            {
                Console.WriteLine("Lütfen 0-100 arasında bir not giriniz.");
            }
            else if (not >= 90)
            {
                Console.WriteLine("Harf Notu: AA");
            }
            else if (not >= 80)
            {
                Console.WriteLine("Harf Notu: BA");
            }
            else if (not >= 70)
            {
                Console.WriteLine("Harf Notu: BB");
            }
            else if (not >= 60)
            {
                Console.WriteLine("Harf Notu: CB");
            }
            else if (not >= 50)
            {
                Console.WriteLine("Harf Notu: CC");
            }
            else
            {
                Console.WriteLine("Harf Notu: FF (Kaldınız)");
            }
        }
    }
}
