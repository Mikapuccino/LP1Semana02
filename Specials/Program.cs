using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            byte bMax = byte.MaxValue;
            byte bMin = byte.MinValue;
            Console.WriteLine($"Byte max value = {bMax}");
            Console.WriteLine($"Byte min value = {bMin}\n");

            sbyte sbMax = sbyte.MaxValue;
            sbyte sbMin = sbyte.MinValue;
            Console.WriteLine($"sByte max value = {sbMax}");
            Console.WriteLine($"sByte min value = {sbMin}\n");

            short shMax = short.MaxValue;
            short shMin = short.MinValue;
            Console.WriteLine($"Short max value = {shMax}");
            Console.WriteLine($"Short min value = {shMin}\n");

            ushort ushMax = ushort.MaxValue;
            ushort ushMin = ushort.MinValue;
            Console.WriteLine($"uShort max value = {ushMax}");
            Console.WriteLine($"uShort min value = {ushMin}\n");

            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine($"Int max value = {intMax}");
            Console.WriteLine($"Int min value = {intMin}\n");

            uint uintMax = uint.MaxValue;
            uint uintMin = uint.MinValue;
            Console.WriteLine($"uInt max value = {uintMax}");
            Console.WriteLine($"uInt min value = {uintMin}\n");

            long longMax = long.MaxValue;
            long longMin = long.MinValue;
            Console.WriteLine($"Long max value = {longMax}");
            Console.WriteLine($"Long min value = {longMin}\n");

            ulong ulongMax = ulong.MaxValue;
            ulong ulongMin = ulong.MinValue;
            Console.WriteLine($"uLong max value = {ulongMax}");
            Console.WriteLine($"uLong min value = {ulongMin}\n");

            float fMax = float.MaxValue;
            float fMin = float.MinValue;
            Console.WriteLine($"Float max value = {fMax}");
            Console.WriteLine($"Float min value = {fMin}\n");

            double dbMax = double.MaxValue;
            double dbMin = double.MinValue;
            Console.WriteLine($"Double max value = {dbMax}");
            Console.WriteLine($"Double min value = {dbMin}\n");

            decimal dcMax = decimal.MaxValue;
            decimal dcMin = decimal.MinValue;
            Console.WriteLine($"Decimal max value = {dcMax}");
            Console.WriteLine($"Decimal min value = {dcMin}\n");

            char chMax = char.MaxValue;
            char chMin = char.MinValue;
            Console.WriteLine($"Char max value = {chMax}");
            Console.WriteLine($"Char min value = {chMin}");
        }
    }
}
