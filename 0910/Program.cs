namespace _0910
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                F1();
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

        }
    }

