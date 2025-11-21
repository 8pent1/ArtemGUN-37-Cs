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

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine("Введите первое число");

        if (!Int32.TryParse(Console.ReadLine(), out var pervoe))
        {
            Console.WriteLine("Не число");
            return;
        }

        Console.WriteLine("Введите второе число");

        if (!Int32.TryParse(Console.ReadLine(), out var vtoroe))
        {
            Console.WriteLine("Не число");
            return;
        }

        Console.WriteLine("Введите знак");

        var s = Console.ReadLine();
        var BoolVar = true;
        
        if (s.Length == 0 || s.Length > 1 && !BoolVar)
        {
            Console.WriteLine("Неправильный знак");
            return;
        }


        switch (s[0])
        {
            case '+':
                Console.WriteLine("Сложение {0} + {1} = {2}:", pervoe, vtoroe, pervoe + vtoroe);
                break;
            case '-':
                Console.WriteLine("Вычитание {0} - {1} = {2}:", pervoe, vtoroe, pervoe - vtoroe);
                    break;
            case '*':
                Console.WriteLine("Умножение {0} * {1} = {2}:", pervoe, vtoroe, pervoe * vtoroe);
                break;
            case '/':
                if(vtoroe == 0)
                {
                    Console.WriteLine("деление на ноль невозможно");
                    return;
                }
                Console.WriteLine("Деление {0} / {1} = {2}:", pervoe, vtoroe, pervoe / vtoroe);
                break;
            case '%':
                Console.WriteLine("Проценты {0} % {1} = {2}:", pervoe, vtoroe, pervoe % vtoroe);
                break;
            case '&':
                Console.WriteLine("Оператор & {0} & {1}, Десятичная форма = {2}: Двоичная форма = {3}: Шестнадцатиричная форма = {4}:", pervoe, vtoroe, Convert.ToString(pervoe & vtoroe, 10), Convert.ToString(pervoe & vtoroe, 2), Convert.ToString(pervoe & vtoroe, 16));
                break;
            case '^':
                Console.WriteLine("Оператор ^ {0} ^ {1}, Десятичная форма = {2}: Двоичная форма = {3}: Шестнадцатиричная форма = {4}:", pervoe, vtoroe, Convert.ToString(pervoe ^ vtoroe, 10), Convert.ToString(pervoe ^ vtoroe, 2), Convert.ToString(pervoe ^ vtoroe, 16)); ;
                break;
            case '|':
                Console.WriteLine("Оператор | {0} | {1}, Десятичная форма = {2}: Двоичная форма = {3}: Шестнадцатиричная форма = {4}:", pervoe, vtoroe, Convert.ToString(pervoe | vtoroe, 10), Convert.ToString(pervoe | vtoroe, 2), Convert.ToString(pervoe | vtoroe, 16));
                break;
            default:
                Console.WriteLine("Неправильный знак");
                break;
        }

        










        
        
        
        
    }

}