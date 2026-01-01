//bool @bool = false; // true|false  1 bit
//byte @byte = 0; // 0-255, 1 byte
//sbyte @sbyte = 0; // -128..127 1 byte
//short @short = 0; // -32768..32767 2 byte Int 16
//ushort @ushort = 0; // 0..65535 2 byte Uint 16
//int a = 10; // -2147483648...2146483647 4 byte Int32
//int b = 0b101; // бинарная форма b = 5
//int c = 0xFF; // шестнадцатиричная форма с = 255
//uint @uint = 15U; // 0..4294967295 4 byte UInt32
//long @long = 0; // 8 byte Int64
//ulong @ulong = 0; // 8 byte Int64
//var @var = 0; // 4 byte System.Single
//string hello = "Hello";
//object @object = null; // 4 byte
//AND - И  &&
//OR - ИЛИ ||
//NOT - НЕ  !
//XOR - Исключает ИЛИ  ^
namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int fib = 0;
            int prevfib = 0;
            Console.WriteLine("Задание 1");
            for (int newfib = 1; newfib < 89;)
            {
                prevfib = newfib;
                newfib = fib + newfib;
                fib = prevfib;
                Console.WriteLine(newfib);
            }

            Console.WriteLine("Задание 2");
            for (int chislo = 2; chislo < 20;)
            {
                chislo = chislo + 2;
                Console.WriteLine(chislo);
            }

            Console.WriteLine("Задание 3");
            for (int mnoj = 1; mnoj < 6;)
            {
                for(int mnojotely = 1; mnojotely < 6;)
                {
                    
                    Console.Write(" {0} * {1} = {2} ",mnojotely, mnoj ,mnojotely * mnoj);
                    mnojotely = mnojotely + 1;
                }
                Console.WriteLine();
                mnoj = mnoj + 1;
            }

            Console.WriteLine("Задание 4");
            string login = "";
            string passwordnot = "";
            string password = "qwerty";
            do
            {
                Console.WriteLine();
                Console.Write("Введите Логин: ");
                login = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Введите Пароль: ");
                passwordnot = Console.ReadLine();
            } while (passwordnot != password);
            Console.WriteLine();
            Console.WriteLine("Здравствуйте, {0}!", login);
        }
           
    }
}