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
﻿namespace HW
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            int[] arrayFibonachi = new[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            string[] month = new[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int[][] arraymatrica = new[]
            {
                new[] { 2, 3, 4 },
                new[] { 4, 9, 16 },
                new[] { 8, 27, 64}
            };
            Console.WriteLine("Задание 3");
            for (i = 0; i < 3; i++)
            {
                arraymatrica[0][i] = i;
                Console.Write("{0}\t", arraymatrica[1][i]);
            }
            for (i = 0; i < 3; i++)
            {
                arraymatrica[1][i] = i;
                Console.Write("{0}\t", arraymatrica[1][i]);
            }
            for (i = 0; i < 3; i++)
            {
                arraymatrica[2][i] = i;
                Console.Write("{0}\t", arraymatrica[1][i]);
            }


            int[][] myArr = new int[4][];
            myArr[0] = new int[5] { 1, 2, 3, 4, 5 };
            myArr[1] = new int[2] { (int)2.718, (int)3.141 };
            myArr[2] = new int[4] { 1, 10, 100, 1000 };
            Console.WriteLine();
            Console.WriteLine("Задание 4");
            for (; i < 5; i++)
            {
                myArr[0][i] = i;
                Console.Write("{0}\t", myArr[0][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 2; i++)
            {
                myArr[1][i] = i;
                Console.Write("{0}\t", myArr[1][i]);
            }

            Console.WriteLine();
            for (i = 0; i < 4; i++)
            {
                myArr[2][i] = i;
                Console.Write("{0}\t", myArr[2][i]);
            }

            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            Array.Copy(array, array2, 3);
            var l = 0;
            Console.WriteLine();
            Console.WriteLine("Задание 5");
            for (l = 0; l < array2.Length; l++)
            {
                Console.WriteLine(array2[l]);
            }
            string[] sample = { "", "" };
            Array.Resize(ref array, array2.Length * 2);
            Console.WriteLine("Задание 6");
            for (l = 0; l < array.Length; l++)
            {
                Console.WriteLine(array[l]);
            }
        }
    }
}