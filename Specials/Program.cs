using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables with the respective maximum and minimum values
            // of byte
            byte bMax = byte.MaxValue;
            byte bMin = byte.MinValue;
            Console.WriteLine($"Byte max value = {bMax}");
            Console.WriteLine($"Byte min value = {bMin}\n");

            // Variables with the respective maximum and minimum values
            // of sbyte
            sbyte sbMax = sbyte.MaxValue;
            sbyte sbMin = sbyte.MinValue;
            Console.WriteLine($"sByte max value = {sbMax}");
            Console.WriteLine($"sByte min value = {sbMin}\n");

            // Variables with the respective maximum and minimum values
            // of short
            short shMax = short.MaxValue;
            short shMin = short.MinValue;
            Console.WriteLine($"Short max value = {shMax}");
            Console.WriteLine($"Short min value = {shMin}\n");
            
            // Variables with the respective maximum and minimum values
            // of ushort
            ushort ushMax = ushort.MaxValue;
            ushort ushMin = ushort.MinValue;
            Console.WriteLine($"uShort max value = {ushMax}");
            Console.WriteLine($"uShort min value = {ushMin}\n");

            // Variables with the respective maximum and minimum values
            // of int
            int intMax = int.MaxValue;
            int intMin = int.MinValue;
            Console.WriteLine($"Int max value = {intMax}");
            Console.WriteLine($"Int min value = {intMin}\n");

            // Variables with the respective maximum and minimum values
            // of uint
            uint uintMax = uint.MaxValue;
            uint uintMin = uint.MinValue;
            Console.WriteLine($"uInt max value = {uintMax}");
            Console.WriteLine($"uInt min value = {uintMin}\n");

            // Variables with the respective maximum and minimum values
            // of long
            long longMax = long.MaxValue;
            long longMin = long.MinValue;
            Console.WriteLine($"Long max value = {longMax}");
            Console.WriteLine($"Long min value = {longMin}\n");

            // Variables with the respective maximum and minimum values
            // of ulong
            ulong ulongMax = ulong.MaxValue;
            ulong ulongMin = ulong.MinValue;
            Console.WriteLine($"uLong max value = {ulongMax}");
            Console.WriteLine($"uLong min value = {ulongMin}\n");

            // Variables with the respective maximum and minimum values
            // of float
            float fMax = float.MaxValue;
            float fMin = float.MinValue;
            Console.WriteLine($"Float max value = {fMax}");
            Console.WriteLine($"Float min value = {fMin}\n");

            // Variables with the respective maximum and minimum values
            // of double
            double dbMax = double.MaxValue;
            double dbMin = double.MinValue;
            Console.WriteLine($"Double max value = {dbMax}");
            Console.WriteLine($"Double min value = {dbMin}\n");

            // Variables with the respective maximum and minimum values
            // of decimal
            decimal dcMax = decimal.MaxValue;
            decimal dcMin = decimal.MinValue;
            Console.WriteLine($"Decimal max value = {dcMax}");
            Console.WriteLine($"Decimal min value = {dcMin}\n");

            // Variables with the respective maximum and minimum values
            // of char
            char chMax = char.MaxValue;
            char chMin = char.MinValue;
            Console.WriteLine($"Char max value = {chMax}");
            Console.WriteLine($"Char min value = {chMin}\n");

            // Variables with the positive infinity, negative infinity and
            // NaN values
            double PosInf = double.PositiveInfinity;
            double NegInf = double.NegativeInfinity;
            float NaN = float.NaN;
            Console.WriteLine($"Positive infinity value = {PosInf}");
            Console.WriteLine($"Negative infinity value = {NegInf}");
            Console.WriteLine($"Invalid number value = {NaN}");

            // Overflow with ints examples
            intMax = intMax + 1;
            Console.WriteLine($"Max value of int + 1 = {intMax}");

            intMin = intMin - 1;
            Console.WriteLine($"Min value of int - 1 = {intMin}");

            // Overflow with a float and a double examples
            fMax = fMax * 2;
            dbMax = dbMax + 1;

            Console.WriteLine($"Max value of float * 2 = {fMax}");
            Console.WriteLine($"Max value of double + 1 = {dbMax}");

            // Underflow with floats example
            float f1, f2;
            f1 = f2 = 10000.0f;
            bool Compare = (f1 == f2 + 0.0001f);
            Console.WriteLine($"Is {f1} equal to {f2} + 0.0001f? {Compare}");
        }
    }
}