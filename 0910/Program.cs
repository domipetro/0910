namespace _0910
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*    F1();
                F2();
                F3();
                F4();
                F5();
                F6();
                F7();
                F8();
                F9();
                F10();
                F11();
                F12();
                F13();
                F14();
                F15();
                F16();
                F17();
                F18();
                F19();
                F20();
                F21();
                F22();
                F23();
                F24();
                F25();
                F26();
                F27();
                F28();
                F29();
                F30();
                F31();*/
            F32();
            F33();
            F34();
            F35();
            F36();
            F37();
            F38();
            F39();
            F40();
            F41();
        }

        static void F1() { Console.WriteLine("Hello world!"); }

        static void F2()
        {
            string name = "Pisti";
            Console.WriteLine($"Szia {name}!");
        }

        static void F3()
        {
            int number = 4;
            Console.WriteLine(number * 2);
        }

        static void F4()
        {
            int a = 8;
            int b = 4;
            Console.WriteLine($"Összeg: {a + b}");
            Console.WriteLine($"Különbség: {a - b}");
            Console.WriteLine($"Szorzat: {a * b}");
            Console.WriteLine($"Hányados: {a / b}");
        }

        static void F5()
        {
            int elso = 23;
            int masodik = 32;
            Console.WriteLine(elso > masodik ? elso : masodik);
        }

        static void F6()
        {
            int asd = 2, asd1 = 32, asd2 = 40;
            if (asd < asd1 && asd < asd2) Console.WriteLine(asd);
            else if (asd1 < asd && asd1 < asd2) Console.WriteLine(asd1);
            else Console.WriteLine(asd2);
        }

        static void F7()
        {
            int a = 24, b = 10, c = 51;
            if ((a + b > c) && (b + c > a) && (a + c > b))
                Console.WriteLine("A háromszög szerkeszthető!");
            else
                Console.WriteLine("A háromszög nem szerkeszthető!");
        }

        static void F8()
        {
            Console.WriteLine("Írd le az első számot: ");
            int a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Írd le a második számot: ");
            int b1 = int.Parse(Console.ReadLine());

            double szamtaniKozep = (a1 + b1) / 2.0;
            double mertenyiKozep = Math.Sqrt(a1 * b1);

            Console.WriteLine($"Számtani közép: {szamtaniKozep}");
            Console.WriteLine($"Mértani közép: {mertenyiKozep}");
        }

        static void F9()
        {

            Console.WriteLine("Add meg a másodfokú egyenlet együtthatóit (a, b, c):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int d = b * b - 4 * a * c;

            if (d < 0)
                Console.WriteLine("Az egyenletnek nincs valós megoldása.");
            else
                Console.WriteLine("Az egyenletnek van valós megoldása.");
        }

        static void F10()
        {

            Console.WriteLine("Add meg a másodfokú egyenlet együtthatóit (a, b, c):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int d = b * b - 4 * a * c;

            if (d < 0)
            {
                Console.WriteLine("Nincs valós megoldás.");
            }
            else if (d == 0)
            {
                int x = -b / (2 * a);
                Console.WriteLine($"Egy megoldás van: x = {x}");
            }
            else
            {
                double sqrtD = Math.Sqrt(d);
                int x1 = (int)((-b + sqrtD) / (2 * a));
                int x2 = (int)((-b - sqrtD) / (2 * a));
                Console.WriteLine($"Két egész megoldás (kerekítve): x1 = {x1}, x2 = {x2}");
            }
        }

        static void F11()
        {

            Console.WriteLine("Add meg a háromszög első befogóját: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a háromszög második befogóját: ");
            int b = int.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);
            Console.WriteLine($"Az átfogó hossza: {Math.Round(c, 2)}");
        }

        static void F12()
        {

            Console.WriteLine("Add meg a téglatest 3 élét (a, b, c):");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int felszin = 2 * (a * b + b * c + a * c);
            int terfogat = a * b * c;

            Console.WriteLine($"Felszín: {felszin}");
            Console.WriteLine($"Térfogat: {terfogat}");
        }

        static void F13()
        {

            Console.WriteLine("Add meg a kör átmérőjét: ");
            int d = int.Parse(Console.ReadLine());

            double r = d / 2.0;
            double kerulet = 2 * Math.PI * r;
            double terulet = Math.PI * r * r;

            Console.WriteLine($"Kerület: {Math.Round(kerulet, 2)}");
            Console.WriteLine($"Terület: {Math.Round(terulet, 2)}");
        }

        static void F14()
        {

            Console.WriteLine("Add meg a sugár hosszát: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a középponti szöget fokban: ");
            int szog = int.Parse(Console.ReadLine());

            double ivhossz = 2 * Math.PI * r * szog / 360;
            double terulet = Math.PI * r * r * szog / 360;

            Console.WriteLine($"Ívhossz: {Math.Round(ivhossz, 2)}");
            Console.WriteLine($"Körszelet terület: {Math.Round(terulet, 2)}");
        }
        static void F15()
        {

            Console.WriteLine("Adj meg egy pozitív egész számot: ");
            int r = int.Parse(Console.ReadLine());
            if (r < 1)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot: ");
                r = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= r; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");

        }
        static void F16()
        {

            Console.WriteLine("Adj meg egy pozitív egész számot: ");
            int r = int.Parse(Console.ReadLine());
            if (r < 1)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot: ");
                r = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= r; i++)
            {
                Console.WriteLine($"{i} ");
            }

        }
        static void F17()
        {

            Console.WriteLine("Adj meg egy pozitív egész számot: ");
            int r = int.Parse(Console.ReadLine());
            if (r < 1)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot: ");
                r = int.Parse(Console.ReadLine());
            }
            Console.Write($"A(z) {r} osztói: ");
            for (int i = 1; i <= r; i++)
            {

                if (r % i == 0)
                {
                    Console.Write($"{i} ");
                }

            }
            Console.WriteLine("\n");
        }

        static void F18()
        {

            Console.WriteLine("Adj meg egy pozitív egész számot: ");
            int r = int.Parse(Console.ReadLine());
            if (r < 1)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot: ");
                r = int.Parse(Console.ReadLine());
            }
            int osszeg = 0;
            Console.Write($"A(z) {r} osztóinak összege: ");
            for (int i = 1; i <= r; i++)
            {

                if (r % i == 0)
                {
                    osszeg += i;
                }

            }
            Console.WriteLine(osszeg);
            Console.WriteLine("\n");



        }

        static void F19()
        {

            Console.WriteLine("Adj meg egy pozitív egész számot: ");
            int r = int.Parse(Console.ReadLine());
            if (r < 1)
            {
                Console.WriteLine("Adj meg egy pozitív egész számot: ");
                r = int.Parse(Console.ReadLine());
            }
            int osszeg = 0;
            int szorzat = r * 2;

            for (int i = 1; i <= r; i++)
            {

                if (r % i == 0)
                {
                    osszeg += i;
                }


            }

            if (osszeg == szorzat)
            {
                Console.WriteLine($"A(z) {r} tökéletes szám, mivel osztóinak összege ({osszeg}) egyenlő a szám kétszeresével ({szorzat}).");
            }
            else
            {
                Console.WriteLine($"A(z) {r} nem tökéletes számmivel osztóinak összege ({osszeg}) nem egyenlő a szám kétszeresével ({szorzat}).");
            }
            Console.WriteLine("\n");

        }
        static void F20()
        {

            Console.WriteLine("Add meg a hatványalapot: ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Add meg a kitevőt: ");
            int t = int.Parse(Console.ReadLine());
            double eredmeny = Math.Pow(r, t);
            Console.WriteLine($"Hatványalap: {r}");
            Console.WriteLine($"Kitevő: {t}");
            Console.WriteLine($"Hatványérték: {eredmeny}");
            Console.WriteLine("\n");
        }
        static void F21()
        {
            int szam = 0;

            while (szam <= 0)
            {
                Console.Write("Adj meg egy pozitív számot: ");
                szam = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A megadott szám: {szam}");
        }
        static void F22()
        {
            int osszeg = 0;
            int szam = 0;
            while (szam < 10)
            {
                Console.Write("Adj meg egy pozitív számot: ");
                szam = int.Parse(Console.ReadLine());
                if (szam < 10)
                {
                    osszeg += szam;
                }
            }

            Console.WriteLine($"A megadott számok összege: {osszeg}");
        }
        static void F23()
        {
            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());

            int eredeti = szam;
            Console.Write($"{eredeti} = ");


            while (szam % 2 == 0)
            {
                Console.Write("2*");
                szam = szam / 2;
            }


            Console.WriteLine(szam);
            Console.WriteLine("\n");
        }
        static void F24()
        {
            Console.Write("Kérek az alma szót: ");
            string alma = Console.ReadLine();




            while (alma != "alma")
            {
                Console.WriteLine("Nem az alma szót írta!");
                Console.Write("Kérek az alma szót: ");
                alma = Console.ReadLine();
            }

            Console.WriteLine("Az alma gyümölcs!");


            Console.WriteLine("\n");
        }
        static void F25()
        {
            Console.Write("Kérek egy egész számot: ");
            int eredeti = int.Parse(Console.ReadLine());

            int szam = eredeti;
            int hanyados = 0;

            while (szam >= 3)
            {
                szam = szam - 3;
                hanyados = hanyados + 1;
            }


            Console.WriteLine($"{eredeti} = {hanyados}*3+{szam}");
        }
        static void F26()
        {
            Console.Write("Kérek egy egész számot: ");
            int szam = int.Parse(Console.ReadLine());


            int primszam = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    primszam++;
                }

            }
            if (primszam == 2)
            {
                Console.WriteLine("A szám prím.");
            }
            else
            {
                Console.WriteLine("A szám nem prím.");
            }



        }

        static void F27()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i++)
            {
                bool prim = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prim = false;
                    }
                }

                if (prim)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void F28()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"A {n} prímosztói:");

            for (int i = 2; i <= n; i++)
            {

                if (n % i == 0)
                {

                    bool prim = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            prim = false;
                        }
                    }

                    if (prim)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static void F29()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());

            int szam = n;
            Console.Write($"{n} = ");

            bool elso = true;

            for (int i = 2; i <= szam; i++)
            {
                bool prim = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prim = false;
                    }
                }

                if (prim)
                {
                    while (szam % i == 0)
                    {
                        if (!elso)
                            Console.Write("*");
                        Console.Write(i);
                        elso = false;
                        szam /= i;
                    }
                }
            }
        }
        static void F30()
        {
            Console.WriteLine("Add meg az elso szamot: ");
            int m = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Add meg a masodik szamot: ");
            int n = int.Parse(Console.ReadLine()!);

            int lnko = LNKO(m, n);
            Console.WriteLine("LNKO: " + lnko); 
            static int LNKO(int a, int b)
        {
            int r = a % b;
            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        } 
        }

       
        static void F31()
        {
            Console.Write("Add meg az első számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Add meg a második számot: ");
            int b = int.Parse(Console.ReadLine());

            
            int eredetiA = a;
            int eredetiB = b;
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            int lnko = a;

            
            int lkkt = (eredetiA / lnko) * eredetiB;

            Console.WriteLine($"A legkisebb közös többszörös: {lkkt}");
        }

    

    
        static void F32()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
        }

   
        static void F33()
        {
            Console.Write("Adj meg egy számot: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} + {i} = {n + i}");
            }
        }

       
        static void F34()
        {
            for (int x = 10; x < 100; x++)
            {
                for (int y = x + 1; y < 100; y++)
                {
                    int prod1 = x * y;

                    int x1 = x / 10;
                    int x2 = x % 10;
                    int y1 = y / 10;
                    int y2 = y % 10;

                    int x_swapped = x2 * 10 + x1;
                    int y_swapped = y2 * 10 + y1;

                    if (x_swapped * y_swapped == prod1)
                    {
                        Console.WriteLine($"{x} * {y} = {prod1} == {x_swapped} * {y_swapped}");
                    }
                }
            }
        }

        static void F35()
        {
            for (int i = 0; i < 13; i++)
            {
                char c1 = (char)('a' + i);
                char c2 = (char)('a' + i + 13);

                if (c2 > 'z') break;

                Console.WriteLine($"{c1} {(int)c1}\t{c2} {(int)c2}");
            }
        }

        
        static void F36()
        {
            Console.Write("Sorok száma: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Oszlopok száma: ");
            int cols = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    char ch = ((i + j) % 2 == 0) ? 'X' : 'O';
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }

      
        static void F37()
        {
            Console.Write("Add meg a sorok számát: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int csillagok = 2 * i + 1;
                Console.WriteLine(new string('*', csillagok));
            }
        }


        static void F38()
        {
            Console.Write("Add meg a sorok számát: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                int space = a - i - 1;
                int stars = 2 * i + 1;
                Console.WriteLine(new string(' ', space) + new string('*', stars));
            }
        }

      
        static void F39()
        {
            Console.Write("Adj meg M-et (szélesség): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Adj meg N-t (magasság): ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    Console.WriteLine(new string('*', m));
                }
                else
                {
                    Console.WriteLine("*" + new string(' ', m - 2) + "*");
                }
            }
        }


        static void F40()
        {
            Console.Write("Adj meg egy számot: ");
            int limit = int.Parse(Console.ReadLine());

            for (int num = 2; num <= limit; num++)
            {
                int sum = 1;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0) sum += i;
                }

                if (sum == num)
                {
                    Console.WriteLine($"{num} tökéletes szám.");
                }
            }
        }

    
        static void F41()
        {
            const string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i = 0; i < 26; i++)
            {
                string shifted = abc.Substring(i) + abc.Substring(0, i);
                Console.WriteLine(shifted);
            }
        }
    }

}




