using System;

namespace lab1task1
{
    class Task1
    {
        static void Main()
        {
            Console.WriteLine("Выведите на консоль минимальные и максимальные значения для предопределенных типов данных CTS.");
     
            Console.WriteLine("\nЦелочисленные типы данных:");
            Console.WriteLine("byte: min = " + byte.MinValue + ", max = " + byte.MaxValue);
            Console.WriteLine("sbyte: min = " + sbyte.MinValue + ", max = " + sbyte.MaxValue);
            Console.WriteLine("short: min = " + short.MinValue + ", max = " + short.MaxValue);
            Console.WriteLine("ushort: min = " + ushort.MinValue + ", max = " + ushort.MaxValue);
            Console.WriteLine("int: min = " + int.MinValue + ", max = " + int.MaxValue);
            Console.WriteLine("uint: min = " + uint.MinValue + ", max = " + uint.MaxValue);
            Console.WriteLine("long: min = " + long.MinValue + ", max = " + long.MaxValue);
            Console.WriteLine("ulong: min = " + ulong.MinValue + ", max = " + ulong.MaxValue);
            
            Console.WriteLine("\nТипы данных с плавающей точкой:");
            Console.WriteLine("float: min = " + float.MinValue + ", max = " + float.MaxValue);
            Console.WriteLine("double: min = " + double.MinValue + ", max = " + double.MaxValue);
            
            Console.WriteLine("\nДесятичный тип данных:");
            Console.WriteLine("decimal: min = " + decimal.MinValue + ", max = " + decimal.MaxValue);
            
            Console.WriteLine("\nСимвольный тип данных:");
            Console.WriteLine("char: min = " + char.MinValue + ", max = " + char.MaxValue);
            
            Console.WriteLine("\nЛогический тип данных:");
            Console.WriteLine("bool принимает 2 значения: 1 - true; 0 - false");
            
            Console.WriteLine("\nТипы данных string и object не имеют минимальных и максимальных значений, они предназначены для хранения набора символов и типа данных соответственно");
        }
    }
}
