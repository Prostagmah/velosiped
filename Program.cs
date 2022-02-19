using System;

namespace Velosiped
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                rule b = new rule();
                b.rulle = "Ваш руль: AMD Ryzen 5 2600 SIX-CORE PROCESSOR";
                b.getrulee();
            }
            {
                kolesa a = new kolesa();
                a.kollesa = "Ваши два колеса: Corsair Dominator Platinum RGB 32GB DDR4-3200MHz"; 
                a.getkolesaa();
            }
            {
                rama c = new rama();
                c.raama = "Ваша рама: Prime B450M-A";
                c.getrama();
            }
            {
                Pidaly d = new Pidaly();
                d.pidalyy = "Ваши пидали: Chieftec 750W Polaris";
                d.getpidaly();
            }
            Console.WriteLine("Поздравляю, отличный игровой велосипед! Как раз под Cyberpunk 2077!");
            Console.ReadKey();
        }
    }
}
