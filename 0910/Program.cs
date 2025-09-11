namespace _0910
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Console.WriteLine("Hello world!");
            //2. feladat
            string name = "Pisti";
            Console.WriteLine($"Szia {name}!");
            //3.feladat
            int number = 4;
            Console.WriteLine(number * 2);
            //4.feladat
            int a = 8;
            int b = 4;
            Console.WriteLine($"Összeg: {a + b}");
            Console.WriteLine($"Különbség: {a - b}");
            Console.WriteLine($"Szorzat: {a * b}");
            Console.WriteLine($"Hányados: {a / b}");
            //5. feladat

            int elso = 23;
            int masodik = 32;
            if(elso > masodik)
            {
                Console.WriteLine(elso);
            }
            else
            {
                Console.WriteLine(masodik);
            }
            //6. feladat

            int asd = 2;
            int asd1 = 32;
            int asd2 = 40;

            if (asd < asd1 && asd < asd2)
            {
                Console.WriteLine(asd);
            }
            else if (asd1 < asd && asd1 < asd2)
            {
                Console.WriteLine(asd1);
            }
            else {
                Console.WriteLine(asd2);
            }

            //7. feladat
            int euf = 24;
            int euf2 = 10;
            int euf3 = 51;

            if ((euf + euf2) > euf3 && (euf2 + euf3) > euf && (euf + euf3) > euf2)
            {
                Console.WriteLine("A háromszög szerkeszthető!");
            }
            else { Console.WriteLine("A háromszög nem szerkeszthető!"); }

            //8. feladat
            Console.WriteLine("Írd le az első számot: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Írd le a második számot: ");
            int b1 = int.Parse(Console.ReadLine());

            
            double szamtaniKozep = (a1 + b1) / 2;

            
            double mertenyiKozep = Math.Sqrt(a1 * b1);

            
            Console.WriteLine(szamtaniKozep);
            Console.WriteLine(mertenyiKozep);

            //9.feladat


        }
    }
}
